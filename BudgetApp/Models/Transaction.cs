using System;
using System.Collections.Generic;
using Excel = Microsoft.Office.Interop.Excel;

namespace BudgetApp.Models
{
    public class Transaction
    {
        private static List<Category> categoriesList = new List<Category>();
        
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public double Value { get; set; }
        public string Category { get; set; }

        internal static string AutoCategorise(Transaction transaction)
        {
            categoriesList = CategoriesDataAccess.LoadCategories();
            string defaultCategory = "Other";

            foreach (Category category in categoriesList)
            {
                //If the sample text is found within the transactionList description return the corresponding category
                if (category.Tag != null && transaction.Description.ToLower().Contains(category.Tag))
                {
                    return category.Name;
                }
            }

            //If nothing is found return "Other" as the category
            return defaultCategory; 
        }

        internal static double Total(List<Transaction> transactions)
        {
            double total = 0;
            //Add up the values for each transaction in the list past in.
            foreach(Transaction transaction in transactions)
            {
                total += transaction.Value;
            }

            return total;
        }

        internal static double Total(List<Transaction> transactions, DateTime startDate, DateTime endDate, string category)
        {
            double total = 0;
            startDate = startDate.Date + new TimeSpan(00, 00, 00);
            endDate = endDate.Date + new TimeSpan(23, 59, 59);

            foreach (Transaction transaction in transactions)
            {
                if (transaction.Date >= startDate && transaction.Date <= endDate)
                {
                    if (category != null && transaction.Category.ToLower() == category.ToLower()) 
                    { 
                        total += transaction.Value;
                    }

                    if(category == null)
                    {
                        total += transaction.Value;
                    }
                }
            }
            return total;
        }

        internal static Transaction GetTransactionDataFromExcel(int row, Excel.Worksheet xlWorkSheet)
        {
            Transaction transaction = new Transaction();

            //DATE
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

            //DESCRIPTION
            transaction.Description = xlWorkSheet.Cells[row, 2].value;

            //VALUE
            if (xlWorkSheet.Cells[row, 3].value != null)
            {
                transaction.Value = xlWorkSheet.Cells[row, 3].value; //Credit 
            }
            else
            {
                transaction.Value = xlWorkSheet.Cells[row, 4].value; //Debit
            }

            //CATEGORY
            transaction.Category = AutoCategorise(transaction);

            return transaction;
        }
    }
}
