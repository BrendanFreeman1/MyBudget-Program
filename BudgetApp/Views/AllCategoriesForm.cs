using BudgetApp.Models;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BudgetApp.Views
{
    public partial class AllCategoriesForm : Form
    {
        List<Category> categoriesList = new List<Category>();

        public AllCategoriesForm()
        {
            InitializeComponent();
            PopulateForm();
        }

        private void PopulateForm()
        {
            categoriesList.Clear();
            categoriesList = CategoriesDataAccess.LoadCategories();

            CategoryDGVBuilder.PopulateCategoryColumns(dataGridView);

            CategoryDGVBuilder.PopulateCategoryRows(dataGridView, categoriesList);
        }

        private void Deletebtn_Click(object sender, System.EventArgs e)
        {
            int row = dataGridView.CurrentCell.RowIndex;
            Category category = categoriesList[row];

            categoriesList.Remove(category);
            dataGridView.Rows.RemoveAt(row);
            CategoriesDataAccess.DeleteCategory(category);
        }
    }
}
