using BudgetApp.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BudgetApp.Views
{
    public partial class AllTransactionsForm : Form
    {
        private List<Transaction> transactionList = new List<Transaction>();

        public AllTransactionsForm()
        {
            InitializeComponent();
            PopulateForm();
        }

        void PopulateForm()
        {
            transactionList.Clear();
            transactionList = SqliteDataAccess.LoadTransactions();

            FormBuilder.PopulateTransactionColumns(dataGridView);

            FormBuilder.PopulateTransactionRows(dataGridView, transactionList);          

            FormBuilder.PopulateComboBox(categoryComboBox);
        }

        void UpdateCategorybtn_Click(object sender, EventArgs e)
        {
            int row = dataGridView.CurrentCell.RowIndex;

            transactionList[row].Category = categoryComboBox.Text; 
            dataGridView.CurrentRow.Cells[3].Value = transactionList[row].Category;

            SqliteDataAccess.UpdateTransaction(transactionList[row]);
        }

        void Deletebtn_Click(object sender, EventArgs e)
        {
            int row = dataGridView.CurrentCell.RowIndex;
            Transaction transaction = transactionList[row];

            transactionList.Remove(transaction);
            dataGridView.Rows.RemoveAt(row);
            SqliteDataAccess.DeleteTransaction(transaction);
        }
    }
}
