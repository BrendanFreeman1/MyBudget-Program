using BudgetApp.Models;
using BudgetApp.Views;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BudgetApp
{
    public partial class BudgetApp : Form
    {
        private static List<Transaction> transactionsList = new List<Transaction>();
        private static List<Category> categoriesList = new List<Category>();
        private static List<string> uniqueCategoriesList = new List<string>();
        public BudgetApp()
        {
            InitializeComponent();
            LoadFromDatabase();
            SaveDefaultCategories();
            PopulateYearComoboBox();
            PopulateCategoryBarGraph();
            PopulateMonthBarGraph();
        }

        private void PopulateYearComoboBox()
        {
            //Get year of earlist date from database and set that as first year, then run through to year of last date

            for(int i = 1900; i < 3000; i++)
            {
                yearComboBox.Items.Add(i.ToString());
            }

            yearComboBox.Text = DateTime.Now.Year.ToString();
        }

        public static void StartUp()
        {
            LoadFromDatabase();
        }

        static void LoadFromDatabase()
        {
            transactionsList = SqliteDataAccess.LoadTransactions();
            categoriesList = SqliteDataAccess.LoadCategories();
            
            //Get the names of the categories already in the database
            List<string> categoryNames = categoriesList.Select(c => c.Name).ToList();

            foreach (string name in categoryNames)
            {
                if (!uniqueCategoriesList.Contains(name)) { uniqueCategoriesList.Add(name); }
            }
        }

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
                //Open a new ImportDataForm and run the ImportData method on that file
                if (openFileDialog.FileName.Trim() != "")
                {
                    ImportDataForm importDataForm = new ImportDataForm();
                    importDataForm.Show();

                    importDataForm.ImportData(openFileDialog.FileName);
                }
            }
        }

        void CustomCategorybtn_Click(object sender, EventArgs e)
        {
            CustomCategoryForm customCategoryForm = new CustomCategoryForm();
            customCategoryForm.Show();
        }

        void SaveDefaultCategories()
        {
            //After the users categories have been loaded from their database into the categoriesList
            //Check if it contains the default categories, if not add them to the database
            //Should only work on the users intial use of this app

            List<Category> defaultCategories = new List<Category>
            {
                new Category ("Children", null),
                new Category ("Debt", null),
                new Category ("Education", null),
                new Category ("Entertainment", null),
                new Category ("Everyday", null),
                new Category ("Gifts", null),
                new Category ("Ignore", null),
                new Category ("Income", null),
                new Category ("Insurance", null),
                new Category ("Other", null),
                new Category ("Pets", null),
                new Category ("Transportation", null),
                new Category ("Travel", null),
                new Category ("Utilities", null)     
            };

            //Get the names of the categories already in the database
            List<string> categoryNames = categoriesList.Select(c => c.Name).ToList();

            //Compair the categories we want to add against what we already have
            foreach (Category defaultCategory in defaultCategories)
            {
                if (!categoryNames.Contains(defaultCategory.Name)) { SqliteDataAccess.SaveCategory(defaultCategory); }
            }
        }

        void PopulateCategoryBarGraph()
        {
            categoryExpencesChart.Series["Category Totals"].Points.Clear();

            foreach (string categoryName in uniqueCategoriesList)
            {
                double categoryTotal = Transaction.Total(transactionsList, fromDateTimePicker.Value, toDateTimePicker.Value, categoryName) ;

                if(categoryTotal != 0 && categoryName != "Ignore" && categoryName != "Income")
                {
                    categoryExpencesChart.Series["Category Totals"].Points.AddXY(categoryName, categoryTotal*-1);
                }
            }
        }

        void PopulateMonthBarGraph()
        {
            monthChart.Series["Month Totals"].Points.Clear();

            for (int i=1; i<=12; i++)
            {
                string month = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(i);
                DateTime monthStart = new DateTime(int.Parse(yearComboBox.Text), i, 1);
                DateTime monthEnd = monthStart.AddMonths(1).AddDays(-1); //Get the 1st of the next month, then subtract 1 day

                monthChart.Series["Month Totals"].Points.AddXY(month, Transaction.Total(transactionsList, monthStart, monthEnd, null));
            }
        }

        void SortByDatebtn_Click(object sender, EventArgs e)
        {
            //CLEAN UP MATHS HERE!!!!!!!!!!!!
            PopulateCategoryBarGraph();

            double income = Transaction.Total(transactionsList, fromDateTimePicker.Value, toDateTimePicker.Value, "Income");
            double expenses = Transaction.Total(transactionsList, fromDateTimePicker.Value, toDateTimePicker.Value, null) - income;

            incomeValue.Text = income.ToString("0.##");
            expensesValue.Text = expenses.ToString("0.##");
            netValue.Text = (income - (expenses*-1)).ToString("0.##");
        }

        private void yearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateMonthBarGraph();
        }
    }
}
