using System.Windows.Forms;

namespace BudgetApp.Models
{
    internal class DGVBuilder
    {
        internal static void CreateDataGridViewColumn(DataGridView dataGridView, string headerName, int size)
        {
            int columnId = dataGridView.Columns.Add(headerName + "Column", headerName);
            dataGridView.Columns[columnId].Width = size;
        }

    }
}
