using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace BudgetApp.Models
{
    public class Transaction
    {
        private static List<Category> categoriesList = new List<Category>();

        public int ID { get; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public double Value { get; set; }
        public string Category { get; set; }

        /// <summary>
        /// Attempts to find the Tag value of a category within the id value of the transaction passed in. If found returns the Name value of that category.
        /// </summary>
        /// <param name="transaction"></param>
        /// <returns>A string representing a Category. If no category is found, returns "Other"</returns>
        internal static string AutoCategorise(Transaction transaction)
        {
            categoriesList = CategoriesDataAccess.LoadAllCategories();
            const string DEFAULT_CATEGORY = "Other";

            foreach (Category category in categoriesList)
            {
                //If the Tag is found within the transactionsList Description, return the corresponding category
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
        /// If category is null, returns the total of all transactions in the list.
        /// </summary>
        /// <param name="transactionsList"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="category"></param>
        /// <returns>A double representing the total value of all transactions of the specified category from the start to end date(inclusive)</returns>
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

                    else if (category == null)
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
        /// Gets the transaction object in the selected row and updates it with the passed category value in the dataGridView, transactionsList and the users database if updateDatabase is true. 
        /// If updating the category to 'Ignore', deletes the transaction from the dataGridView, the transactionsList and the users database if updateDatabase is true.
        /// </summary>
        /// <param name="dataGridView"></param>
        /// <param name="transactionsList"></param>
        /// <param name="category"></param>
        /// <returns>The currently selected Transaction in the DataGridView with its Category value updated to the category passed in. If nothing is selected returns null.</returns>
        internal static Transaction UpdateTransactionCategory(DataGridView dataGridView, List<Transaction> transactionsList, string category, bool updateDatabase)
        {
            if (dataGridView.CurrentRow == null) { return null; }

            int row = dataGridView.CurrentRow.Index;

            int ID = (int)dataGridView.Rows[row].Cells[0].Value;
            Transaction currentTransaction = GetTransactionFromID(transactionsList, ID);

            if (currentTransaction != null)
            {
                if(category == "Ignore")
                {
                    TransactionsDataAccess.DeleteTransaction(currentTransaction);
                    transactionsList.Remove(currentTransaction);
                    dataGridView.Rows.RemoveAt(row);
                }
                else 
                {
                    currentTransaction.Category = category;
                    TransactionsDGVBuilder.PopulateTransactionRow(dataGridView, currentTransaction, row);
                    if (updateDatabase) { TransactionsDataAccess.UpdateTransactionCategory(currentTransaction); }
                }
            }

            dataGridView.CurrentCell = dataGridView.Rows[row].Cells[1]; 

            return currentTransaction;
        }

        /// <summary>
        /// The transactionsList passed in is autocategorised with the category passed in. Updates the transactionsList and the users database if updateDatabase is true.
        /// </summary>
        /// <param name="transactionsList"></param>
        /// <param name="updateDataBase"></param>
        internal static void UpdateAllTransactionsCategory(List<Transaction> transactionsList, Category category, bool updateDataBase)
        {
            foreach(Transaction transaction in transactionsList)
            {
                string autoCategory = AutoCategorise(transaction);
                if (autoCategory == category.Name)
                {
                    transaction.Category = autoCategory;
                    if(updateDataBase) { TransactionsDataAccess.UpdateTransactionCategory(transaction); }
                }
            }
        }

        /// <summary>
        /// Search through the transactionsList passed in (If nothing is passed in it will seach all transactionsList stored in user database)
        /// and return the transaction whoes id value matches the id passed in.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Returns null if no corresponding object is found</returns>
        private static Transaction GetTransactionFromID(List<Transaction> transactionsList, int id)
        {
            if(transactionsList == null) { transactionsList = TransactionsDataAccess.LoadAllTransactions(); }            
            
            foreach(Transaction transaction in transactionsList)
            {
                if(transaction.ID == id) { return transaction; }
            }

            return null;
        }
    }
}
