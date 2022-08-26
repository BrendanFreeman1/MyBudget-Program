using BudgetApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BudgetApp.Views
{
    public partial class AllTransactionsForm : Form
    {
        private List<Transaction> transactionsList = new List<Transaction>();

        public AllTransactionsForm()
        {
            InitializeComponent();
            PopulateForm();
        }

        private void PopulateForm()
        {
            transactionsList.Clear();
            dataGridView.Columns.Clear();
            dataGridView.Rows.Clear();
            ComboBoxBuilder.PopulateComboBox(categoryComboBox);
            TransactionsDGVBuilder.CreateTransactionColumns(dataGridView);
            
            transactionsList = TransactionsDataAccess.LoadAllTransactions();
            if(transactionsList.Count > 0)
            {
                SetDateTimePickers();
                PopulateDataGridViewRows();
            }
        }

        private void PopulateDataGridViewRows()
        {
            List<Transaction> FromToTransactions = new List<Transaction>();
            DateTime start = FromDateTimePicker.Value + new TimeSpan(00, 00, 00);
            DateTime end = ToDateTimePicker.Value + new TimeSpan(23, 59, 59);

            foreach (Transaction transaction in transactionsList)
            {
                if(transaction.Date >= start && transaction.Date <= end) { FromToTransactions.Add(transaction); }
            }

            TransactionsDGVBuilder.CreateTransactionRows(dataGridView, FromToTransactions);
        }

        private void SetDateTimePickers()
        {
            transactionsList.Sort((i, j) => DateTime.Compare(i.Date, j.Date));

            FromDateTimePicker.Value = transactionsList.First().Date;
            ToDateTimePicker.Value = transactionsList.Last().Date;

        }

        private void UpdateCategorybtn_Click(object sender, EventArgs e)
        {
            Transaction.UpdateTransactionCategory(dataGridView, transactionsList, categoryComboBox.Text, true);
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if(dataGridView.CurrentRow != null)
            {
                int row = dataGridView.CurrentRow.Index;
                Transaction transaction = transactionsList[row];

                transactionsList.Remove(transaction);
                dataGridView.Rows.RemoveAt(row);
                TransactionsDataAccess.DeleteTransaction(transaction);
            }
        }
        private void CustomCategoryBtn_Click(object sender, EventArgs e)
        {
            CustomCategoryForm customCategoryForm = new CustomCategoryForm();
            customCategoryForm.FormClosed += new FormClosedEventHandler(UpdateTransactionsCategories);
            customCategoryForm.Show();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FromDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            PopulateDataGridViewRows();
        }

        private void ToDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            PopulateDataGridViewRows();
        }

        private void UpdateTransactionsCategories(object sender, FormClosedEventArgs e)
        {
            //Reload ComboBox with the newly added category
            ComboBoxBuilder.PopulateComboBox(categoryComboBox);
            Category theNewCategory = CategoriesDataAccess.LoadAllCategories().Last();

            Transaction.UpdateEachTransactionsCategory(transactionsList, theNewCategory, true);

            dataGridView.Rows.Clear();
            TransactionsDGVBuilder.CreateTransactionRows(dataGridView, transactionsList);
        }
    }
}
