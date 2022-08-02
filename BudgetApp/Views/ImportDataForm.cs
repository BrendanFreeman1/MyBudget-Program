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
    
    //Possibly move opening the file into this class to keep all methods private!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    public partial class ImportDataForm : Form
    {
        #region Initialise variables
        private static readonly List<Transaction> transactionList = new List<Transaction>();
        private static int listIndex = 0;

        //Create excel objects
        private static Excel.Application xlApp;
        private static Excel.Workbook xlWorkBook;
        private static Excel.Worksheet xlWorkSheet;
        #endregion

        public ImportDataForm()
        {
            InitializeComponent();

            transactionList.Clear();           
        }

        public void ImportData(string sFile)
        {
            //Called once an excel file is chosen from the BudgetAppForm
            //Gets data from the selected excel, creates transaction objects and puts them into the transactionList       

            int row = 2; //Start from second row
            xlApp = new Excel.Application(); //Excel app object
            xlWorkBook = xlApp.Workbooks.Open(sFile); //Workbook to open the excel file
            xlWorkSheet = xlWorkBook.ActiveSheet; //Gets the excels active sheet   

            try
            {
                //While there are still rows in the excel with data
                while (xlWorkSheet.Cells[row, 1].value != null)
                {
                    transactionList.Add(GetTransactionDataFromExcel(row));

                    row++;
                }

            }
            catch (System.FormatException) 
            {
                Close();

                ErrorForm errorForm = new ErrorForm();
                errorForm.Show();

                errorForm.ErrorMessage("Please select a file with the correct format.");
            }

            CreateDataGridViewColumns();

            PopulateCategoryComoboBox();

            DisplayNextRowLabels();

            CleanUpExcelObjects();
        }

        Transaction GetTransactionDataFromExcel(int row)
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
            if (xlWorkSheet.Cells[row, 3].value != null)
            {
                transaction.Value = xlWorkSheet.Cells[row, 3].value; //Credit 
            }
            else
            {
                transaction.Value = xlWorkSheet.Cells[row, 4].value; //Debit
            }

            //CATEGORY
            transaction.Category = Transaction.AutoCategorise(transaction);

            return transaction;
        }

        void CreateDataGridViewColumns()
        {
            for (int i = 0; i <= 3; i++)
            {
                DataGridViewColumn column = new DataGridViewTextBoxColumn();
                dataGridView.Columns.Add(column);
            }

            dataGridView.Columns[0].Width = 70;
            dataGridView.Columns[0].HeaderText = "Date";
            dataGridView.Columns[1].Width = 740;
            dataGridView.Columns[1].HeaderText = "Description";
            dataGridView.Columns[2].Width = 70;
            dataGridView.Columns[2].HeaderText = "Value";
            dataGridView.Columns[3].Width = 135;
            dataGridView.Columns[3].HeaderText = "Category";

        }

        internal static void PopulateCategoryComoboBox()
        {
            foreach (Category category in SqliteDataAccess.LoadCategories())
            {
                if (!categoryComboBox.Items.Contains(category.Name))
                {
                    categoryComboBox.Items.Add(category.Name);
                }
            }
        }

        internal static void UpdateTransactionsCategories()
        {
            //Update the remainder of the list with the new categorisation
            for(int i = listIndex; i < transactionList.Count; i++)
            {
                transactionList[i].Category = Transaction.AutoCategorise(transactionList[i]);
            }

            //If the user is at the very last item in the transactionList list
            if(listIndex >= transactionList.Count) { listIndex = transactionList.Count - 2; }

            //Update the category combobox text with the users new category
            categoryComboBox.SelectedItem = transactionList[listIndex].Category;
        }        
        
        void ConfirmBtn_Click(object sender, EventArgs e)
        {
            if (listIndex < transactionList.Count)
            {
                //Set transactionList category to the users selection
                transactionList[listIndex].Category = categoryComboBox.Text;

                //Add the transaction to the DataGridView
                string[] currentRow = { transactionList[listIndex].Date.ToString("d"), transactionList[listIndex].Description, transactionList[listIndex].Value.ToString(), transactionList[listIndex].Category };
                dataGridView.Rows.Add(currentRow);

                listIndex++;

                //Display the next row from the excel for the user to view and select a category for
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
                categoryComboBox.SelectedItem = transactionList[listIndex].Category;
            }
        }

        void CustomCategoryBtn_Click(object sender, EventArgs e)
        {
            CustomCategoryForm customCategoryForm = new CustomCategoryForm();
            customCategoryForm.Show();
        }

        void FinishBtn_Click(object sender, EventArgs e)
        {
            foreach (Transaction transaction in transactionList)
            {
                if(transaction.Category != "Ignore")
                {
                    SqliteDataAccess.SaveTransaction(transaction);
                }
            }

            //Reload the now updated database and Re-calculate totals
            BudgetApp.ReloadForm();

            Close();
        }

        void Updatebtn_Click(object sender, EventArgs e)
        {
            //Ensure we can only edit the Categories column
            if (dataGridView.CurrentCell.ColumnIndex == 3)
            {
                int row = dataGridView.CurrentCell.RowIndex;

                transactionList[row - 1].Category = categoryComboBox.Text; //IndexOutOfRange on first entry in DataGridView
                dataGridView.CurrentCell.Value = transactionList[row - 1].Category;
            }
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