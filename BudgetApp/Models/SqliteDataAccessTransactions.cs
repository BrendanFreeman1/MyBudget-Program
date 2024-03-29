﻿using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace BudgetApp.Models
{
    internal class TransactionsDataAccess : SqliteDataAccess
    {
        internal static List<Transaction> LoadAllTransactions()
        {
            using (IDbConnection cnn = new SQLiteConnection(GetConnectionString("transactions")))
            {
                return cnn.Query<Transaction>(" SELECT * FROM Transactions ORDER BY ID", new DynamicParameters()).ToList();
            }
        }

        internal static void SaveTransaction(Transaction transaction)
        {
            using (IDbConnection cnn = new SQLiteConnection(GetConnectionString("transactions")))
            {
                if (transaction.Category != "Ignore")
                {
                    cnn.Execute("INSERT INTO Transactions (Date, Description, Value, Category) VALUES (@Date, @Description, @Value, @Category)", transaction);
                }
            }
        }

        internal static void DeleteTransaction(Transaction transaction)
        {
            using (IDbConnection cnn = new SQLiteConnection(GetConnectionString("transactions")))
            {
                cnn.Execute("DELETE FROM Transactions WHERE ID = @ID", transaction);
            }
        }

        internal static void UpdateTransactionCategory(Transaction transaction)
        {
            using (IDbConnection cnn = new SQLiteConnection(GetConnectionString("transactions")))
            {
                if (transaction.Category != "Ignore")
                {
                    cnn.Execute("UPDATE Transactions SET Category = @Category WHERE ID = @ID", transaction);
                }
            }
        }
    }
}
