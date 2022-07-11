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

            return "Other"; //Default categorisation
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

        public static double Total(List<Transaction> transactions, DateTime startDate, DateTime endDate, string category)
        {
            double total = 0;
            startDate = startDate.Date + new TimeSpan(00, 00, 00);
            endDate = endDate.Date + new TimeSpan(23, 59, 59);

            foreach (Transaction transaction in transactions)
            {
                if (transaction.Date >= startDate && transaction.Date <= endDate)
                {
                    if(category != null && transaction.Category == category.ToLower()) 
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

    }
}
