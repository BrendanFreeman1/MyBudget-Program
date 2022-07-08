using BudgetApp.Models;
using BudgetApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BudgetApp
{
    public partial class BudgetApp : Form
    {
        private static List<Transaction> transactionsList = new List<Transaction>();
        private static List<Category> categoriesList = new List<Category>();

        public BudgetApp()
        {
            InitializeComponent();
            SaveDefaultCategories();
            StartUp();
        }

        public static void StartUp()
        {
            LoadFromDatabase();
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

                    importDataForm.ImportData(openFileDialog.FileName);
                }
            }

        }

        static void LoadFromDatabase()
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
                new Category ("Ignore", null),
                new Category ("Children", null),
                new Category ("Debt", null),
                new Category ("Education", null),
                new Category ("Entertainment", null),
                new Category ("Everyday", null),
                new Category ("Gifts", null),
                new Category ("Insurance", null),
                new Category ("Pets", null),
                new Category ("Transportation", null),
                new Category ("Travel", null),
                new Category ("Utilities", null),
                new Category ("Other", null)
            };

            //Get the names of the categories already in the database
            List<string> categoryNames = categoriesList.Select(c => c.Name).ToList();

            //Compair the categories we want to add against what we already have
            foreach (Category defaultCategory in defaultCategories)
            {
                if (!categoryNames.Contains(defaultCategory.Name)) { SqliteDataAccess.SaveCategory(defaultCategory); }
            }
        }

        void CustomCategorybtn_Click(object sender, EventArgs e)
        {
            CustomCategoryForm customCategoryForm = new CustomCategoryForm();
            customCategoryForm.Show();
        }

        static void PopulateLabels()
        {
            TotalValue.Text = Transaction.Total(transactionsList).ToString();
        }
    }
}
