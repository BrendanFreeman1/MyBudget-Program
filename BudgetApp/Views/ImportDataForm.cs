using BudgetApp.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace BudgetApp.Views
{
    internal partial class ImportDataForm : Form
    {
        #region Initialise variables
        private static readonly List<Transaction> transactionsList = new List<Transaction>();

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
            transactionsList.Clear();
            ComboBoxBuilder.PopulateComboBox(categoryComboBox);
            TransactionsDGVBuilder.CreateTransactionColumns(dataGridView);

            OpenFile();
            TransactionsDGVBuilder.CreateTransactionRows(dataGridView, transactionsList);
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
            else 
            { 
                Close(); 
            }
        }

        private void ImportData(string sFile)
        {           
            xlApp = new Excel.Application(); 
            xlWorkBook = xlApp.Workbooks.Open(sFile);
            xlWorkSheet = xlWorkBook.ActiveSheet;
            int row = 2; //Start from second row

            ErrorForm errorForm = new ErrorForm();
            errorForm.ErrorMessage("Loading...");
            errorForm.CancelBtn.Visible = false;
            errorForm.ConfirmBtn.Visible = false;
            errorForm.Show();

            try
            {
                //While there are still rows in the excel with data
                while (xlWorkSheet.Cells[row, 1].value != null)
                {
                    transactionsList.Add(Transaction.GetTransactionDataFromExcel(row, xlWorkSheet));

                    row++;
                }
            }
            catch //Not an acceptable way to handle exceptions, think of a better way!!!!?!?!!?!?!!!
            {
                MessageBox.Show("Please select a file with the correct format", "Incorrect CSV Format", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }

            errorForm.Close();
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

        private void UpdateCategorybtn_Click(object sender, EventArgs e)
        {
            //Not working
            Transaction.UpdateTransactionCategory(dataGridView, transactionsList, categoryComboBox.Text, false);
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            ErrorForm errorForm = new ErrorForm();

            errorForm.ErrorMessage("This will save all transactions not categorised 'Ignore' to your database\nAre you sure?");            
            errorForm.Show();

            errorForm.ConfirmBtn.Click += delegate (Object obj, EventArgs ev)
            {
                foreach (Transaction transaction in transactionsList)
                {
                    if (transaction.Category != "Ignore")
                    {
                        TransactionsDataAccess.SaveTransaction(transaction);
                    }
                }

                Close();

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
            //Reload ComboBox with the newly added category
            ComboBoxBuilder.PopulateComboBox(categoryComboBox);
            Category theNewCategory = CategoriesDataAccess.LoadAllCategories().Last();

            Transaction.UpdateEachTransactionsCategory(transactionsList, theNewCategory, false);

            dataGridView.Rows.Clear();
            TransactionsDGVBuilder.CreateTransactionRows(dataGridView, transactionsList);
        }
    }
}