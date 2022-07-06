using System;
using System.Collections.Generic;

namespace BudgetApp.Models
{
    internal class Transaction
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public double Value { get; set; }
        public string Category { get; set; }

        public static string AutoCategorise(Transaction transaction)
        {

            foreach (Category category in SqliteDataAccess.LoadCategories())
            {
                if (category.Tag != null && transaction.Description.ToLower().Contains(category.Tag))
                {
                    return category.Name;
                }
            }  
            
            //SOMETIMES RETURNS 'Other' AND OTHER TIMES 'other' ???
            return "Other";
        }



        public static double Total(List<Transaction> transactions)
        {
            double total = 0;
            foreach(Transaction transaction in transactions)
            {
                total += transaction.Value;
            }

            return total;
        }

        public static double TotalByCategory(List<Transaction> transactions, string category)
        {
            double total = 0;
            foreach (Transaction transaction in transactions)
            {
                if (transaction.Category == category) { total += transaction.Value; }
            }

            return total;
        }

        public static double TotalByDate(List<Transaction> transactions, DateTime startDate, DateTime endDate)
        {
            double total = 0;
            foreach (Transaction transaction in transactions)
            { 
                if (transaction.Date >= startDate && transaction.Date <= endDate) { total += transaction.Value; }
            }

            return total;
        }

    }
}
