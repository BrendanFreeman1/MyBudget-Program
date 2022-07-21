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
        public static List<Transaction> LoadTransactions()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString("transactions")))
            {
                var output = cnn.Query<Transaction>("select * from Transactions", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveTransaction(Transaction transaction)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString("transactions")))
            {
                if (transaction.Category != "Ignore")
                {
                    cnn.Execute("insert into Transactions (Date, Description, Value, Category) values (@Date, @Description, @Value, @Category)", transaction);
                }
            }
        }

        public static List<Category> LoadCategories()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString("categories")))
            {
                var output = cnn.Query<Category>("select * from Categories", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<string> LoadUniqueCategoryList()
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

        public static void SaveCategory(Category category)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString("categories")))
            {
                cnn.Execute("insert into Categories (Name, Tag) values (@Name, @Tag)", category);
            }
        }



        private static string LoadConnectionString(string id)
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }








    }
}
