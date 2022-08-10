using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;


namespace BudgetApp.Models
{
    internal class CategoriesDataAccess : SqliteDataAccess
    {   
        internal static List<Category> LoadCategories()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString("categories")))
            {
                return cnn.Query<Category>("SELECT * FROM Categories", new DynamicParameters()).ToList();
            }
        }

        internal static void SaveCategory(Category category)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString("categories")))
            {
                cnn.Execute("INSERT INTO Categories (Name, Tag) VALUES (@Name, @Tag)", category);
            }
        }

        internal static void DeleteCategory(Category category)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString("categories")))
            {
                cnn.Execute("DELETE FROM Categories WHERE ID = @ID", category);
            }
        }

        internal static void UpdateCategoryID(Category category, int newID)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString("categories")))
            {
                cnn.Execute("UPDATE Categories SET ID = " + newID + " WHERE ID = @ID", category);
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
    }
}
