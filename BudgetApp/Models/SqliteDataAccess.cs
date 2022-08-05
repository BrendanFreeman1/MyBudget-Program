using System.Configuration;


namespace BudgetApp.Models
{
    internal class SqliteDataAccess
    {
        internal static string LoadConnectionString(string id)
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
