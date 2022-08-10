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
        #region Initialise Variables
        private static List<Transaction> transactionsList = new List<Transaction>();
        private static List<string> uniqueCategoriesList = new List<string>();          
        #endregion

        public BudgetApp()
        {
            InitializeComponent();
            ReloadForm();

            if (!Settings.Default.messageShown)
            {
                MessageForm messageForm = new MessageForm();
                messageForm.Message("Welcome to the MyBudget App");
                messageForm.TopMost = true;
                messageForm.Show();

                //Ensure this will only run on the users first use of the app
                Settings.Default.messageShown = true;
                Settings.Default.Save();
            }
        }

        internal static void ReloadForm()
        {
            LoadDataFromDatabase();
            PopulateFormsBoxes();
            PopulateYearLabels();
            PopulateCategoryGraph();
            PopulateDateTotals();
            PopulateMonthBarGraph();
        }

        private static void LoadDataFromDatabase()
        {
            transactionsList = TransactionsDataAccess.LoadTransactions();
            uniqueCategoriesList = CategoriesDataAccess.LoadUniqueCategoryList();

            //Ensure user has the default categories
            Category.SaveDefaultCategories();
        }


        private static void PopulateFormsBoxes()
        {
            if (transactionsList.Count > 0)
            {
                //Populate Date Pickers
                //Sort the transations list by date
                transactionsList.Sort((i, j) => DateTime.Compare(i.Date, j.Date));

                //Set DateTimePickers dates
                FromDateTimePicker.Value = transactionsList.First().Date;
                ToDateTimePicker.Value = transactionsList.Last().Date;

                //Populate YearComoboBox
                int currentYear = transactionsList.First().Date.Year;
                int lastYear = transactionsList.Last().Date.Year;
                //Add all the years between the first and last to the YearComboBox
                while (currentYear <= lastYear)
                {
                    YearComboBox.Items.Add(currentYear.ToString());
                    currentYear++;
                }
            }

            //Set the YearComboBox to the current year
            YearComboBox.Text = DateTime.Now.Year.ToString();
        }

        #region DateTime Pickers

        private void FromDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            PopulateDateTotals();
            PopulateCategoryGraph();
        }

        private void ToDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            PopulateDateTotals();
            PopulateCategoryGraph();
        }

        private static void PopulateDateTotals()
        {
            double income = Transaction.Total(transactionsList, FromDateTimePicker.Value, ToDateTimePicker.Value, "Income");
            double expenses = Transaction.Total(transactionsList, FromDateTimePicker.Value, ToDateTimePicker.Value, null) - income;

            IncomeValue.Text = income.ToString("0.##");
            ExpensesValue.Text = (expenses * -1).ToString("0.##");
            NetValue.Text = (expenses + income).ToString("0.##");
        }

        private static void PopulateCategoryGraph()
        {
            //Clear values from the chart
            categoryExpencesChart.Series["Category Totals"].Points.Clear();

            //Add the totals per category to the chart, Except for the 'Ignore' and 'Income' Categories
            foreach (string categoryName in uniqueCategoriesList)
            {
                double categoryTotal = Transaction.Total(transactionsList, FromDateTimePicker.Value, ToDateTimePicker.Value, categoryName);

                //Expenses
                if (categoryTotal != 0 && categoryName != "Ignore" && categoryName != "Income")
                {
                    categoryExpencesChart.Series["Category Totals"].Points.AddXY(categoryName, categoryTotal * -1);
                }
            }
        }

        #endregion

        private void YearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateMonthBarGraph();
            PopulateYearLabels();
        }

        private static void PopulateMonthBarGraph()
        {
            //Clear values from the chart
            monthChart.Series["Income"].Points.Clear();
            monthChart.Series["Expenses"].Points.Clear();
            monthChart.Series["Net"].Points.Clear();

            //For each month add the month and the totals to the chart
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
                monthExpenses *= -1;

                monthChart.Series["Income"].Points.AddXY(month, monthIncome);
                monthChart.Series["Expenses"].Points.AddY(monthExpenses);
                monthChart.Series["Net"].Points.AddY(monthNet);
            }
        }

        private static void PopulateYearLabels()
        {
            DateTime yearStart = new DateTime(int.Parse(YearComboBox.Text), 1, 1);
            DateTime yearEnd = yearStart.AddMonths(13).AddDays(-1);

            double income = Transaction.Total(transactionsList, yearStart, yearEnd, "Income");
            double expenses = Transaction.Total(transactionsList, yearStart, yearEnd, null) - income;

            YearIncomeValue.Text = income.ToString("0.##");
            YearExpensesValue.Text = (expenses * -1).ToString("0.##");
            YearTotalValue.Text = (expenses + income).ToString("0.##");
        }

        #region Button Click Events
        private void Importbtn_Click(object sender, EventArgs e)
        {
            ImportDataForm importDataForm = new ImportDataForm();
            importDataForm.Show();

            importDataForm.OpenFile();
        }

        private void ViewTransactionbtn_Click(object sender, EventArgs e)
        {
            AllTransactionsForm allTransactionsForm = new AllTransactionsForm();
            allTransactionsForm.Show();
        }

        private void ViewCategoriesbtn_Click(object sender, EventArgs e)
        {
            AllCategoriesForm allCategoriesForm = new AllCategoriesForm();
            allCategoriesForm.Show();
        }
        #endregion
    }
}