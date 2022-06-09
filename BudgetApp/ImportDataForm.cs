using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace BudgetApp
{
    /// <summary>
    /// Takes data from selected form as seperate 'Transaction' objects
    /// Allows the user to categorise each transaction in the imported data
    /// Saves each Transaction to a list
    /// Saves the finished list to the users database
    /// </summary>
    public partial class ImportDataForm : Form
    {
        //List to hold the imported transactions
        private readonly List<Transaction> transactionList = new List<Transaction>();
        private readonly Transaction transaction = null;

        //Create excel objects
        Excel.Application xlApp;
        Excel.Workbook xlWorkBook;
        Excel.Worksheet xlWorkSheet;

        public ImportDataForm()
        {
            InitializeComponent();

            comboBox.DataSource = Enum.GetValues(typeof(Category));
        }

        //Gets the data from the selected excel and populates the dataGridView
        public void ReadExcel(string sFile)
        {
            xlApp = new Excel.Application();//Create new excel app object
            xlWorkBook = xlApp.Workbooks.Open(sFile);//Workbook to open the excel file
            xlWorkSheet = xlWorkBook.ActiveSheet; //Gets the excels active sheet

            //Variable to save the row we're up to, indexing starts at 1
            int row = 2; //Start from second row

            PopulateColumns();

            //While there are still rows in the excel with data
            while (xlWorkSheet.Cells[row, 1].value != null)
            {
                transactionList.Add(GetTransactionData(row));

                row++;
            }


            CleanUpExcelObjects();
        }


        //Adds columns and their headers to the DataGridView
        void PopulateColumns()
        {            
            for(int i=0; i<3; i++)           
            {
                //Create new column object
                DataGridViewColumn column = new DataGridViewTextBoxColumn();

                //Add the new column
                dataGridView.Columns.Add(column);
            }
        } 

        Transaction GetTransactionData(int row)
        {
            //DATE
            transaction.Date = Convert.ToString(xlWorkSheet.Cells[row, 1].value);

            //DESCRIPTION
            transaction.Description = xlWorkSheet.Cells[row, 2].value;          

            //CREDIT OR DEBIT
            if (xlWorkSheet.Cells[row, 3].value != null)
            {
                transaction.Value = xlWorkSheet.Cells[row, 3].value;
            }
            else
            {
                transaction.Value = xlWorkSheet.Cells[row, 4].value;
            }

            //POPULATE THE TRANSACTIONSLIST FIRST, THEN PROMPT THE USER TO CATEGORISE EACH TRANSACTION AFTER THAT

            string[] currentRow = { transaction.Date, transaction.Description, transaction.Value.ToString() };

            dataGridView.Rows.Clear();

            dataGridView.Rows.Add(currentRow);

            return transaction;

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

        private void ConfirmCategoryBtn_Click(object sender, EventArgs e)
        {
            transaction.Category = (Category)comboBox.SelectedValue;

        }
    }
}
