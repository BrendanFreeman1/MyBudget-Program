using BudgetApp.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BudgetApp.Views
{
    public partial class AllTransactionsForm : Form
    {
        List<Transaction> transactionList = new List<Transaction>();

        public AllTransactionsForm()
        {
            InitializeComponent();
            PopulateForm();
        }

        private void PopulateForm()
        {
            transactionList.Clear();
            dataGridView.Columns.Clear();
            dataGridView.Rows.Clear();

            transactionList = TransactionsDataAccess.LoadTransactions();
            TransactionsDGVBuilder.PopulateTransactionColumns(dataGridView);
            TransactionsDGVBuilder.PopulateTransactionRows(dataGridView, transactionList);
            ComboBoxBuilder.PopulateComboBox(categoryComboBox);
        }

        private void UpdateCategorybtn_Click(object sender, EventArgs e)
        {
            int row = dataGridView.CurrentRow.Index;

            transactionList[row].Category = categoryComboBox.Text; 
            dataGridView.CurrentRow.Cells[3].Value = transactionList[row].Category;
            TransactionsDataAccess.UpdateTransactionCategory(transactionList[row]);

            //Set the selection back to the category the user had selected previously
            dataGridView.CurrentCell = dataGridView.Rows[row].Cells[0];
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            int row = dataGridView.CurrentRow.Index;
            Transaction transaction = transactionList[row];

            transactionList.Remove(transaction);
            dataGridView.Rows.RemoveAt(row);
            TransactionsDataAccess.DeleteTransaction(transaction);
        }
    }
}
