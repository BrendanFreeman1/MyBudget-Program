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
        internal static void PopulateTransactionColumns(DataGridView dataGridView)
        {
            CreateDataGridViewColumn(dataGridView, "Date", 75);
            CreateDataGridViewColumn(dataGridView, "Description", 740);
            CreateDataGridViewColumn(dataGridView, "Value", 70);
            CreateDataGridViewColumn(dataGridView, "Category", 110);
        }

        internal static void PopulateTransactionRows(DataGridView dataGridView, List<Transaction> transactionList)
        {
            for (int i = 0; i < transactionList.Count; i++)
            {
                DataGridViewTransactionRow(dataGridView, transactionList[i]);
            }
        }

        internal static void DataGridViewTransactionRow(DataGridView dataGridView, Transaction transaction)
        {
            int rowId = dataGridView.Rows.Add();
            DataGridViewRow row = dataGridView.Rows[rowId];

            row.Cells[0].Value = transaction.Date;
            row.Cells[1].Value = transaction.Description;
            row.Cells[2].Value = transaction.Value;
            row.Cells[3].Value = transaction.Category;
        }
    }
}
