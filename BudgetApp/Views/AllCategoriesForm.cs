using BudgetApp.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BudgetApp.Views
{
    public partial class AllCategoriesForm : Form
    {
        private List<Category> categoriesList = new List<Category>();

        public AllCategoriesForm()
        {
            InitializeComponent();
            PopulateForm();
        }

        private void PopulateForm()
        {
            CategoriesLabel.Text = "Transactions will be auto\ncategorised by the order\nof the tags displayed\nhere.Please reorder this list\nto adjust which tags you\nwant to have priority.";

            categoriesList.Clear();
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();

            categoriesList = CategoriesDataAccess.LoadAllCategories();
            CategoryDGVBuilder.CreateCategoryColumns(dataGridView);
            CategoryDGVBuilder.CreateCategoryRows(dataGridView, categoriesList);
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if(dataGridView.CurrentRow == null) return;

            int row = dataGridView.CurrentRow.Index;
            Category category = categoriesList[row];

            CategoriesDataAccess.DeleteCategory(category);
            categoriesList.Remove(category);
            dataGridView.Rows.RemoveAt(row);
        }

        private void CreateCategorybtn_Click(object sender, EventArgs e)
        {
            CustomCategoryForm customCategoryForm = new CustomCategoryForm();
            customCategoryForm.FormClosed += new FormClosedEventHandler(CreateCategoryForm_Closed);
            customCategoryForm.Show();
        }

        private void CreateCategoryForm_Closed(object sender, FormClosedEventArgs e)
        {
            PopulateForm();
        }

        private void UpBtn_Click(object sender, EventArgs e)
        {
            if(dataGridView.CurrentRow != null)
            {
                int row = dataGridView.CurrentRow.Index;
                if (row > 0) { MoveSelected(row, row - 1); }
            }

        }

        private void DownBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                int row = dataGridView.CurrentRow.Index;
                if (row < categoriesList.Count - 1) MoveSelected(row, row + 1);
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MoveSelected(int row, int rowToSwap)
        {
            Category selectedCategory = categoriesList[row];           
            Category categoryToSwap = categoriesList[rowToSwap];

            CategoriesDataAccess.UpdateCategory(selectedCategory, categoryToSwap.ID);
            CategoriesDataAccess.UpdateCategory(categoryToSwap, selectedCategory.ID);

            CategoryDGVBuilder.PopulateCategoryRow(dataGridView, categoryToSwap, row);
            CategoryDGVBuilder.PopulateCategoryRow(dataGridView, selectedCategory, rowToSwap);

            categoriesList.Clear();
            categoriesList = CategoriesDataAccess.LoadAllCategories();

            //Set the selection back to the previous selection
            dataGridView.CurrentCell = dataGridView.Rows[rowToSwap].Cells[0];
        }

        private void LoadDefaultBtn_Click(object sender, EventArgs e)
        {
            Category.SaveDefaultCategories();

            PopulateForm();
        }
    }
}
