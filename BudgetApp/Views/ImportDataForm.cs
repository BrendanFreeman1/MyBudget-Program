using BudgetApp.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace BudgetApp
{
    /// <summary>
    /// Takes data from selected excel form as seperate 'Transaction' objects
    /// Allows the user to categorise each transaction in the imported data
    /// Saves each Transaction to a list
    /// Saves the finished list to the users database
    /// </summary>
    public partial class ImportDataForm : Form
    {
        #region Initialise variables

        //List to hold the imported transactions
        private readonly List<Transaction> transactionList = new List<Transaction>();
        //Index to track where through the transactionList we are currently
        private int listIndex = 0;

        //Create excel objects
        Excel.Application xlApp;
        Excel.Workbook xlWorkBook;
        Excel.Worksheet xlWorkSheet;

        #endregion

        public ImportDataForm()
        {
            InitializeComponent();

            //Set the data source of the combo box
            categoryComboBox.DataSource = Enum.GetValues(typeof(Category));
        }

        ///<summary>
        ///This method is called once an excel file is chosen from the BudgetAppForm
        ///Gets the data from the selected excel, creates transaction objects and puts them into the list       
        ///</summary>
        public void ReadExcel(string sFile)
        {
            int row = 2; //Start from second row
            xlApp = new Excel.Application(); //Create new excel app object
            xlWorkBook = xlApp.Workbooks.Open(sFile); //Workbook to open the excel file
            xlWorkSheet = xlWorkBook.ActiveSheet; //Gets the excels active sheet   

            //While there are still rows in the excel with data
            while (xlWorkSheet.Cells[row, 1].value != null)
            {
                //Get the data from the excel, create a transaction object and add it to our transactionList
                transactionList.Add(GetTransactionData(row));

                //Move to the next row in the excel
                row++;
            }

            //Create the needed columns in our DataGridView
            CreateDataGridViewColumns();

            //Close excel objects and garbage collect
            CleanUpExcelObjects();
        }

        void CreateDataGridViewColumns()
        {
            ///Adds columns and their headers to the DataGridView

            //Add four columns
            for (int i = 0; i <= 3; i++)
            {
                //Create new column object
                DataGridViewColumn column = new DataGridViewTextBoxColumn();

                //Add the new column
                dataGridView.Columns.Add(column);
            }

            //Populate first row with column headers
            dataGridView.Rows.Add("Date", "Description", "Value", "Category");

            //Display the first row from the excel for the user to view and select a category for
            DisplayNextRowLabels();

            //Add Combobox column
            //DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
            //comboBoxColumn.DataSource = Enum.GetValues(typeof(Category)); // set the source of the combobox coloumn to be the Category Object
            //dataGridView.Columns.Add(comboBoxColumn);
        }

        #region Populate Transaction Objects
        
        Transaction GetTransactionData(int row)
        {
            ///Get the transaction data from the excel sheet and put it into Transaction objects

            //Create a new Transaction object
            Transaction transaction = new Transaction();

            //Date
            //Excel is feeding some of the dates as DateTime objects(day of month > 12) and some as strings(day of month <= 12).
            var currentDate = xlWorkSheet.Cells[row, 1].value;

            if (currentDate is string)
            {
                //Convert the string to a Date time
                transaction.Date = DateTime.Parse(currentDate);
            }
            else
            {
                //The DateTime object being fed in is in MM/dd/yyyy format.
                //To correct that to dd/MM/yyyy i'm converting it to a string, then back to a DateTime object.
                transaction.Date = DateTime.Parse(currentDate.ToString("MM/dd/yyyy"));
            }

            //DESCRIPTION
            transaction.Description = xlWorkSheet.Cells[row, 2].value;          

            //Credit or debit
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
        #endregion

        #region Set Current Transactions Category

        void ConfirmButton_Click(object sender, EventArgs e)
        {
            ///This method is called when the user clicks the 'Confirm' button

            //If the index for tracking where we are in the list is less than the legth of the list
            if (listIndex < transactionList.Count)
            {
                //Save current selected Category to the category field of the current transaction object
                transactionList[listIndex].Category = (Category)categoryComboBox.SelectedValue;             

                //Populate a string array with each of the current Transaction objects fields
                string[] currentRow = { transactionList[listIndex].Date.ToString(), transactionList[listIndex].Description, transactionList[listIndex].Value.ToString(), transactionList[listIndex].Category.ToString() };
                //Add it as the next row to our DataGridView
                dataGridView.Rows.Add(currentRow);

                listIndex++;
                //Display the next row from the excel for the user to view and select a category for
                DisplayNextRowLabels();
            }
        }

        void DisplayNextRowLabels()
        {
            ///Populate the labels in the form with the current Transaction objects information
            if (listIndex < transactionList.Count)
            {
                dateLabel.Text = transactionList[listIndex].Date.ToString();
                descriptionLabel.Text = transactionList[listIndex].Description;
                valueLabel.Text = transactionList[listIndex].Value.ToString();
            }
        }
        #endregion

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

        void FinishButton_Click(object sender, EventArgs e)
        {            
            foreach (Transaction transaction in transactionList)
            {
                SqliteDataAccess.SaveTransaction(transaction);
            }

            this.Close();
        }

        
    }
}
