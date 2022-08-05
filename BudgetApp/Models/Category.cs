using BudgetApp.Views;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BudgetApp.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Tag { get; set; }

        //Parameterless Constructor
        internal Category() {}

        internal Category(string categoryName, string tag)
        {
            Name = categoryName;
            Tag = tag;
        }

        internal static void SaveDefaultCategories()
        {
            //After the users categories have been loaded from their database into the categoriesList
            //Check if it contains the default categories, if not add them to the database
            //Should only work on the users intial use of this app

            List<Category> defaultCategories = new List<Category>
            {
                new Category ("Children", null),
                new Category ("Debt", null),
                new Category ("Education", null),
                new Category ("Entertainment", null),
                new Category ("Everyday", null),
                new Category ("Gifts", null),
                new Category ("Ignore", null),
                new Category ("Income", null),
                new Category ("Insurance", null),
                new Category ("Other", null),
                new Category ("Pets", null),
                new Category ("Transportation", null),
                new Category ("Travel", null),
                new Category ("Utilities", null)
            };

            //Get the names of the categories already in the database
            List<string> categoryNames = CategoriesDataAccess.LoadCategories().Select(c => c.Name).ToList();

            //Compair the categories we want to add against what we already have
            foreach (Category defaultCategory in defaultCategories)
            {
                if (!categoryNames.Contains(defaultCategory.Name)) { CategoriesDataAccess.SaveCategory(defaultCategory); }
            }
        }
    }
}
