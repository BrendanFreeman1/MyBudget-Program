using BudgetApp.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace BudgetApp.Views
{
    /// <summary>
    /// Takes data from the selected excel form as seperate 'Transaction' objects
    /// Allows the user to categorise each transaction, saves them to a list, Saves the finished list to the users database
    /// </summary>
    internal partial class ImportDataForm : Form
    {
        #region Initialise variables
        private static readonly List<Transaction> transactionList = new List<Transaction>();

        private static Excel.Application xlApp;
        private static Excel.Workbook xlWorkBook;
        private static Excel.Worksheet xlWorkSheet;
        #endregion

        public ImportDataForm()
        {
            InitializeComponent();
            PopulateForm();            
        }

        private void PopulateForm()
        {
            transactionList.Clear();
            ComboBoxBuilder.PopulateComboBox(categoryComboBox);
            TransactionsDGVBuilder.PopulateTransactionColumns(dataGridView);

            OpenFile();
            TransactionsDGVBuilder.PopulateTransactionRows(dataGridView, transactionList);
        }

        private void OpenFile()
        {
            //Set the file name to an empty string to begin with
            openFileDialog.FileName = "";
            //Restrict the file types we can attempt to open
            openFileDialog.Filter = "Excel File|*.xlsx;*.xls;*.csv";

            //If the user has selected a file and pressed 'Open' and not 'Cancel'
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //If the file name has now been updated from empty to something
                if (openFileDialog.FileName.Trim() != "")
                {
                    ImportData(openFileDialog.FileName);
                }
            }
        }

        private void ImportData(string sFile)
        {           
            xlApp = new Excel.Application(); 
            xlWorkBook = xlApp.Workbooks.Open(sFile);
            xlWorkSheet = xlWorkBook.ActiveSheet;
            int row = 2; //Start from second row

            try
            {
                //While there are still rows in the excel with data
                while (xlWorkSheet.Cells[row, 1].value != null)
                {
                    transactionList.Add(Transaction.GetTransactionDataFromExcel(row, xlWorkSheet));

                    row++;
                }

            }
            catch //Not an acceptable way to handle exceptions, think of a better way!!!!?!?!!?!?!!!
            {
                MessageBox.Show("Please select a file with the correct format", "Incorrect CSV Format", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }

            CleanUpExcelObjects();
        }

        private void CleanUpExcelObjects()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();

            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkSheet);

            xlWorkBook.Close();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkBook);

            xlApp.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp);
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null) { return; }

            int row = dataGridView.CurrentRow.Index;

            transactionList[row].Category = categoryComboBox.Text;
            TransactionsDGVBuilder.PopulateRow(dataGridView, transactionList[row], row);
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            ErrorForm errorForm = new ErrorForm();

            errorForm.ErrorMessage("This will save all transactions not categorised 'Ignore' to your database\n\nAre you sure?");            
            errorForm.Show();

            errorForm.ConfirmBtn.Click += delegate (Object obj, EventArgs ev)
            {
                foreach (Transaction transaction in transactionList)
                {
                    if (transaction.Category != "Ignore")
                    {
                        TransactionsDataAccess.SaveTransaction(transaction);
                    }
                }

                Close();

                BudgetApp.ReloadForm();
                errorForm.Close();
            };            
        }

        private void ViewAllCategoriesBtn_Click(object sender, EventArgs e)
        {
            AllCategoriesForm allCategoriesForm = new AllCategoriesForm();
            allCategoriesForm.FormClosed += new FormClosedEventHandler(UpdateTransactionsCategories);
            allCategoriesForm.Show();
        }

        private void CustomCategoryBtn_Click(object sender, EventArgs e)
        {
            CustomCategoryForm customCategoryForm = new CustomCategoryForm();
            customCategoryForm.FormClosed += new FormClosedEventHandler(UpdateTransactionsCategories);
            customCategoryForm.Show();
        }

        private void UpdateTransactionsCategories(object sender, FormClosedEventArgs e)
        {
            //Reload our ComboBox with the newly added category
            ComboBoxBuilder.PopulateComboBox(categoryComboBox);

            //We only want to update items in the list that match the newly created category
            List<Category> categoriesList = CategoriesDataAccess.LoadCategories();
            Category newCategory = categoriesList[categoriesList.Count - 1]; //Get the newly created category

            for (int i = 0; i < transactionList.Count; i++)
            {
                //Only proceed if the autocategorisation matches the new category
                if (Transaction.AutoCategorise(transactionList[i]) == newCategory.Name)
                {
                    transactionList[i].Category = Transaction.AutoCategorise(transactionList[i]);
                    TransactionsDGVBuilder.PopulateRow(dataGridView, transactionList[i], i);
                }
            }
        }
    }
}