﻿using BudgetApp.Models;
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
            PopulateForm();
            SetDateTimePickers();

            if (!Settings.Default.messageShown)
            {
                MessageBox.Show("Welcome to the MyBudget App", "My Budget", MessageBoxButtons.OK, MessageBoxIcon.None);

                //Ensures this will only run on the users first use of the app
                Settings.Default.messageShown = true;
                Settings.Default.Save();
            }
        }

        private void PopulateForm()
        {
            LoadDataFromDatabase();
            PopulateYearComboBox();
            PopulateDefinedDateTotals();
            PopulateCategoryGraph();
            PopulateYearTotals();
            PopulateMonthBarGraph();
        }

        private void LoadDataFromDatabase()
        {
            transactionsList = TransactionsDataAccess.LoadAllTransactions();
            uniqueCategoriesList = CategoriesDataAccess.LoadUniqueCategoryList();
            Category.SaveDefaultCategories();
        }

        #region DateTime Pickers and Category Graph

        private void SetDateTimePickers()
        {
            if (transactionsList != null)
            {
                transactionsList.Sort((i, j) => DateTime.Compare(i.Date, j.Date));

                FromDateTimePicker.Value = transactionsList.First().Date;
                ToDateTimePicker.Value = transactionsList.Last().Date;
            }
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

            IncomeValue.Text = income.ToString("0.##");
            ExpensesValue.Text = (expenses * -1).ToString("0.##");
            NetValue.Text = (expenses + income).ToString("0.##");
        }

        private void PopulateCategoryGraph()
        {
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
            if (transactionsList != null)
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
                monthExpenses *= -1;

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

            YearIncomeValue.Text = income.ToString("0.##");
            YearExpensesValue.Text = (expenses * -1).ToString("0.##");
            YearTotalValue.Text = (expenses + income).ToString("0.##");
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