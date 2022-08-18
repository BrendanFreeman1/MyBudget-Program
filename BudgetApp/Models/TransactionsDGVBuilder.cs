using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetApp.Models
{
    internal class TransactionsDGVBuilder : DGVBuilder
    {
        internal static void CreateTransactionColumns(DataGridView dataGridView)
        {
            CreateDataGridViewColumn(dataGridView, "", 0);
            CreateDataGridViewColumn(dataGridView, "Date", 75);
            CreateDataGridViewColumn(dataGridView, "Description", 740);
            CreateDataGridViewColumn(dataGridView, "Value", 70);
            CreateDataGridViewColumn(dataGridView, "Category", 110);

            dataGridView.Columns[0].Visible = false;
        }

        internal static void CreateTransactionRows(DataGridView dataGridView, List<Transaction> transactionsList)
        {
            dataGridView.Rows.Clear();

            for (int i = 0; i < transactionsList.Count; i++)
            {
                int rowId = dataGridView.Rows.Add();
                PopulateTransactionRow(dataGridView, transactionsList[i], rowId);
            }
        }

        internal static void PopulateTransactionRow(DataGridView dataGridView, Transaction transaction, int rowIndex)
        {
            DataGridViewRow row = dataGridView.Rows[rowIndex];

            row.Cells[0].Value = transaction.ID;
            row.Cells[1].Value = transaction.Date;
            row.Cells[2].Value = transaction.Description;
            row.Cells[3].Value = transaction.Value;
            row.Cells[4].Value = transaction.Category;
        }
    }
}
