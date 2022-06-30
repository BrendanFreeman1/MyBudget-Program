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
            //Connect and open the Transactionsdb Database
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Transaction>("select * from Transactions", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveTransaction(Transaction transaction)
        {
            //Connect to the Transactionsdb Database
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Transactions (Date, Description, Value, Category) values (@Date, @Description, @Value, @Category)", transaction);
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }


    }
}
