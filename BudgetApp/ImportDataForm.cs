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

        //Create excel objects
        Excel.Application xlApp;
        Excel.Workbook xlWorkBook;
        Excel.Worksheet xlWorkSheet;

        public ImportDataForm()
        {
            InitializeComponent();
        }

        //Gets the data from the selected excel and populates the dataGridView
        public void ReadExcel(string sFile)
        {
            xlApp = new Excel.Application();//Create new excel app object
            xlWorkBook = xlApp.Workbooks.Open(sFile);//Workbook to open the excel file
            xlWorkSheet = xlWorkBook.ActiveSheet; //Gets the excels active sheet

            //Variable to save the row we're up to, indexing starts at 1
            int row = 2; //Start from second row

            CreateColumns();

            //While there are still rows in the excel with data
            while (xlWorkSheet.Cells[row, 1].value != null)
            {
                //Get the data from the excel and add it to our transactionList
                transactionList.Add(GetTransactionData(row));

                row++;
            }

            PopulateDataGridView();

            CleanUpExcelObjects();
        }


        //Adds columns and their headers to the DataGridView
        void CreateColumns()
        {
            //Add first four columns
            for (int i = 0; i <= 3; i++)
            {
                //Create new column object
                DataGridViewColumn column = new DataGridViewTextBoxColumn();

                //Add the new column
                dataGridView.Columns.Add(column);
            }

            //Add Combobox column
            DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
            comboBoxColumn.DataSource = Enum.GetValues(typeof(Category));
            dataGridView.Columns.Add(comboBoxColumn);

            //NEED TO TRY BINDING DATA IN THE ROWS SO THAT WHEN INFORMATION IS UPDATED, IT UPDATES IT IN ITS CORRESPONDING TRANSACTION OBJECT

        } 

        //Get the transaction data from the excel sheet and put it into Transaction objects
        Transaction GetTransactionData(int row)
        {
            //Create a new Transaction object
            Transaction transaction = new Transaction();

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

            return transaction;
        }

        void PopulateDataGridView()
        {
            foreach (Transaction transaction in transactionList)
            {
                string[] currentRow = { transaction.ID.ToString(), transaction.Date, transaction.Description, transaction.Value.ToString(), transaction.Category.ToString() };

                dataGridView.Rows.Add(currentRow);
            }
        }

        private void ConfirmCategoryBtn_Click(object sender, EventArgs e)
        {
            //User sets the category value for each transaction, when they press okay this method is fired
            //Loop through the transactions list and using the index in the table, set the transaction.Category to the value selected in the combobox. 
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

        private void DataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //Prevent System.ArgumentException: DataGridViewComboBoxCell value is not valid
            e.Cancel = true;
        }
    }
}
