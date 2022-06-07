using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Excel = Microsoft.Office.Interop.Excel;

namespace BudgetApp
{
    public partial class BudgetApp : Form
    { 
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

            //If the user has selected a file and pressed 'Open' and not 'Cancel'
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //If the file name has now been updated from null to something
                //Open a new ImportDataForm and run the readExcel method on that file
                if (openFileDialog.FileName.Trim() != "")
                {
                    ImportDataForm importDataForm = new ImportDataForm();
                    importDataForm.Show();
                    
                    importDataForm.ReadExcel(openFileDialog.FileName);
                }
            }
        }

        
    }
}
