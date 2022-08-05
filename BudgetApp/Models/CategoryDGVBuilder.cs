using System.Collections.Generic;
using System.Windows.Forms;

namespace BudgetApp.Models
{
    internal class CategoryDGVBuilder: DGVBuilder
    {
        internal static void PopulateCategoryColumns(DataGridView dataGridView)
        {
            CreateDataGridViewColumn(dataGridView, "Category", 100);
            CreateDataGridViewColumn(dataGridView, "Tag", 200);
        }

        internal static void PopulateCategoryRows(DataGridView dataGridView, List<Category> categgoryList)
        {
            for (int i = 0; i < categgoryList.Count; i++)
            {
                DataGridViewCategoryRow(dataGridView, categgoryList[i]);
            }
        }

        internal static void DataGridViewCategoryRow(DataGridView dataGridView, Category category)
        {
            int rowId = dataGridView.Rows.Add();
            DataGridViewRow row = dataGridView.Rows[rowId];

            row.Cells[0].Value = category.Name;
            row.Cells[1].Value = category.Tag;
        }
    }
}
