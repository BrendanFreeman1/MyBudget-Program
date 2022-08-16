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

        private void PopulateForm()
        {
            transactionList.Clear();
            dataGridView.Columns.Clear();
            dataGridView.Rows.Clear();

            transactionList = TransactionsDataAccess.LoadAllTransactions();
            TransactionsDGVBuilder.CreateTransactionColumns(dataGridView);
            TransactionsDGVBuilder.CreateTransactionRows(dataGridView, transactionList);
            ComboBoxBuilder.PopulateComboBox(categoryComboBox);
        }

        private void UpdateCategorybtn_Click(object sender, EventArgs e)
        {
            Transaction.UpdateTransactionCategory(dataGridView, transactionList, categoryComboBox.Text, true);
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            int row = dataGridView.CurrentRow.Index;
            Transaction transaction = transactionList[row];

            transactionList.Remove(transaction);
            dataGridView.Rows.RemoveAt(row);
            TransactionsDataAccess.DeleteTransaction(transaction);
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
