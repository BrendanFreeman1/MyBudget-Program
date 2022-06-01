using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Excel = Microsoft.Office.Interop.Excel;

namespace BudgetApp
{
    public partial class Form1 : Form
    {
        //Create excel objects
        Excel.Application xlApp;
        Excel.Workbook xlWorkBook;
        Excel.Worksheet xlWorkSheet;

        List<Transaction> transactions = new List<Transaction>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Importbtn_Click(object sender, EventArgs e)
        {
            string sFileName;
            openFileDialog.Title = "Excel File to Edit";
            openFileDialog.FileName = "";
            openFileDialog.Filter = "Excel File|*.xlsx;*.xls;*.csv";

            //If the openFileDialog works, continue
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Save the name of the file we're trying to open
                sFileName = openFileDialog.FileName;

                //If the file name contains something, run the readExcel method on that file
                if (sFileName.Trim() != "")
                {
                    readExcel(sFileName);
                }
            }
        }

        //Get the data from the selected excel and populate the combo box
        private void readExcel(string sFile)
        {
            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Open(sFile);//Workbook to open the excel file
            xlWorkSheet = xlWorkBook.ActiveSheet; //Gets the excels active sheet

            //Saves the current row and column, indexing starts at 1
            int Col = 1;
            int Row = 1; 

            PopulateHeaders(Col);

            //Continue while there are still rows in the excel with data
            while(xlWorkSheet.Cells[Row, 1].value != null)
            {
                transactions.Add(GetTransactionData(Row));

                Row++;
            }

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

        private void PopulateHeaders(int iCol)
        {
            //Adds columns and their headers to the DataGridView
            while (xlWorkSheet.Cells[1, iCol].value != null)
            {
                //Create new column object
                DataGridViewColumn col = new DataGridViewTextBoxColumn();
                //Get the header value from the current column and set it as our new columns header text
                col.HeaderText = xlWorkSheet.Cells[1, iCol].value;
                //Add the new column
                dataGridView.Columns.Add(col);     // ADD A NEW COLUMN.
                iCol++;
            }
        }

        private Transaction GetTransactionData(int row)
        {
            Transaction transaction = new Transaction();

            transaction.Description = xlWorkSheet.Cells[row, 2].value;         


            return transaction;

        }

        private void PopulateDataGridView(List<Transaction> transactions)
        {
            foreach(Transaction transaction in transactions)
            {
                string[] currentRow = { transaction.Description };                
                
                dataGridView.Rows.Add(currentRow);
            }
        }
    }
}
