using System;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace BudgetApp.Models
{
    internal class SqliteDataAccess
    {
        internal static string GetConnectionString(string id)
        {
            return "Data Source=" + id.ToLower() + ".db; Version=3;";
        }

        internal static void CreateDatabaseFile(string databaseName, string createTableCommand)
        {
            string dbPath = Path.Combine(Directory.GetCurrentDirectory(), databaseName + ".db");

            if (!File.Exists(dbPath))
            {
                SQLiteConnection.CreateFile(dbPath);

                SQLiteConnection Connection = new SQLiteConnection(GetConnectionString(databaseName));
                Connection.Open();
                SQLiteCommand Command = new SQLiteCommand(createTableCommand, Connection);
                Command.ExecuteNonQuery();
                Connection.Close();
            }         
        }
    }
}
