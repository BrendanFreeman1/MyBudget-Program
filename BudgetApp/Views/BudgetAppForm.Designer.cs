namespace BudgetApp
{
    partial class BudgetApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            ImportBtn = new System.Windows.Forms.Button();
            categoryExpencesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            FromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            ToDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fromLabel = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.IncomeLabel = new System.Windows.Forms.Label();
            IncomeValue = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            NetValue = new System.Windows.Forms.Label();
            this.NetLabel = new System.Windows.Forms.Label();
            ExpensesValue = new System.Windows.Forms.Label();
            this.ExpensesLabel = new System.Windows.Forms.Label();
            this.DividerLabel = new System.Windows.Forms.Label();
            monthChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            YearComboBox = new System.Windows.Forms.ComboBox();
            YearExpensesValue = new System.Windows.Forms.Label();
            this.YearExpensesLabel = new System.Windows.Forms.Label();
            YearTotalValue = new System.Windows.Forms.Label();
            YearIncomeValue = new System.Windows.Forms.Label();
            this.YearIncomeLabel = new System.Windows.Forms.Label();
            this.YearTotalLabel = new System.Windows.Forms.Label();
            ViewTransactionsBtn = new System.Windows.Forms.Button();
            ViewCategoriesBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(categoryExpencesChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(monthChart)).BeginInit();
            this.SuspendLayout();
            // 
            // ImportBtn
            // 
            ImportBtn.Location = new System.Drawing.Point(12, 9);
            ImportBtn.Name = "ImportBtn";
            ImportBtn.Size = new System.Drawing.Size(145, 23);
            ImportBtn.TabIndex = 0;
            ImportBtn.Text = "Import Excel File";
            ImportBtn.UseVisualStyleBackColor = true;
            ImportBtn.Click += new System.EventHandler(this.Importbtn_Click);
            // 
            // categoryExpencesChart
            // 
            categoryExpencesChart.BackColor = System.Drawing.Color.Transparent;
            categoryExpencesChart.BackSecondaryColor = System.Drawing.Color.Transparent;
            categoryExpencesChart.BorderlineColor = System.Drawing.Color.Transparent;
            categoryExpencesChart.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            categoryExpencesChart.BorderSkin.BorderColor = System.Drawing.Color.Transparent;
            categoryExpencesChart.BorderSkin.BorderWidth = 0;
            categoryExpencesChart.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            chartArea3.AxisX.Interval = 1D;
            chartArea3.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea3.AxisX.LabelAutoFitStyle = ((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)((((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.IncreaseFont | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.StaggeredLabels) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap)));
            chartArea3.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea3.AxisX.LabelStyle.Interval = 0D;
            chartArea3.AxisX.LabelStyle.IntervalOffset = 0D;
            chartArea3.AxisX.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea3.AxisX.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea3.AxisX.LineColor = System.Drawing.Color.Empty;
            chartArea3.AxisX.MajorGrid.Interval = 1D;
            chartArea3.AxisX.MajorGrid.IntervalOffset = 0D;
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea3.AxisX.MajorTickMark.Enabled = false;
            chartArea3.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea3.AxisX.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea3.AxisX.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea3.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea3.AxisX2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea3.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea3.AxisX2.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea3.AxisX2.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea3.AxisX2.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea3.AxisX2.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea3.AxisX2.TitleForeColor = System.Drawing.Color.White;
            chartArea3.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea3.AxisY.LineColor = System.Drawing.Color.White;
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea3.AxisY.MajorTickMark.Enabled = false;
            chartArea3.AxisY.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea3.AxisY.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea3.AxisY.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea3.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea3.AxisY2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea3.AxisY2.LineColor = System.Drawing.Color.White;
            chartArea3.AxisY2.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea3.AxisY2.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea3.AxisY2.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea3.AxisY2.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea3.AxisY2.TitleForeColor = System.Drawing.Color.White;
            chartArea3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            chartArea3.BorderColor = System.Drawing.Color.Empty;
            chartArea3.Name = "ChartArea1";
            categoryExpencesChart.ChartAreas.Add(chartArea3);
            categoryExpencesChart.Location = new System.Drawing.Point(-40, 160);
            categoryExpencesChart.Margin = new System.Windows.Forms.Padding(0);
            categoryExpencesChart.Name = "categoryExpencesChart";
            categoryExpencesChart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series5.ChartArea = "ChartArea1";
            series5.CustomProperties = "CollectedColor=Black";
            series5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series5.IsVisibleInLegend = false;
            series5.IsXValueIndexed = true;
            series5.LabelForeColor = System.Drawing.Color.Empty;
            series5.MarkerColor = System.Drawing.Color.White;
            series5.Name = "Category Totals";
            series5.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
            categoryExpencesChart.Series.Add(series5);
            categoryExpencesChart.Size = new System.Drawing.Size(1135, 335);
            categoryExpencesChart.TabIndex = 2;
            title3.Alignment = System.Drawing.ContentAlignment.TopCenter;
            title3.BackColor = System.Drawing.Color.Transparent;
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            title3.ForeColor = System.Drawing.Color.White;
            title3.Name = "totalPerCategoryTitle";
            title3.Text = "Expences Per Category";
            categoryExpencesChart.Titles.Add(title3);
            // 
            // FromDateTimePicker
            // 
            FromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            FromDateTimePicker.Location = new System.Drawing.Point(49, 163);
            FromDateTimePicker.Name = "FromDateTimePicker";
            FromDateTimePicker.Size = new System.Drawing.Size(96, 20);
            FromDateTimePicker.TabIndex = 3;
            FromDateTimePicker.ValueChanged += new System.EventHandler(this.FromDateTimePicker_ValueChanged);
            // 
            // ToDateTimePicker
            // 
            ToDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            ToDateTimePicker.Location = new System.Drawing.Point(151, 163);
            ToDateTimePicker.Name = "ToDateTimePicker";
            ToDateTimePicker.Size = new System.Drawing.Size(96, 20);
            ToDateTimePicker.TabIndex = 4;
            ToDateTimePicker.ValueChanged += new System.EventHandler(this.ToDateTimePicker_ValueChanged);
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromLabel.ForeColor = System.Drawing.Color.White;
            this.fromLabel.Location = new System.Drawing.Point(73, 143);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(40, 17);
            this.fromLabel.TabIndex = 5;
            this.fromLabel.Text = "From";
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toLabel.ForeColor = System.Drawing.Color.White;
            this.toLabel.Location = new System.Drawing.Point(185, 143);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(25, 17);
            this.toLabel.TabIndex = 6;
            this.toLabel.Text = "To";
            // 
            // IncomeLabel
            // 
            this.IncomeLabel.AutoSize = true;
            this.IncomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncomeLabel.ForeColor = System.Drawing.Color.White;
            this.IncomeLabel.Location = new System.Drawing.Point(877, 144);
            this.IncomeLabel.Name = "IncomeLabel";
            this.IncomeLabel.Size = new System.Drawing.Size(78, 24);
            this.IncomeLabel.TabIndex = 8;
            this.IncomeLabel.Text = "Income:";
            // 
            // IncomeValue
            // 
            IncomeValue.AutoSize = true;
            IncomeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            IncomeValue.ForeColor = System.Drawing.Color.White;
            IncomeValue.Location = new System.Drawing.Point(961, 144);
            IncomeValue.Name = "IncomeValue";
            IncomeValue.Size = new System.Drawing.Size(100, 24);
            IncomeValue.TabIndex = 9;
            IncomeValue.Text = "000000000";
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(466, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(168, 37);
            this.titleLabel.TabIndex = 10;
            this.titleLabel.Text = "My Budget";
            // 
            // NetValue
            // 
            NetValue.AutoSize = true;
            NetValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            NetValue.ForeColor = System.Drawing.Color.White;
            NetValue.Location = new System.Drawing.Point(961, 120);
            NetValue.Name = "NetValue";
            NetValue.Size = new System.Drawing.Size(100, 24);
            NetValue.TabIndex = 12;
            NetValue.Text = "000000000";
            // 
            // NetLabel
            // 
            this.NetLabel.AutoSize = true;
            this.NetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NetLabel.ForeColor = System.Drawing.Color.White;
            this.NetLabel.Location = new System.Drawing.Point(911, 120);
            this.NetLabel.Name = "NetLabel";
            this.NetLabel.Size = new System.Drawing.Size(44, 24);
            this.NetLabel.TabIndex = 11;
            this.NetLabel.Text = "Net:";
            // 
            // ExpensesValue
            // 
            ExpensesValue.AutoSize = true;
            ExpensesValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ExpensesValue.ForeColor = System.Drawing.Color.White;
            ExpensesValue.Location = new System.Drawing.Point(961, 168);
            ExpensesValue.Name = "ExpensesValue";
            ExpensesValue.Size = new System.Drawing.Size(100, 24);
            ExpensesValue.TabIndex = 14;
            ExpensesValue.Text = "000000000";
            // 
            // ExpensesLabel
            // 
            this.ExpensesLabel.AutoSize = true;
            this.ExpensesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpensesLabel.ForeColor = System.Drawing.Color.White;
            this.ExpensesLabel.Location = new System.Drawing.Point(855, 168);
            this.ExpensesLabel.Name = "ExpensesLabel";
            this.ExpensesLabel.Size = new System.Drawing.Size(100, 24);
            this.ExpensesLabel.TabIndex = 13;
            this.ExpensesLabel.Text = "Expenses:";
            // 
            // DividerLabel
            // 
            this.DividerLabel.AutoSize = true;
            this.DividerLabel.ForeColor = System.Drawing.Color.White;
            this.DividerLabel.Location = new System.Drawing.Point(-10, 484);
            this.DividerLabel.Name = "DividerLabel";
            this.DividerLabel.Size = new System.Drawing.Size(1123, 13);
            this.DividerLabel.TabIndex = 15;
            this.DividerLabel.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________________" +
    "_________________________";
            // 
            // monthChart
            // 
            monthChart.BackColor = System.Drawing.Color.Transparent;
            monthChart.BorderlineColor = System.Drawing.Color.Empty;
            chartArea4.AxisX.Interval = 1D;
            chartArea4.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea4.AxisX.IsMarginVisible = false;
            chartArea4.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea4.AxisX.LabelStyle.Interval = 0D;
            chartArea4.AxisX.LabelStyle.IntervalOffset = 0D;
            chartArea4.AxisX.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea4.AxisX.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea4.AxisX.LineColor = System.Drawing.Color.White;
            chartArea4.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea4.AxisX.MajorTickMark.Enabled = false;
            chartArea4.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Empty;
            chartArea4.AxisX.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea4.AxisX.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea4.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.Empty;
            chartArea4.AxisX.TitleForeColor = System.Drawing.Color.Empty;
            chartArea4.AxisX2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea4.AxisX2.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea4.AxisX2.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea4.AxisX2.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea4.AxisX2.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea4.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea4.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea4.AxisY.LineColor = System.Drawing.Color.White;
            chartArea4.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea4.AxisY.MajorTickMark.Enabled = false;
            chartArea4.AxisY.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea4.AxisY.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea4.AxisY.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea4.AxisY2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea4.AxisY2.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea4.AxisY2.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea4.AxisY2.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea4.AxisY2.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            chartArea4.BorderColor = System.Drawing.Color.Empty;
            chartArea4.BorderWidth = 0;
            chartArea4.Name = "ChartArea1";
            monthChart.ChartAreas.Add(chartArea4);
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.ForeColor = System.Drawing.Color.White;
            legend2.Name = "MonthChartLegend";
            legend2.TitleBackColor = System.Drawing.Color.Transparent;
            legend2.TitleForeColor = System.Drawing.Color.White;
            monthChart.Legends.Add(legend2);
            monthChart.Location = new System.Drawing.Point(-38, 591);
            monthChart.Name = "monthChart";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.LabelForeColor = System.Drawing.Color.Empty;
            series6.Legend = "MonthChartLegend";
            series6.Name = "Income";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "MonthChartLegend";
            series7.Name = "Expenses";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "MonthChartLegend";
            series8.Name = "Net";
            monthChart.Series.Add(series6);
            monthChart.Series.Add(series7);
            monthChart.Series.Add(series8);
            monthChart.Size = new System.Drawing.Size(1151, 372);
            monthChart.TabIndex = 16;
            monthChart.Text = "chart1";
            title4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            title4.ForeColor = System.Drawing.Color.White;
            title4.Name = "MonthTotalsChart";
            title4.Text = "Total Per Month";
            monthChart.Titles.Add(title4);
            // 
            // YearComboBox
            // 
            YearComboBox.FormattingEnabled = true;
            YearComboBox.Location = new System.Drawing.Point(49, 591);
            YearComboBox.Name = "YearComboBox";
            YearComboBox.Size = new System.Drawing.Size(96, 21);
            YearComboBox.TabIndex = 17;
            YearComboBox.SelectedIndexChanged += new System.EventHandler(this.YearComboBox_SelectedIndexChanged);
            // 
            // YearExpensesValue
            // 
            YearExpensesValue.AutoSize = true;
            YearExpensesValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            YearExpensesValue.ForeColor = System.Drawing.Color.White;
            YearExpensesValue.Location = new System.Drawing.Point(966, 571);
            YearExpensesValue.Name = "YearExpensesValue";
            YearExpensesValue.Size = new System.Drawing.Size(100, 24);
            YearExpensesValue.TabIndex = 23;
            YearExpensesValue.Text = "000000000";
            // 
            // YearExpensesLabel
            // 
            this.YearExpensesLabel.AutoSize = true;
            this.YearExpensesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearExpensesLabel.ForeColor = System.Drawing.Color.White;
            this.YearExpensesLabel.Location = new System.Drawing.Point(822, 571);
            this.YearExpensesLabel.Name = "YearExpensesLabel";
            this.YearExpensesLabel.Size = new System.Drawing.Size(144, 24);
            this.YearExpensesLabel.TabIndex = 22;
            this.YearExpensesLabel.Text = "Year Expenses:";
            // 
            // YearTotalValue
            // 
            YearTotalValue.AutoSize = true;
            YearTotalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            YearTotalValue.ForeColor = System.Drawing.Color.White;
            YearTotalValue.Location = new System.Drawing.Point(966, 523);
            YearTotalValue.Name = "YearTotalValue";
            YearTotalValue.Size = new System.Drawing.Size(100, 24);
            YearTotalValue.TabIndex = 21;
            YearTotalValue.Text = "000000000";
            // 
            // YearIncomeValue
            // 
            YearIncomeValue.AutoSize = true;
            YearIncomeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            YearIncomeValue.ForeColor = System.Drawing.Color.White;
            YearIncomeValue.Location = new System.Drawing.Point(966, 547);
            YearIncomeValue.Name = "YearIncomeValue";
            YearIncomeValue.Size = new System.Drawing.Size(100, 24);
            YearIncomeValue.TabIndex = 19;
            YearIncomeValue.Text = "000000000";
            // 
            // YearIncomeLabel
            // 
            this.YearIncomeLabel.AutoSize = true;
            this.YearIncomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearIncomeLabel.ForeColor = System.Drawing.Color.White;
            this.YearIncomeLabel.Location = new System.Drawing.Point(844, 547);
            this.YearIncomeLabel.Name = "YearIncomeLabel";
            this.YearIncomeLabel.Size = new System.Drawing.Size(122, 24);
            this.YearIncomeLabel.TabIndex = 18;
            this.YearIncomeLabel.Text = "Year Income:";
            // 
            // YearTotalLabel
            // 
            this.YearTotalLabel.AutoSize = true;
            this.YearTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearTotalLabel.ForeColor = System.Drawing.Color.White;
            this.YearTotalLabel.Location = new System.Drawing.Point(866, 523);
            this.YearTotalLabel.Name = "YearTotalLabel";
            this.YearTotalLabel.Size = new System.Drawing.Size(100, 24);
            this.YearTotalLabel.TabIndex = 20;
            this.YearTotalLabel.Text = "Year Total:";
            // 
            // ViewTransactionsBtn
            // 
            ViewTransactionsBtn.Location = new System.Drawing.Point(12, 38);
            ViewTransactionsBtn.Name = "ViewTransactionsBtn";
            ViewTransactionsBtn.Size = new System.Drawing.Size(145, 23);
            ViewTransactionsBtn.TabIndex = 24;
            ViewTransactionsBtn.Text = "View All Transactions";
            ViewTransactionsBtn.UseVisualStyleBackColor = true;
            ViewTransactionsBtn.Click += new System.EventHandler(this.ViewTransactionbtn_Click);
            // 
            // ViewCategoriesBtn
            // 
            ViewCategoriesBtn.Location = new System.Drawing.Point(12, 67);
            ViewCategoriesBtn.Name = "ViewCategoriesBtn";
            ViewCategoriesBtn.Size = new System.Drawing.Size(145, 23);
            ViewCategoriesBtn.TabIndex = 25;
            ViewCategoriesBtn.Text = "View All Categories";
            ViewCategoriesBtn.UseVisualStyleBackColor = true;
            ViewCategoriesBtn.Click += new System.EventHandler(this.ViewCategoriesbtn_Click);
            // 
            // BudgetApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1090, 975);
            this.Controls.Add(ViewCategoriesBtn);
            this.Controls.Add(ViewTransactionsBtn);
            this.Controls.Add(YearExpensesValue);
            this.Controls.Add(this.YearExpensesLabel);
            this.Controls.Add(YearTotalValue);
            this.Controls.Add(this.YearTotalLabel);
            this.Controls.Add(YearIncomeValue);
            this.Controls.Add(this.YearIncomeLabel);
            this.Controls.Add(YearComboBox);
            this.Controls.Add(monthChart);
            this.Controls.Add(this.DividerLabel);
            this.Controls.Add(ExpensesValue);
            this.Controls.Add(this.ExpensesLabel);
            this.Controls.Add(NetValue);
            this.Controls.Add(this.NetLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(IncomeValue);
            this.Controls.Add(this.IncomeLabel);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(ToDateTimePicker);
            this.Controls.Add(FromDateTimePicker);
            this.Controls.Add(categoryExpencesChart);
            this.Controls.Add(ImportBtn);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "BudgetApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyBudget";
            ((System.ComponentModel.ISupportInitialize)(categoryExpencesChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(monthChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private static System.Windows.Forms.Button ImportBtn;
        private static System.Windows.Forms.Button ViewTransactionsBtn;
        private static System.Windows.Forms.Button ViewCategoriesBtn;
        private static System.Windows.Forms.DataVisualization.Charting.Chart categoryExpencesChart;
        private static System.Windows.Forms.DateTimePicker FromDateTimePicker;
        private static System.Windows.Forms.DateTimePicker ToDateTimePicker;
        private static System.Windows.Forms.DataVisualization.Charting.Chart monthChart;
        private static System.Windows.Forms.ComboBox YearComboBox;
        private static System.Windows.Forms.Label IncomeValue;
        private static System.Windows.Forms.Label NetValue;
        private static System.Windows.Forms.Label ExpensesValue;
        private static System.Windows.Forms.Label YearTotalValue;
        private static System.Windows.Forms.Label YearIncomeValue;
        private static System.Windows.Forms.Label YearExpensesValue;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Label IncomeLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label NetLabel;
        private System.Windows.Forms.Label ExpensesLabel;
        private System.Windows.Forms.Label DividerLabel;
        private System.Windows.Forms.Label YearExpensesLabel;
        private System.Windows.Forms.Label YearIncomeLabel;
        private System.Windows.Forms.Label YearTotalLabel;
    }
}

