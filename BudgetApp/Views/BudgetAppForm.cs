using BudgetApp.Models;
using BudgetApp.Views;
using BudgetApp.Properties;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace BudgetApp
{
    internal partial class BudgetApp : Form
    {
        private List<Transaction> transactionsList = new List<Transaction>();
        private List<string> uniqueCategoriesList = new List<string>();

        public BudgetApp()
        {
            InitializeComponent();
            CreateDatabaseFiles();
            PopulateForm();

            if (!Settings.Default.messageShown)
            {
                MessageBox.Show("Welcome to the MyBudget App", "My Budget", MessageBoxButtons.OK, MessageBoxIcon.None);
                
                Category.SaveDefaultCategories();

                //Ensures this method will only run on the users first use of the app
                Settings.Default.messageShown = true;
                Settings.Default.Save();
            }
        }

        private void CreateDatabaseFiles()
        {
            const string TRANSACTIONS_TABLE = "CREATE TABLE Transactions (ID INTEGER NOT NULL UNIQUE, Date TEXT NOT NULL, Description TEXT NOT NULL, Value REAL NOT NULL DEFAULT 0.00, Category TEXT NOT NULL DEFAULT 'Ignore', PRIMARY KEY(ID AUTOINCREMENT))";
            const string CATERGORIES_TABLE = "CREATE TABLE Categories (ID INTEGER NOT NULL, Name TEXT NOT NULL, Tag	TEXT, PRIMARY KEY(ID AUTOINCREMENT))";

            SqliteDataAccess.CreateDatabaseFile("transactions", TRANSACTIONS_TABLE);
            SqliteDataAccess.CreateDatabaseFile("categories", CATERGORIES_TABLE);
        }

        private void PopulateForm()
        {
            LoadDataFromDatabase();
            ClearForm();

            if (transactionsList.Count > 0)
            {
                PopulateYearComboBox();
                PopulateDefinedDateTotals();
                PopulateCategoryGraph();
                PopulateYearTotals();
                PopulateMonthBarGraph();
                SetDateTimePickers();
            }
        }

        private void ClearForm()
        {
            categoryExpencesChart.Series["Category Totals"].Points.Clear();

            IncomeValue.Text = null;
            ExpensesValue.Text = null;
            NetValue.Text = null;


            monthChart.Series["Income"].Points.Clear();
            monthChart.Series["Expenses"].Points.Clear();
            monthChart.Series["Net"].Points.Clear();

            YearIncomeValue.Text = null;
            YearExpensesValue.Text = null;
            YearTotalValue.Text = null;
        }

        private void LoadDataFromDatabase()
        {
            transactionsList = TransactionsDataAccess.LoadAllTransactions();
        }

        #region DateTime Pickers and Category Graph
        private void SetDateTimePickers()
        {
                transactionsList.Sort((i, j) => DateTime.Compare(i.Date, j.Date));

                FromDateTimePicker.Value = transactionsList.First().Date;
                ToDateTimePicker.Value = transactionsList.Last().Date;
        }

        private void FromDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            PopulateDefinedDateTotals();
            PopulateCategoryGraph();
        }

        private void ToDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            PopulateDefinedDateTotals();
            PopulateCategoryGraph();
        }

        private void PopulateDefinedDateTotals()
        {
            double income = Transaction.Total(transactionsList, FromDateTimePicker.Value, ToDateTimePicker.Value, "Income");
            double expenses = Transaction.Total(transactionsList, FromDateTimePicker.Value, ToDateTimePicker.Value, null) - income;
            NetValue.Text = (expenses + income).ToString("0.##");

            if (expenses < 0) expenses = expenses * -1;

            IncomeValue.Text = income.ToString("0.##");
            ExpensesValue.Text = (expenses).ToString("0.##");
            
        }

        private void PopulateCategoryGraph()
        {
            uniqueCategoriesList = CategoriesDataAccess.LoadUniqueCategoryList();
            categoryExpencesChart.Series["Category Totals"].Points.Clear();
            
            foreach (string categoryName in uniqueCategoriesList)
            {
                if(categoryName != "Ignore" && categoryName != "Income")
                {
                    double categoryTotal = Transaction.Total(transactionsList, FromDateTimePicker.Value, ToDateTimePicker.Value, categoryName);
                    
                    if (categoryTotal != 0)
                    {
                        categoryExpencesChart.Series["Category Totals"].Points.AddXY(categoryName, categoryTotal * -1);
                    }
                }
            }
        }
        #endregion

        #region Year ComboBox and Year Total Graph
        private void PopulateYearComboBox()
        {
            transactionsList.Sort((i, j) => DateTime.Compare(i.Date, j.Date));
            int currentYear = transactionsList.First().Date.Year;
            int lastYear = transactionsList.Last().Date.Year;

            while (currentYear <= lastYear)
            {
                YearComboBox.Items.Add(currentYear.ToString());
                currentYear++;
            }

            YearComboBox.Text = lastYear.ToString();
        }

        private void YearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateMonthBarGraph();
            PopulateYearTotals();
        }

        private void PopulateMonthBarGraph()
        {
            monthChart.Series["Income"].Points.Clear();
            monthChart.Series["Expenses"].Points.Clear();
            monthChart.Series["Net"].Points.Clear();

            for (int i = 1; i <= 12; i++)
            {
                string month = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(i);
                DateTime monthStart = new DateTime(int.Parse(YearComboBox.Text), i, 1);
                DateTime monthEnd = monthStart.AddMonths(1).AddDays(-1); //Get the 1st of the next month, then subtract 1 day

                double monthIncome = Transaction.Total(transactionsList, monthStart, monthEnd, "Income");
                double monthExpenses = Transaction.Total(transactionsList, monthStart, monthEnd, null) - monthIncome;
                double monthNet = monthIncome + monthExpenses;

                //Limit the chart to positive numbers
                if (monthNet < 0) monthNet = 0;
                if(monthExpenses < 0) monthExpenses *= -1;

                monthChart.Series["Income"].Points.AddXY(month, monthIncome);
                monthChart.Series["Expenses"].Points.AddY(monthExpenses);
                monthChart.Series["Net"].Points.AddY(monthNet);
            }          
        }

        private void PopulateYearTotals()
        {
            DateTime yearStart = new DateTime(int.Parse(YearComboBox.Text), 1, 1);
            DateTime yearEnd = yearStart.AddMonths(12).AddDays(-1);

            double income = Transaction.Total(transactionsList, yearStart, yearEnd, "Income");
            double expenses = Transaction.Total(transactionsList, yearStart, yearEnd, null) - income;
            YearTotalValue.Text = (expenses + income).ToString("0.##");

            //Limit values to positive numbers
            if (expenses < 0) expenses = expenses * -1;

            YearIncomeValue.Text = income.ToString("0.##");
            YearExpensesValue.Text = expenses.ToString("0.##");
            
        }
        #endregion

        #region Button Click Events
        private void Importbtn_Click(object sender, EventArgs e)
        {
            ImportDataForm importDataForm = new ImportDataForm();
            importDataForm.FormClosed += new FormClosedEventHandler(ReloadForm);
            if (!importDataForm.IsDisposed) { importDataForm.Show(); }
        }

        private void ViewTransactionsBtn_Click(object sender, EventArgs e)
        {
            AllTransactionsForm allTransactionsForm = new AllTransactionsForm();
            allTransactionsForm.FormClosed += new FormClosedEventHandler(ReloadForm);
            allTransactionsForm.Show();
        }

        private void ViewCategoriesBtn_Click(object sender, EventArgs e)
        {
            AllCategoriesForm allCategoriesForm = new AllCategoriesForm();
            allCategoriesForm.FormClosed += new FormClosedEventHandler(ReloadForm);
            allCategoriesForm.Show();
        }

        private void ReloadForm(object sender, FormClosedEventArgs e)
        {
            PopulateForm();
        }
        #endregion
    }
}