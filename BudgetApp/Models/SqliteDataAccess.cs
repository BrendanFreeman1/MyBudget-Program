using System.Configuration;


namespace BudgetApp.Models
{
    internal class SqliteDataAccess
    {
        /// <summary>
        /// Gets the required connection string from the App.Config file.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>A string representing the location of the file to acccess</returns>
        internal static string LoadConnectionString(string id)
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
