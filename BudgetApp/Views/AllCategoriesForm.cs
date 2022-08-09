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

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            int row = dataGridView.CurrentRow.Index;
            Category category = categoriesList[row];

            categoriesList.Remove(category);
            dataGridView.Rows.RemoveAt(row);
            CategoriesDataAccess.DeleteCategory(category);
        }

        private void CreateCategorybtn_Click(object sender, EventArgs e)
        {
            CustomCategoryForm customCategoryForm = new CustomCategoryForm();
            customCategoryForm.FormClosed += new FormClosedEventHandler(Child_FormClosed);
            customCategoryForm.Show();
        }

        void Child_FormClosed(object sender, FormClosedEventArgs e)
        {
            PopulateForm();
        }

        private void UpBtn_Click(object sender, EventArgs e)
        {
            int row = dataGridView.CurrentRow.Index;

            //Only proceed if we're not at the first item in the list
            if(row > 0) { MoveSelected(row, true); }
        }

        private void DownBtn_Click(object sender, EventArgs e)
        {
            int row = dataGridView.CurrentRow.Index;

            //Only proceed if we're not at the last item in the list
            if (row < categoriesList.Count-1) MoveSelected(row, false);
        }

        private void MoveSelected(int row, bool movingUp)
        {
            int rowToSwap;

            if (movingUp) { rowToSwap = row - 1; } else { rowToSwap = row + 1; }

            Category selectedCategory = categoriesList[row];
            Category categoryToSwap = categoriesList[rowToSwap];

            //Swap categories in List
            categoriesList[row] = categoryToSwap;
            categoriesList[rowToSwap] = selectedCategory;

            //Swap categories in database
            CategoriesDataAccess.UpdateCategory(selectedCategory, movingUp); //Moving up one position
            CategoriesDataAccess.UpdateCategory(categoryToSwap, !movingUp); //Moving down one position

            //Redraw DataGridView
            dataGridView.Rows.Clear();
            CategoryDGVBuilder.PopulateCategoryRows(dataGridView, categoriesList);

            //Set the selection back to the category the user had selectedCategory previously
            dataGridView.CurrentCell = dataGridView.Rows[rowToSwap].Cells[0];
        }
    }
}
