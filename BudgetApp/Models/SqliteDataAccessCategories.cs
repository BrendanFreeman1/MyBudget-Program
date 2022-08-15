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

        internal static void UpdateCategoryID(Category category, int newId)
        {            
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString("categories")))
            {
                cnn.Execute("UPDATE Categories SET Name = @Name WHERE ID = " + newId, category);
                cnn.Execute("UPDATE Categories SET Tag = @Tag WHERE ID = " + newId, category);
            }
        }

        internal static List<string> LoadUniqueCategoryList()
        {
            List<Category> categoriesList = LoadCategories();
            List<string> uniqueCategoriesList = new List<string>();

            //Get the names of each category in the database
            List<string> categoryNames = categoriesList.Select(c => c.Name).ToList();
            foreach (string name in categoryNames)
            {
                if (!uniqueCategoriesList.Contains(name)) 
                { 
                    uniqueCategoriesList.Add(name); 
                }
            }

            return uniqueCategoriesList;
        }
    }
}
