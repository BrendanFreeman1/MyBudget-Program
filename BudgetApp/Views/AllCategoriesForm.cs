using BudgetApp.Models;
using System;
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
            dataGridView.Rows.Clear();

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

        private void CreateCategorybtn_Click(object sender, System.EventArgs e)
        {
            CustomCategoryForm customCategoryForm = new CustomCategoryForm();
            customCategoryForm.FormClosed += new FormClosedEventHandler(child_FormClosed);
            customCategoryForm.Show();
        }

        void child_FormClosed(object sender, FormClosedEventArgs e)
        {
            PopulateForm();
        }
    }
}
