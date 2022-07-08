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
            Category category = new Category(char.ToUpper(categoryNameBox.Text[0]) + categoryNameBox.Text.Substring(1), tagBox.Text.ToLower());

            if(category.Tag == "") { category.Tag = null; }

            SqliteDataAccess.SaveCategory(category);

            //Re-Populate the ComboBox with the updated Categories list
            ImportDataForm.PopulateCategoryComoboBox();

            Close();
        }
    }
}
