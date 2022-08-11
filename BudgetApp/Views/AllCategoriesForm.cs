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
            PopulateForm();
        }

        private void CreateCategorybtn_Click(object sender, EventArgs e)
        {
            CustomCategoryForm customCategoryForm = new CustomCategoryForm();
            customCategoryForm.FormClosed += new FormClosedEventHandler(Child_FormClosed);
            customCategoryForm.Show();
        }

        private void Child_FormClosed(object sender, FormClosedEventArgs e)
        {
            PopulateForm();
        }

        private void UpBtn_Click(object sender, EventArgs e)
        {
            int row = dataGridView.CurrentRow.Index;

            //Only proceed if we're not at the first item in the list
            if(row > 0) { MoveSelected(row, row-1); }
        }

        private void DownBtn_Click(object sender, EventArgs e)
        {
            int row = dataGridView.CurrentRow.Index;

            //Only proceed if we're not at the last item in the list
            if (row < categoriesList.Count-1) MoveSelected(row, row+1);
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MoveSelected(int row, int rowToSwap)
        {
            const int TEMP_ID = -1;
            Category selectedCategory = categoriesList[row];
            Category categoryToSwap = categoriesList[rowToSwap];

            //ID must be unique so we temporarily set the selected categories ID to a number that will always be unique
            CategoriesDataAccess.UpdateCategoryID(selectedCategory, TEMP_ID);
            //Change the ID in our local object as well so the database is looking in the right place when we pass it again
            selectedCategory.ID = TEMP_ID;
            //Move the category to swap into the selected categories place now that it is vacant
            CategoriesDataAccess.UpdateCategoryID(categoryToSwap, row);
            //Move the selected category from its temp place into the place of the category its swapping with
            CategoriesDataAccess.UpdateCategoryID(selectedCategory, rowToSwap);

            PopulateForm();

            //Set the selection back to the category the user had selected previously
            dataGridView.CurrentCell = dataGridView.Rows[rowToSwap].Cells[0];
        }


    }
}
