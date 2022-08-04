using BudgetApp.Views;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BudgetApp.Models
{
    internal class FormBuilder
    {
        internal static void PopulateTransactionColumns(DataGridView dataGridView)
        {
            for (int i = 0; i < 4; i++)
            {
                DataGridViewColumn column = new DataGridViewTextBoxColumn();
                dataGridView.Columns.Add(column);
            }

            dataGridView.Columns[0].Width = 80;
            dataGridView.Columns[0].HeaderText = "Date";
            dataGridView.Columns[1].Width = 740;
            dataGridView.Columns[1].HeaderText = "Description";
            dataGridView.Columns[2].Width = 70;
            dataGridView.Columns[2].HeaderText = "Value";
            dataGridView.Columns[3].Width = 110;
            dataGridView.Columns[3].HeaderText = "Category";
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

        internal static void PopulateTransactionRows(DataGridView dataGridView, List<Transaction> transactionList)
        {
            for (int i = 0; i < transactionList.Count; i++)
            {
                PopulateTransactionRow(dataGridView, transactionList[i]);
            }
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
