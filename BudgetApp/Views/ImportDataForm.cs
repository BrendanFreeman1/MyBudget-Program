﻿using BudgetApp.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace BudgetApp.Views
{
    /// <summary>
    /// Takes data from the selected excel form as seperate 'Transaction' objects
    /// Allows the user to categorise each transaction, saves them to a list, Saves the finished list to the users database
    /// </summary>
    internal partial class ImportDataForm : Form
    {
        #region Initialise variables
        static readonly List<Transaction> transactionList = new List<Transaction>();
        static int listIndex = 0;

        //Create excel objects
        static Excel.Application xlApp;
        static Excel.Workbook xlWorkBook;
        static Excel.Worksheet xlWorkSheet;
        #endregion

        public ImportDataForm()
        {
            InitializeComponent();

            transactionList.Clear();
            FormBuilder.PopulateTransactionColumns(dataGridView);
            FormBuilder.PopulateComboBox(categoryComboBox);
        }
        internal static void UpdateTransactionsCategories()
        {
            //Reload ComboBox with newly added category
            FormBuilder.PopulateComboBox(categoryComboBox);

            //When the user added a new Category to AutoCategorise by, we want to update whatever remains in the transactionsList

            //Update the remainder of the list with the new categorisation
            for (int i = listIndex; i < transactionList.Count; i++)
            {
                transactionList[i].Category = Transaction.AutoCategorise(transactionList[i]);
            }

            //If the user is at the very last item in the transactionList list
            if (listIndex >= transactionList.Count) { listIndex = transactionList.Count - 2; }

            //Update the category combobox text with the users new category
            categoryComboBox.SelectedItem = transactionList[listIndex].Category;
        }

        internal void OpenFile()
        {
            //Set the file name to null to begin with
            openFileDialog.FileName = "";
            //Restrict the file types we can attempt to open
            openFileDialog.Filter = "Excel File|*.xlsx;*.xls;*.csv";

            //If the user has selected a file and pressed 'Open' and not 'Cancel'
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //If the file name has now been updated from null to something
                //Open a new ImportDataForm and run the ImportData method on that file
                if (openFileDialog.FileName.Trim() != "")
                {
                    ImportData(openFileDialog.FileName);
                }
            }
        }

        void ImportData(string sFile)
        {
            //Called once an excel file is chosen
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
                    //Populate Transactions list
                    transactionList.Add(Transaction.GetTransactionDataFromExcel(row, xlWorkSheet));

                    row++;
                }

            }
            catch //Not an acceptable way to handle exceptions, think of a better way!!!!?!?!!?!?!!!
            {
                Close();

                ErrorForm errorForm = new ErrorForm();
                errorForm.Show();
                errorForm.ErrorMessage("Please select a file with the correct format.");
            }

            DisplayNextRowLabels();

            CleanUpExcelObjects();
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
        
        void ConfirmBtn_Click(object sender, EventArgs e)
        {
            if (listIndex < transactionList.Count)
            {
                //Set transactionList category to the users selection
                transactionList[listIndex].Category = categoryComboBox.Text;

                FormBuilder.PopulateTransactionRow(dataGridView, transactionList[listIndex]);
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

        void Updatebtn_Click(object sender, EventArgs e)
        {
            //If the user doesn't have anything selected
            if (dataGridView.CurrentCell == null) { return; }

            //Ensure we can only edit the Categories column
            if (dataGridView.CurrentCell.ColumnIndex == 3)
            {
                int row = dataGridView.CurrentCell.RowIndex;

                transactionList[row].Category = categoryComboBox.Text;
                dataGridView.CurrentCell.Value = transactionList[row].Category;

                //Return the ComoboBox text to the suggested category for the current transaction
                categoryComboBox.Text = Transaction.AutoCategorise(transactionList[listIndex]);
            }
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

        void CustomCategoryBtn_Click(object sender, EventArgs e)
        {
            CustomCategoryForm customCategoryForm = new CustomCategoryForm();
            customCategoryForm.Show();
        }
    }
}