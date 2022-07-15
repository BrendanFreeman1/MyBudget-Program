using BudgetApp.Models;
using System;
using System.Windows.Forms;

namespace BudgetApp.Views
{
    public partial class CustomCategoryForm : Form
    {
        public CustomCategoryForm()
        {
            InitializeComponent();
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            //Create new category object with data from the user input fields
            Category category = new Category(char.ToUpper(categoryNameBox.Text[0]) + categoryNameBox.Text.Substring(1), tagBox.Text.ToLower());

            //If the user is just adding a category with no tag, set the tag to null
            if(category.Tag == "") { category.Tag = null; }

            //Save the new category to the database
            SqliteDataAccess.SaveCategory(category);

            //Re-Populate the ComboBox with the updated Categories list
            ImportDataForm.PopulateCategoryComoboBox();
            ImportDataForm.UpdateTransactionsCategories();

            Close();
        }
    }
}
