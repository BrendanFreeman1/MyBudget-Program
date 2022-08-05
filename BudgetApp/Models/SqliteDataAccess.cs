using Dapper;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace BudgetApp.Models
{
    internal class SqliteDataAccess
    {
        internal static List<Transaction> LoadTransactions()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString("transactions")))
            {
                var output = cnn.Query<Transaction>("SELECT * FROM Transactions", new DynamicParameters());
                return output.ToList();
            }
        }

        internal static void SaveTransaction(Transaction transaction)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString("transactions")))
            {
                if (transaction.Category != "Ignore")
                {
                    cnn.Execute("INSERT INTO Transactions (Date, Description, Value, Category) VALUES (@Date, @Description, @Value, @Category)", transaction);
                }
            }
        }

        internal static void UpdateTransaction(Transaction transaction)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString("transactions")))
            {
                if (transaction.Category != "Ignore")
                {
                    cnn.Execute("UPDATE Transactions SET Category = @Category WHERE ID = @ID", transaction);
                }
            }
        }

        internal static void DeleteTransaction(Transaction transaction)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString("transactions")))
            {
                cnn.Execute("DELETE FROM Transactions WHERE ID = @ID", transaction);
            }
        }

        internal static List<Category> LoadCategories()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString("categories")))
            {
                var output = cnn.Query<Category>("SELECT * FROM Categories", new DynamicParameters());
                return output.ToList();
            }
        }

        internal static List<string> LoadUniqueCategoryList()
        {
            List<Category> categoriesList = LoadCategories();
            List<string> uniqueCategoriesList = new List<string>();

            //Get the names of the categories in the database
            List<string> categoryNames = categoriesList.Select(c => c.Name).ToList();
            //Populate the unique Categories List
            foreach (string name in categoryNames)
            {
                //Only add the name if its not already in the uniqueCategoriesList
                if (!uniqueCategoriesList.Contains(name)) { uniqueCategoriesList.Add(name); }
            }

            return uniqueCategoriesList;
        }

        internal static void SaveCategory(Category category)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString("categories")))
            {
                cnn.Execute("INSERT INTO Categories (Name, Tag) VALUES (@Name, @Tag)", category);
            }
        }

        private static string LoadConnectionString(string id)
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }








    }
}
