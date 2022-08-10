using System.Collections.Generic;
using System.Windows.Forms;

namespace BudgetApp.Models
{
    internal class CategoryDGVBuilder: DGVBuilder
    {
        internal static void PopulateCategoryColumns(DataGridView dataGridView)
        {
            CreateDataGridViewColumn(dataGridView, "#", 40);
            CreateDataGridViewColumn(dataGridView, "Category", 100);
            CreateDataGridViewColumn(dataGridView, "Tag", 200);
        }

        internal static void PopulateCategoryRows(DataGridView dataGridView, List<Category> categoryList)
        {
            foreach(Category category in categoryList)
            {
                DataGridViewCategoryRow(dataGridView, category);
            }
        }

        internal static void DataGridViewCategoryRow( DataGridView dataGridView, Category category)
        {
            int rowId = dataGridView.Rows.Add();
            DataGridViewRow row = dataGridView.Rows[rowId];

            row.Cells[0].Value = category.ID;
            row.Cells[1].Value = category.Name;
            row.Cells[2].Value = category.Tag;
        }
    }
}
