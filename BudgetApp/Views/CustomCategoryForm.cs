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
            Category category = new Category { CategoryName = categoryNameBox.Text.ToLower(), Tag = tagBox.Text.ToLower() };

            if(category.Tag == "") { category.Tag = null; }

            SqliteDataAccess.SaveCategory(category);

            Close();
        }
    }
}
