using BudgetApp.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace BudgetApp.Views
{
    /// <summary>
    /// Takes data from thhe selected excel form as seperate 'Transaction' objects
    /// Allows the user to categorise each transaction, saves them to a list, Saves the finished list to the users database
    /// </summary>
    public partial class ImportDataForm : Form
    {
        #region Initialise variables
        private readonly List<Transaction> transactionList = new List<Transaction>();
        private int listIndex = 0;

        //Create excel objects
        Excel.Application xlApp;
        Excel.Workbook xlWorkBook;
        Excel.Worksheet xlWorkSheet;

        #endregion

        public ImportDataForm()
        {
            InitializeComponent();
            PopulateComoboBox();
        }

        private void PopulateComoboBox()
        {
            List<Category> categories = SqliteDataAccess.LoadCategories();


            //Remove duplicates
            foreach (Category category in categories)
            {
                categoryComboBox.Items.Add(category.CategoryName);
            }
        }

        public void ReadExcel(string sFile)
        {
            //Called once an excel file is chosen from the BudgetAppForm
            //Gets data from the selected excel, creates transaction objects and puts them into the transactionList       

            int row = 2; //Start from second row
            xlApp = new Excel.Application(); //Excel app object
            xlWorkBook = xlApp.Workbooks.Open(sFile); //Workbook to open the excel file
            xlWorkSheet = xlWorkBook.ActiveSheet; //Gets the excels active sheet   

            //While there are still rows in the excel with data
            while (xlWorkSheet.Cells[row, 1].value != null)
            {
                transactionList.Add(GetTransactionData(row));

                row++;
            }

            CreateDataGridViewColumns();

            CleanUpExcelObjects();
        }

        void CreateDataGridViewColumns()
        {           
            for (int i = 0; i <= 3; i++)
            {                
                DataGridViewColumn column = new DataGridViewTextBoxColumn();                
                dataGridView.Columns.Add(column);
            }

            //Populate first row with column headers
            dataGridView.Rows.Add("Date", "Description", "Value", "Category");

            //Display the first row from the excel for the user to view and select a category for
            DisplayNextRowLabels();


            //DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
            //dataGridView.Columns.Add(comboBoxColumn);
        }

        #region Populate Transaction Objects        
        Transaction GetTransactionData(int row)
        {
            Transaction transaction = new Transaction();

            //DATE
            //Excel is feeding some of the dates as DateTime objects(day of month > 12) and some as strings(day of month <= 12).
            var currentDate = xlWorkSheet.Cells[row, 1].value;
            if (currentDate is string)
            {
                transaction.Date = DateTime.Parse(currentDate);
            }
            else
            {
                //The DateTime object being fed in is being saved in MM/dd/yyyy format.
                //To correct that to dd/MM/yyyy i'm converting it to a string, then back to a DateTime object.
                transaction.Date = DateTime.Parse(currentDate.ToString("MM/dd/yyyy"));
            }

            //DESCRIPTION
            transaction.Description = xlWorkSheet.Cells[row, 2].value;

            //VALUE
            if (xlWorkSheet.Cells[row, 3].value != null) { transaction.Value = xlWorkSheet.Cells[row, 3].value; } //Credit
            else { transaction.Value = xlWorkSheet.Cells[row, 4].value; } //Debit

            //CATEGORY
            transaction.Category = transaction.AutoCategorise(transaction);

            return transaction;
        }
        #endregion        
        
        #region Set Current Transactions Category
        void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (listIndex < transactionList.Count)
            {
                string[] currentRow = { transactionList[listIndex].Date.ToString(), transactionList[listIndex].Description, transactionList[listIndex].Value.ToString(), transactionList[listIndex].Category };
                dataGridView.Rows.Add(currentRow);

                listIndex++;

                DisplayNextRowLabels();
            }
        }

        void DisplayNextRowLabels()
        {
            if (listIndex < transactionList.Count)
            {
                dateLabel.Text = transactionList[listIndex].Date.ToString();
                descriptionLabel.Text = transactionList[listIndex].Description;
                valueLabel.Text = transactionList[listIndex].Value.ToString();
                categoryComboBox.Text = transactionList[listIndex].Category;
            }
        }
        #endregion

        void FinishButton_Click(object sender, EventArgs e)
        {
            foreach (Transaction transaction in transactionList)
            {
                SqliteDataAccess.SaveTransaction(transaction);
            }

            Close();
        }

        void CleanUpExcelObjects()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();

            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkSheet);

            xlWorkBook.Close();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkBook);

            xlApp.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp);
        }
    }
}
