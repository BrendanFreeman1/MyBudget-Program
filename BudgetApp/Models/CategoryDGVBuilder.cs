using System.Collections.Generic;
using System.Windows.Forms;

namespace BudgetApp.Models
{
    internal class CategoryDGVBuilder: DGVBuilder
    {
        internal static void CreateCategoryColumns(DataGridView dataGridView)
        {
            CreateDataGridViewColumn(dataGridView, "", 0);
            CreateDataGridViewColumn(dataGridView, "Category", 100);
            CreateDataGridViewColumn(dataGridView, "Tag", 240);

            dataGridView.Columns[0].Visible = false;
        }

        internal static void CreateCategoryRows(DataGridView dataGridView, List<Category> categoriesList)
        {
            foreach(Category category in categoriesList)
            {
                int rowIndex = dataGridView.Rows.Add();               
                PopulateCategoryRow(dataGridView, category, rowIndex);
            }
        }

        internal static void PopulateCategoryRow(DataGridView dataGridView, Category category, int rowIndex)
        {
            DataGridViewRow row = dataGridView.Rows[rowIndex];
            row.Cells[0].Value = category.ID;
            row.Cells[1].Value = category.Name;
            row.Cells[2].Value = category.Tag;
        }
    }
}
