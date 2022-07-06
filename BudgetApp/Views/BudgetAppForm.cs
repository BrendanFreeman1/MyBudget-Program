using BudgetApp.Models;
using BudgetApp.Views;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BudgetApp
{
    public partial class BudgetApp : Form
    {
        List<Transaction> transactionsList = new List<Transaction>();
        List<Category> categoriesList = new List<Category>();

        public BudgetApp()
        {
            InitializeComponent();
            LoadFromDatabase();
            SaveDefaultCategories();
            PopulateLabels();
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

        void LoadFromDatabase()
        {
            transactionsList = SqliteDataAccess.LoadTransactions();
            categoriesList = SqliteDataAccess.LoadCategories();
        }

        void SaveDefaultCategories()
        {
            //After the users categories have been loaded from their database into the categoriesList
            //Check if it contains the default categories, if not add them to the database
            //Should only work on the users intial use of this app

            List<Category> defaultCategories = new List<Category>
            {
                new Category ("Ignore", ""),
                new Category ("Children", ""),
                new Category ("Debt", ""),
                new Category ("Education", ""),
                new Category ("Entertainment", ""),
                new Category ("Everyday", ""),
                new Category ("Gifts", ""),
                new Category ("Insurance", ""),
                new Category ("Pets", ""),
                new Category ("Technology", ""),
                new Category ("Transportation", ""),
                new Category ("Travel", ""),
                new Category ("Utilities", ""),
                new Category ("Other", "")
            };

            foreach(Category defaultCategory in defaultCategories)
            {
                if(!categoriesList.Contains(defaultCategory))
                {
                    SqliteDataAccess.SaveCategory(defaultCategory);
                }
            }
            
        }

        void CustomCategorybtn_Click(object sender, EventArgs e)
        {
            CustomCategoryForm customCategoryForm = new CustomCategoryForm();
            customCategoryForm.Show();
        }

        void PopulateLabels()
        {
            TotalValue.Text = Transaction.Total(transactionsList).ToString();
        }
    }
}
