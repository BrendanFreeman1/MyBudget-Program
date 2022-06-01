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

            //Get the data from the selected excel and populate the combo box
            void readExcel(string sFile)
            {
                xlApp = new Excel.Application();
                xlWorkBook = xlApp.Workbooks.Open(sFile);//Workbook to open the excel file
                xlWorkSheet = xlWorkBook.ActiveSheet; //Gets the excels active sheet

                //Saves the current row and column
                int iCol = 1; //Indexing starts at 1
                int iRow = 2; //Start from the second row

                //Adds columns and their headers
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



                //Add rows and their values
                for (iRow = 2; iRow <= xlWorkSheet.Rows.Count; iRow++)  // START FROM THE SECOND ROW.
                {
                    if (xlWorkSheet.Cells[iRow, 1].value == null)
                    {
                        break;      // BREAK LOOP.
                    }
                    else
                    {

                        string[] row = { xlWorkSheet.Cells[iRow, 2].value };

                        // ADD A NEW ROW TO THE GRID USING THE ARRAY DATA.
                        dataGridView.Rows.Add(row);
                    }
                }

                //cleanup  
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
}
