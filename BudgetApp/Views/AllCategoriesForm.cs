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
            CategoriesLabel.Text = "Transactions will be auto\ncategorised by the order\nof the tags displayed\nhere.Please reorder this list\nto adjust which tags you\nwant to have priority.";

            categoriesList.Clear();
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();

            categoriesList = CategoriesDataAccess.LoadCategories();
            CategoryDGVBuilder.PopulateCategoryColumns(dataGridView);
            CategoryDGVBuilder.PopulateCategoryRows(dataGridView, categoriesList);
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
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
            int row = dataGridView.CurrentRow.Index;
            if(row > 0) { MoveSelected(row, row-1); }
        }

        private void DownBtn_Click(object sender, EventArgs e)
        {
            int row = dataGridView.CurrentRow.Index;
            if (row < categoriesList.Count-1) MoveSelected(row, row+1);
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MoveSelected(int row, int rowToSwap)
        {
            Category selectedCategory = categoriesList[row];           
            Category categoryToSwap = categoriesList[rowToSwap];

            CategoriesDataAccess.UpdateCategoryID(selectedCategory, categoryToSwap.ID);
            CategoriesDataAccess.UpdateCategoryID(categoryToSwap, selectedCategory.ID);

            PopulateForm();            //swap in list and datagridview instead

            //Set the selection back to the category the user had selected previously
            dataGridView.CurrentCell = dataGridView.Rows[rowToSwap].Cells[0];
        }
    }
}


//TODO ON MONDAY

//In the importdataform work out a solution to sorting the columns breaking the category updating, Apply this fix to the other forms with datagridviews.
//Add database file and table creation if the user does not already have a file to use, for both the transactions and categories.
