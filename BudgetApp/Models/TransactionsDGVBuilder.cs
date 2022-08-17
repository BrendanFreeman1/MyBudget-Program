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
            CreateDataGridViewColumn(dataGridView, "Date", 75);
            CreateDataGridViewColumn(dataGridView, "Description", 740);
            CreateDataGridViewColumn(dataGridView, "Value", 70);
            CreateDataGridViewColumn(dataGridView, "Category", 110);
        }

        internal static void CreateTransactionRows(DataGridView dataGridView, List<Transaction> transactionList)
        {
            dataGridView.Rows.Clear();

            for (int i = 0; i < transactionList.Count; i++)
            {
                int rowId = dataGridView.Rows.Add();
                PopulateTransactionRow(dataGridView, transactionList[i], rowId);
            }
        }

        internal static void PopulateTransactionRow(DataGridView dataGridView, Transaction transaction, int rowIndex)
        {
            DataGridViewRow row = dataGridView.Rows[rowIndex];
            
            row.Cells[0].Value = transaction.Date;
            row.Cells[1].Value = transaction.Description;
            row.Cells[2].Value = transaction.Value;
            row.Cells[3].Value = transaction.Category;
        }
    }
}
