using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Excel = Microsoft.Office.Interop.Excel;

namespace BudgetApp
{
    public partial class BudgetApp : Form
    {
        private readonly List<Transaction> transactions = new List<Transaction>();

        //Create excel objects
        Excel.Application xlApp;
        Excel.Workbook xlWorkBook;
        Excel.Worksheet xlWorkSheet;        

        public BudgetApp()
        {
            InitializeComponent();
        }

        //Called when the 'Import Excel File" button is clicked
        void Importbtn_Click(object sender, EventArgs e)
        {
            //Set the file name to null to begin with
            openFileDialog.FileName = "";
            //Restrict the file types we can attempt to open
            openFileDialog.Filter = "Excel File|*.xlsx;*.xls;*.csv";

            //If the openFileDialog works, continue
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //If the file name has been updated from null to something, run the readExcel method on that file
                if (openFileDialog.FileName.Trim() != "")
                {
                    ReadExcel(openFileDialog.FileName);
                }
            }
        }

        //Gets the data from the selected excel and populates the dataGridView
        void ReadExcel(string sFile)
        {
            xlApp = new Excel.Application();//Create new excel app object
            xlWorkBook = xlApp.Workbooks.Open(sFile);//Workbook to open the excel file
            xlWorkSheet = xlWorkBook.ActiveSheet; //Gets the excels active sheet

            //Saves the row and column we're up to, indexing starts at 1
            int col = 1;
            int row = 2; //Start from second row

            PopulateHeaders(col);

            //While there are still rows in the excel with data
            while(xlWorkSheet.Cells[row, 1].value != null)
            {
                transactions.Add(GetTransactionData(row));

                row++;
            }

            //ImportDataForm newImportDataform = new ImportDataForm;
            //newImportDataform.Show();

            PopulateDataGridView(transactions);

            //cleanup  
            GC.Collect();
            GC.WaitForPendingFinalizers();

            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkSheet);
            xlWorkBook.Close();

            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkBook);
            xlApp.Quit();

            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp);
        }

        //Adds columns and their headers to the DataGridView
        void PopulateHeaders(int col)
        {
            //While there are still columns in the excel with data
            while (xlWorkSheet.Cells[1, col].value != null)
            {
                //Create new column object
                DataGridViewColumn column = new DataGridViewTextBoxColumn();
                //Get the header value from the current column in the sheet and set it as our new columns headertext
                column.HeaderText = xlWorkSheet.Cells[1, col].value;
                //Add the new column
                dataGridView.Columns.Add(column);
                col++;
            }
        }

        Transaction GetTransactionData(int row)
        {
            Transaction transaction = new Transaction();

            //DATE
            transaction.Date = Convert.ToString(xlWorkSheet.Cells[row, 1].value);

            //DESCRIPTION
            transaction.Description = xlWorkSheet.Cells[row, 2].value;

            //CREDIT OR DEBIT
            if(xlWorkSheet.Cells[row, 3].value != null)
            {
                transaction.value = xlWorkSheet.Cells[row, 3].value;
            }
            else
            {
                transaction.value = xlWorkSheet.Cells[row, 4].value;
            }

            return transaction;

        }

        void PopulateDataGridView(List<Transaction> transactions)
        {
            foreach(Transaction transaction in transactions)
            {
                string[] currentRow = { transaction.Date, transaction.Description, null, null, transaction.value.ToString() };                
                
                dataGridView.Rows.Add(currentRow);
            }
        }
    }
}
