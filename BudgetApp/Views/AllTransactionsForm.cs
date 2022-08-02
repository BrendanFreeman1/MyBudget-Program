using BudgetApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace BudgetApp.Views
{
    public partial class AllTransactionsForm : Form
    {
        private List<Transaction> transactionList = new List<Transaction>();
        ListSortDirection newColumnDirection = ListSortDirection.Ascending;

        public AllTransactionsForm()
        {
            InitializeComponent();
            PopulateForm();
        }

        void CreateDataGridViewColumns()
        {
            for (int i = 0; i <= 3; i++)
            {
                DataGridViewColumn column = new DataGridViewTextBoxColumn();
                dataGridView.Columns.Add(column);
            }

            dataGridView.Columns[0].Width = 70;
            dataGridView.Columns[0].HeaderText = "Date";
            dataGridView.Columns[1].Width = 740;
            dataGridView.Columns[1].HeaderText = "Description";
            dataGridView.Columns[2].Width = 70;
            dataGridView.Columns[2].HeaderText = "Value";
            dataGridView.Columns[3].Width = 135;
            dataGridView.Columns[3].HeaderText = "Category";
        }

        void PopulateForm()
        {
            transactionList.Clear();
            transactionList = SqliteDataAccess.LoadTransactions();
            CreateDataGridViewColumns();

            foreach(Transaction transaction in transactionList)
            {
                //Add the transaction to the DataGridView
                string[] currentRow = { transaction.Date.ToString("d"), transaction.Description, transaction.Value.ToString(), transaction.Category };
                dataGridView.Rows.Add(currentRow);
            }

            foreach (Category category in SqliteDataAccess.LoadCategories())
            {
                if (!categoryComboBox.Items.Contains(category.Name))
                {
                    categoryComboBox.Items.Add(category.Name);
                }
            }
        }

        void UpdateCategorybtn_Click(object sender, EventArgs e)
        {
            int row = dataGridView.CurrentCell.RowIndex;            

            transactionList[row - 1].Category = categoryComboBox.Text; //IndexOutOfRange on first entry in DataGridView
            dataGridView.CurrentRow.Cells[3].Value = transactionList[row - 1].Category;

            SqliteDataAccess.UpdateTransaction(transactionList[row - 1]);//only updating some entries in database
        }

        void Deletebtn_Click(object sender, EventArgs e)
        {
            int row = dataGridView.CurrentCell.RowIndex;
            Transaction transaction = transactionList[row];

            transactionList.Remove(transaction);
            dataGridView.Rows.RemoveAt(row);
            SqliteDataAccess.DeleteTransaction(transaction);
        }

        void dataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView.Columns[e.ColumnIndex].SortMode != DataGridViewColumnSortMode.NotSortable)
            {

                if (newColumnDirection == ListSortDirection.Ascending)
                    newColumnDirection = ListSortDirection.Descending;
                else
                    newColumnDirection = ListSortDirection.Ascending;

                switch (newColumnDirection)
                {
                    case ListSortDirection.Ascending:
                        dataGridView.Sort(dataGridView.Columns[e.ColumnIndex], ListSortDirection.Ascending);
                        break;
                    case ListSortDirection.Descending:
                        dataGridView.Sort(dataGridView.Columns[e.ColumnIndex], ListSortDirection.Descending);
                        break;
                }
            }
        }
    }
}
