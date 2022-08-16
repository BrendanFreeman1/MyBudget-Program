using BudgetApp.Views;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BudgetApp.Models
{
    public class Category
    {
        public int ID { get; }
        public string Name { get; set; }
        public string Tag { get; set; }

        //Parameterless Constructor
        internal Category() {}

        internal Category(string categoryName, string tag)
        {
            Name = categoryName;
            Tag = tag;
        }

        
        /// <summary>
        /// Adds default categories to the users database
        /// </summary>
        internal static void SaveDefaultCategories()
        {
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
                new Category ("Utilities", null),
                new Category ("Utilities", "water"),
                new Category ("Utilities", "electricity"),
                new Category ("Home", "mortgage"),
                new Category ("Home", "rent"),
                new Category ("Everyday", "shopping")
            };

            List<string> categoryNames = CategoriesDataAccess.LoadAllCategories().Select(c => c.Name).ToList();

            foreach (Category defaultCategory in defaultCategories)
            {
                if (!categoryNames.Contains(defaultCategory.Name)) 
                { 
                    CategoriesDataAccess.SaveCategory(defaultCategory); 
                }
            }
        }
    }
}
