using System.Collections.Generic;
using System.Windows.Forms;

namespace BudgetApp.Models
{
    internal class ComboBoxBuilder
    {
        internal static void PopulateComboBox(ComboBox comoboBox)
        {
            List<Category> categoriesList = CategoriesDataAccess.LoadAllCategories();

            foreach (Category category in categoriesList)
            {
                if (!comoboBox.Items.Contains(category.Name))
                {
                    comoboBox.Items.Add(category.Name);
                }
            }
        }
    }
}
