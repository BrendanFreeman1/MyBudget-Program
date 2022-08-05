using BudgetApp.Views;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BudgetApp.Models
{
    internal class FormBuilder
    {
        internal static void PopulateTransactionColumns(DataGridView dataGridView)
        {
            CreateDataGridViewColumn(dataGridView, "Date", 75);
            CreateDataGridViewColumn(dataGridView, "Description", 740);
            CreateDataGridViewColumn(dataGridView, "Value", 70);
            CreateDataGridViewColumn(dataGridView, "Category", 110);
        }

        internal static void PopulateCategoryColumns(DataGridView dataGridView)
        {
            CreateDataGridViewColumn(dataGridView, "Category", 200);
            CreateDataGridViewColumn(dataGridView, "Tag", 200);
        }

        static void CreateDataGridViewColumn(DataGridView dataGridView, string headerName, int size)
        {
            int columnId = dataGridView.Columns.Add(headerName + "Column", headerName);            
            dataGridView.Columns[columnId].Width = size;
        }

        internal static void PopulateTransactionRows(DataGridView dataGridView, List<Transaction> transactionList)
        {
            for (int i = 0; i < transactionList.Count; i++)
            {
                PopulateTransactionRow(dataGridView, transactionList[i]);
            }
        }

        internal static void PopulateTransactionRow(DataGridView dataGridView, Transaction transaction)
        {
            int rowId = dataGridView.Rows.Add();

            DataGridViewRow row = dataGridView.Rows[rowId];

            row.Cells[0].Value = transaction.Date;
            row.Cells[1].Value = transaction.Description;
            row.Cells[2].Value = transaction.Value;
            row.Cells[3].Value = transaction.Category;

        }



        internal static void PopulateComboBox(ComboBox comoboBox)
        {
            foreach (Category category in SqliteDataAccess.LoadCategories())
            {
                if (!comoboBox.Items.Contains(category.Name))
                {
                    comoboBox.Items.Add(category.Name);
                }
            }
        }
    }
}
