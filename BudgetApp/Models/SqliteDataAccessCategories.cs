using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace BudgetApp.Models
{
    internal class CategoriesDataAccess : SqliteDataAccess
    {   
        internal static List<Category> LoadAllCategories()
        {
            using (IDbConnection cnn = new SQLiteConnection(GetConnectionString("categories")))
            {
                return cnn.Query<Category>("SELECT * FROM Categories", new DynamicParameters()).ToList();
            }
        }

        internal static void SaveCategory(Category category)
        {
            using (IDbConnection cnn = new SQLiteConnection(GetConnectionString("categories")))
            {
                cnn.Execute("INSERT INTO Categories (Name, Tag) VALUES (@Name, @Tag)", category);
            }
        }

        internal static void DeleteCategory(Category category)
        {
            using (IDbConnection cnn = new SQLiteConnection(GetConnectionString("categories")))
            {
                cnn.Execute("DELETE FROM Categories WHERE ID = @ID", category);
            }
        }

        /// <summary>
        /// Changes the Name and Tag values of the category that matches the id passed in.
        /// </summary>
        /// <param name="category"></param>
        /// <param name="id"></param>
        internal static void UpdateCategory(Category category, int id)
        {            
            using (IDbConnection cnn = new SQLiteConnection(GetConnectionString("categories")))
            {
                cnn.Execute("UPDATE Categories SET Name = @Name WHERE ID = " + id, category);
                cnn.Execute("UPDATE Categories SET Tag = @Tag WHERE ID = " + id, category);
            }
        }

        /// <summary>
        /// Gets the users categories without any repeats.
        /// </summary>
        /// <returns>A list of strings representing each category in the users database</returns>
        internal static List<string> LoadUniqueCategoryList()
        {
            List<string> uniqueCategoriesList = new List<string>();
            List<string> categoryNames = LoadAllCategories().Select(c => c.Name).ToList();

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
