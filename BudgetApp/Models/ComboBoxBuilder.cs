using System.Windows.Forms;

namespace BudgetApp.Models
{
    internal class ComboBoxBuilder
    {
        internal static void PopulateComboBox(ComboBox comoboBox)
        {
            foreach (Category category in CategoriesDataAccess.LoadCategories())
            {
                if (!comoboBox.Items.Contains(category.Name))
                {
                    comoboBox.Items.Add(category.Name);
                }
            }
        }
    }
}
