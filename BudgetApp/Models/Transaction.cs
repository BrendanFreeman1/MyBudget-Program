using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace BudgetApp.Models
{
    public class Transaction
    {
        private static List<Category> categoriesList = new List<Category>();

        public int ID;
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public double Value { get; set; }
        public string Category { get; set; }

        /// <summary>
        /// Attempts to find the 'Tag' value of a category within the description value of the transaction passed in. If found assigns that transaction with the corresponding category name.
        /// </summary>
        /// <param name="transaction"></param>
        /// <returns>A string representing a Category. If no category is found, returns "Other"</returns>
        internal static string AutoCategorise(Transaction transaction)
        {
            categoriesList = CategoriesDataAccess.LoadAllCategories();
            const string DEFAULT_CATEGORY = "Other";

            foreach (Category category in categoriesList)
            {
                //If the Tag is found within the transactionsList description, return the corresponding category
                if (category.Tag != null && transaction.Description.ToLower().Contains(category.Tag))
                {
                    return category.Name;
                }
            }

            //If nothing is found return "Other" as the category
            return DEFAULT_CATEGORY; 
        }

        /// <summary>
        /// Gets the total of all values of the transactions in the transactionsList that correspond to the category and fall between the dates(inclusive) passed in.
        /// If category is null, it will inslude all transactions in the list.
        /// </summary>
        /// <param name="transactionsList"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="category"></param>
        /// <returns>A double representing the total value of all transactions of the specified category from the start to end date.</returns>
        internal static double Total(List<Transaction> transactionsList, DateTime startDate, DateTime endDate, string category)
        {
            double total = 0;
            startDate = startDate.Date + new TimeSpan(00, 00, 00);
            endDate = endDate.Date + new TimeSpan(23, 59, 59);

            foreach (Transaction transaction in transactionsList)
            {
                if (transaction.Date >= startDate && transaction.Date <= endDate)
                {
                    if (category != null && transaction.Category.ToLower() == category.ToLower()) 
                    { 
                        total += transaction.Value;
                    }


                    if (category == null)
                    {
                        total += transaction.Value;
                    }
                }
            }
            return total;
        }

        /// <summary>
        /// Extracts data from the worksheet passed in into a transaction object.
        /// </summary>
        /// <param name="row"></param>
        /// <param name="xlWorkSheet"></param>
        /// <returns>A Transaction object</returns>
        internal static Transaction GetTransactionDataFromExcel(int row, Excel.Worksheet xlWorkSheet)
        {
            Transaction transaction = new Transaction();

            //Excel is feeding some of the dates as DateTime objects(day of month > 12) and some as strings(day of month <= 12).
            var currentDate = xlWorkSheet.Cells[row, 1].value;
            if (currentDate is string)
            {
                transaction.Date = DateTime.Parse(currentDate);
            }
            else
            {
                //The DateTime object being fed in is being saved in MM/dd/yyyy format.
                //To correct that to dd/MM/yyyy i'm converting it to a string, then back to a DateTime object.
                transaction.Date = DateTime.Parse(currentDate.ToString("MM/dd/yyyy"));
            }

            transaction.Description = xlWorkSheet.Cells[row, 2].value;

            if (xlWorkSheet.Cells[row, 3].value != null)
            {
                transaction.Value = xlWorkSheet.Cells[row, 3].value; //Credit 
            }
            else
            {
                transaction.Value = xlWorkSheet.Cells[row, 4].value; //Debit
            }

            transaction.Category = AutoCategorise(transaction);

            return transaction;
        }

       
        /// <summary>
        /// Checks if the user has a row selected and if so will update the category value in the DataGridView, our transactionsList and the users database.
        /// </summary>
        /// <param name="dataGridView"></param>
        /// <param name="transactionList"></param>
        /// <param name="category"></param>
        internal static void UpdateTransactionCategory(DataGridView dataGridView, List<Transaction> transactionList, string category)
        {
            if (dataGridView.CurrentRow == null) { return; }

            int row = dataGridView.CurrentRow.Index;
            string description = dataGridView.Rows[row].Cells[1].Value.ToString();

            Transaction currentTransaction = GetTransactionFromDescription(transactionList, description);

            if (currentTransaction != null)
            {
                currentTransaction.Category = category;
                TransactionsDGVBuilder.PopulateTransactionRow(dataGridView, currentTransaction, row);
                TransactionsDataAccess.UpdateTransactionCategory(currentTransaction);
            }

            dataGridView.CurrentCell = dataGridView.Rows[row].Cells[0];
        }

        /// <summary>
        /// Search through all transactionsList passed in (If nothing is passed in it will seach all transactionsList stored in user database)
        /// and return the transaction whoes description value matches the description passed into the method.
        /// </summary>
        /// <param name="description"></param>
        /// <returns>Returns null if no corresponding object is found</returns>
        private static Transaction GetTransactionFromDescription(List<Transaction> transactionList, string description)
        {
            if(transactionList == null) { transactionList = TransactionsDataAccess.LoadAllTransactions(); }            
            
            foreach(Transaction transaction in transactionList)
            {
                if(transaction.Description == description) { return transaction; }
            }

            return null;
        }
    }
}
