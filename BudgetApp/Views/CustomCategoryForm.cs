using BudgetApp.Models;
using System;
using System.Windows.Forms;

namespace BudgetApp.Views
{
    internal partial class CustomCategoryForm : Form
    {
        public CustomCategoryForm()
        {
            InitializeComponent();
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            if(categoryNameBox.Text != "") 
            {
                Category category = new Category(char.ToUpper(categoryNameBox.Text[0]) + categoryNameBox.Text.Substring(1), tagBox.Text.ToLower());

                if (category.Tag == "") { category.Tag = null; }

                CategoriesDataAccess.SaveCategory(category);

                Close();
            }
            else
            {
                MessageBox.Show("You must supply a category", "No Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
