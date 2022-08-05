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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.ImportBtn = new System.Windows.Forms.Button();
            this.categoryExpencesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.FromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ToDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fromLabel = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.IncomeLabel = new System.Windows.Forms.Label();
            this.IncomeValue = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.NetValue = new System.Windows.Forms.Label();
            this.NetLabel = new System.Windows.Forms.Label();
            this.ExpensesValue = new System.Windows.Forms.Label();
            this.ExpensesLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.monthChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.YearComboBox = new System.Windows.Forms.ComboBox();
            this.YearExpensesValue = new System.Windows.Forms.Label();
            this.YearExpensesLabel = new System.Windows.Forms.Label();
            this.YearTotalValue = new System.Windows.Forms.Label();
            this.YearIncomeValue = new System.Windows.Forms.Label();
            this.YearIncomeLabel = new System.Windows.Forms.Label();
            this.YearTotalLabel = new System.Windows.Forms.Label();
            this.ViewTransactionsbtn = new System.Windows.Forms.Button();
            this.ViewCategoriesbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.categoryExpencesChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthChart)).BeginInit();
            this.SuspendLayout();
            // 
            // ImportBtn
            // 
            this.ImportBtn.Location = new System.Drawing.Point(12, 9);
            this.ImportBtn.Name = "ImportBtn";
            this.ImportBtn.Size = new System.Drawing.Size(145, 23);
            this.ImportBtn.TabIndex = 0;
            this.ImportBtn.Text = "Import Excel File";
            this.ImportBtn.UseVisualStyleBackColor = true;
            this.ImportBtn.Click += new System.EventHandler(this.Importbtn_Click);
            // 
            // categoryExpencesChart
            // 
            this.categoryExpencesChart.BackColor = System.Drawing.Color.Transparent;
            this.categoryExpencesChart.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.categoryExpencesChart.BorderlineColor = System.Drawing.Color.Transparent;
            this.categoryExpencesChart.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            this.categoryExpencesChart.BorderSkin.BorderColor = System.Drawing.Color.Transparent;
            this.categoryExpencesChart.BorderSkin.BorderWidth = 0;
            this.categoryExpencesChart.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.LabelAutoFitStyle = ((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)((((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.IncreaseFont | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.StaggeredLabels) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap)));
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX.LabelStyle.Interval = 0D;
            chartArea1.AxisX.LabelStyle.IntervalOffset = 0D;
            chartArea1.AxisX.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX.LineColor = System.Drawing.Color.Empty;
            chartArea1.AxisX.MajorGrid.Interval = 1D;
            chartArea1.AxisX.MajorGrid.IntervalOffset = 0D;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisX2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX2.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX2.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX2.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX2.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX2.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorTickMark.Enabled = false;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisY2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY2.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY2.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY2.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY2.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY2.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY2.TitleForeColor = System.Drawing.Color.White;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            chartArea1.BorderColor = System.Drawing.Color.Empty;
            chartArea1.Name = "ChartArea1";
            this.categoryExpencesChart.ChartAreas.Add(chartArea1);
            this.categoryExpencesChart.Location = new System.Drawing.Point(-40, 160);
            this.categoryExpencesChart.Margin = new System.Windows.Forms.Padding(0);
            this.categoryExpencesChart.Name = "categoryExpencesChart";
            this.categoryExpencesChart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series1.ChartArea = "ChartArea1";
            series1.CustomProperties = "CollectedColor=Black";
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsVisibleInLegend = false;
            series1.IsXValueIndexed = true;
            series1.LabelForeColor = System.Drawing.Color.Empty;
            series1.MarkerColor = System.Drawing.Color.White;
            series1.Name = "Category Totals";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
            this.categoryExpencesChart.Series.Add(series1);
            this.categoryExpencesChart.Size = new System.Drawing.Size(1135, 335);
            this.categoryExpencesChart.TabIndex = 2;
            title1.Alignment = System.Drawing.ContentAlignment.TopCenter;
            title1.BackColor = System.Drawing.Color.Transparent;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            title1.ForeColor = System.Drawing.Color.White;
            title1.Name = "totalPerCategoryTitle";
            title1.Text = "Expences Per Category";
            this.categoryExpencesChart.Titles.Add(title1);
            // 
            // FromDateTimePicker
            // 
            this.FromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FromDateTimePicker.Location = new System.Drawing.Point(49, 175);
            this.FromDateTimePicker.Name = "FromDateTimePicker";
            this.FromDateTimePicker.Size = new System.Drawing.Size(96, 20);
            this.FromDateTimePicker.TabIndex = 3;
            this.FromDateTimePicker.ValueChanged += new System.EventHandler(this.FromDateTimePicker_ValueChanged);
            // 
            // ToDateTimePicker
            // 
            this.ToDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ToDateTimePicker.Location = new System.Drawing.Point(151, 175);
            this.ToDateTimePicker.Name = "ToDateTimePicker";
            this.ToDateTimePicker.Size = new System.Drawing.Size(96, 20);
            this.ToDateTimePicker.TabIndex = 4;
            this.ToDateTimePicker.ValueChanged += new System.EventHandler(this.ToDateTimePicker_ValueChanged);
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromLabel.ForeColor = System.Drawing.Color.White;
            this.fromLabel.Location = new System.Drawing.Point(73, 155);
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
            this.toLabel.Location = new System.Drawing.Point(185, 155);
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
            this.IncomeLabel.Location = new System.Drawing.Point(877, 160);
            this.IncomeLabel.Name = "IncomeLabel";
            this.IncomeLabel.Size = new System.Drawing.Size(78, 24);
            this.IncomeLabel.TabIndex = 8;
            this.IncomeLabel.Text = "Income:";
            // 
            // IncomeValue
            // 
            this.IncomeValue.AutoSize = true;
            this.IncomeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncomeValue.ForeColor = System.Drawing.Color.White;
            this.IncomeValue.Location = new System.Drawing.Point(961, 160);
            this.IncomeValue.Name = "IncomeValue";
            this.IncomeValue.Size = new System.Drawing.Size(100, 24);
            this.IncomeValue.TabIndex = 9;
            this.IncomeValue.Text = "000000000";
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
            this.NetValue.AutoSize = true;
            this.NetValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NetValue.ForeColor = System.Drawing.Color.White;
            this.NetValue.Location = new System.Drawing.Point(961, 136);
            this.NetValue.Name = "NetValue";
            this.NetValue.Size = new System.Drawing.Size(100, 24);
            this.NetValue.TabIndex = 12;
            this.NetValue.Text = "000000000";
            // 
            // NetLabel
            // 
            this.NetLabel.AutoSize = true;
            this.NetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NetLabel.ForeColor = System.Drawing.Color.White;
            this.NetLabel.Location = new System.Drawing.Point(911, 136);
            this.NetLabel.Name = "NetLabel";
            this.NetLabel.Size = new System.Drawing.Size(44, 24);
            this.NetLabel.TabIndex = 11;
            this.NetLabel.Text = "Net:";
            // 
            // ExpensesValue
            // 
            this.ExpensesValue.AutoSize = true;
            this.ExpensesValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpensesValue.ForeColor = System.Drawing.Color.White;
            this.ExpensesValue.Location = new System.Drawing.Point(961, 184);
            this.ExpensesValue.Name = "ExpensesValue";
            this.ExpensesValue.Size = new System.Drawing.Size(100, 24);
            this.ExpensesValue.TabIndex = 14;
            this.ExpensesValue.Text = "000000000";
            // 
            // ExpensesLabel
            // 
            this.ExpensesLabel.AutoSize = true;
            this.ExpensesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpensesLabel.ForeColor = System.Drawing.Color.White;
            this.ExpensesLabel.Location = new System.Drawing.Point(855, 184);
            this.ExpensesLabel.Name = "ExpensesLabel";
            this.ExpensesLabel.Size = new System.Drawing.Size(100, 24);
            this.ExpensesLabel.TabIndex = 13;
            this.ExpensesLabel.Text = "Expenses:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-10, 484);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1123, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________________" +
    "_________________________";
            // 
            // monthChart
            // 
            this.monthChart.BackColor = System.Drawing.Color.Transparent;
            this.monthChart.BorderlineColor = System.Drawing.Color.Empty;
            chartArea2.AxisX.Interval = 1D;
            chartArea2.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.AxisX.IsMarginVisible = false;
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisX.LabelStyle.Interval = 0D;
            chartArea2.AxisX.LabelStyle.IntervalOffset = 0D;
            chartArea2.AxisX.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea2.AxisX.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea2.AxisX.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.MajorTickMark.Enabled = false;
            chartArea2.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Empty;
            chartArea2.AxisX.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.Empty;
            chartArea2.AxisX.TitleForeColor = System.Drawing.Color.Empty;
            chartArea2.AxisX2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisX2.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX2.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX2.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX2.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisY.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.MajorTickMark.Enabled = false;
            chartArea2.AxisY.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisY2.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY2.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY2.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY2.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            chartArea2.BorderColor = System.Drawing.Color.Empty;
            chartArea2.BorderWidth = 0;
            chartArea2.Name = "ChartArea1";
            this.monthChart.ChartAreas.Add(chartArea2);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.Name = "MonthChartLegend";
            legend1.TitleBackColor = System.Drawing.Color.Transparent;
            legend1.TitleForeColor = System.Drawing.Color.White;
            this.monthChart.Legends.Add(legend1);
            this.monthChart.Location = new System.Drawing.Point(-38, 591);
            this.monthChart.Name = "monthChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.LabelForeColor = System.Drawing.Color.Empty;
            series2.Legend = "MonthChartLegend";
            series2.Name = "Income";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "MonthChartLegend";
            series3.Name = "Expenses";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "MonthChartLegend";
            series4.Name = "Net";
            this.monthChart.Series.Add(series2);
            this.monthChart.Series.Add(series3);
            this.monthChart.Series.Add(series4);
            this.monthChart.Size = new System.Drawing.Size(1151, 372);
            this.monthChart.TabIndex = 16;
            this.monthChart.Text = "chart1";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            title2.ForeColor = System.Drawing.Color.White;
            title2.Name = "MonthTotalsChart";
            title2.Text = "Total Per Month";
            this.monthChart.Titles.Add(title2);
            // 
            // YearComboBox
            // 
            this.YearComboBox.FormattingEnabled = true;
            this.YearComboBox.Location = new System.Drawing.Point(49, 591);
            this.YearComboBox.Name = "YearComboBox";
            this.YearComboBox.Size = new System.Drawing.Size(96, 21);
            this.YearComboBox.TabIndex = 17;
            this.YearComboBox.SelectedIndexChanged += new System.EventHandler(this.YearComboBox_SelectedIndexChanged);
            // 
            // YearExpensesValue
            // 
            this.YearExpensesValue.AutoSize = true;
            this.YearExpensesValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearExpensesValue.ForeColor = System.Drawing.Color.White;
            this.YearExpensesValue.Location = new System.Drawing.Point(966, 571);
            this.YearExpensesValue.Name = "YearExpensesValue";
            this.YearExpensesValue.Size = new System.Drawing.Size(100, 24);
            this.YearExpensesValue.TabIndex = 23;
            this.YearExpensesValue.Text = "000000000";
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
            this.YearTotalValue.AutoSize = true;
            this.YearTotalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearTotalValue.ForeColor = System.Drawing.Color.White;
            this.YearTotalValue.Location = new System.Drawing.Point(966, 523);
            this.YearTotalValue.Name = "YearTotalValue";
            this.YearTotalValue.Size = new System.Drawing.Size(100, 24);
            this.YearTotalValue.TabIndex = 21;
            this.YearTotalValue.Text = "000000000";
            // 
            // YearIncomeValue
            // 
            this.YearIncomeValue.AutoSize = true;
            this.YearIncomeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearIncomeValue.ForeColor = System.Drawing.Color.White;
            this.YearIncomeValue.Location = new System.Drawing.Point(966, 547);
            this.YearIncomeValue.Name = "YearIncomeValue";
            this.YearIncomeValue.Size = new System.Drawing.Size(100, 24);
            this.YearIncomeValue.TabIndex = 19;
            this.YearIncomeValue.Text = "000000000";
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
            // ViewTransactionsbtn
            // 
            this.ViewTransactionsbtn.Location = new System.Drawing.Point(12, 38);
            this.ViewTransactionsbtn.Name = "ViewTransactionsbtn";
            this.ViewTransactionsbtn.Size = new System.Drawing.Size(145, 23);
            this.ViewTransactionsbtn.TabIndex = 24;
            this.ViewTransactionsbtn.Text = "View All Transactions";
            this.ViewTransactionsbtn.UseVisualStyleBackColor = true;
            this.ViewTransactionsbtn.Click += new System.EventHandler(this.ViewTransactionbtn_Click);
            // 
            // ViewCategoriesbtn
            // 
            this.ViewCategoriesbtn.Location = new System.Drawing.Point(12, 67);
            this.ViewCategoriesbtn.Name = "ViewCategoriesbtn";
            this.ViewCategoriesbtn.Size = new System.Drawing.Size(145, 23);
            this.ViewCategoriesbtn.TabIndex = 25;
            this.ViewCategoriesbtn.Text = "View All Categories";
            this.ViewCategoriesbtn.UseVisualStyleBackColor = true;
            this.ViewCategoriesbtn.Click += new System.EventHandler(this.ViewCategoriesbtn_Click);
            // 
            // BudgetApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1090, 975);
            this.Controls.Add(this.ViewCategoriesbtn);
            this.Controls.Add(this.ViewTransactionsbtn);
            this.Controls.Add(this.YearExpensesValue);
            this.Controls.Add(this.YearExpensesLabel);
            this.Controls.Add(this.YearTotalValue);
            this.Controls.Add(this.YearTotalLabel);
            this.Controls.Add(this.YearIncomeValue);
            this.Controls.Add(this.YearIncomeLabel);
            this.Controls.Add(this.YearComboBox);
            this.Controls.Add(this.monthChart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExpensesValue);
            this.Controls.Add(this.ExpensesLabel);
            this.Controls.Add(this.NetValue);
            this.Controls.Add(this.NetLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.IncomeValue);
            this.Controls.Add(this.IncomeLabel);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.ToDateTimePicker);
            this.Controls.Add(this.FromDateTimePicker);
            this.Controls.Add(this.categoryExpencesChart);
            this.Controls.Add(this.ImportBtn);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "BudgetApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyBudget";
            ((System.ComponentModel.ISupportInitialize)(this.categoryExpencesChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ImportBtn;
        private System.Windows.Forms.DataVisualization.Charting.Chart categoryExpencesChart;
        private System.Windows.Forms.DateTimePicker FromDateTimePicker;
        private System.Windows.Forms.DateTimePicker ToDateTimePicker;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Label IncomeLabel;
        private System.Windows.Forms.Label IncomeValue;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label NetValue;
        private System.Windows.Forms.Label NetLabel;
        private System.Windows.Forms.Label ExpensesValue;
        private System.Windows.Forms.Label ExpensesLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart monthChart;
        private System.Windows.Forms.ComboBox YearComboBox;
        private System.Windows.Forms.Label YearExpensesValue;
        private System.Windows.Forms.Label YearExpensesLabel;
        private System.Windows.Forms.Label YearTotalValue;
        private System.Windows.Forms.Label YearIncomeValue;
        private System.Windows.Forms.Label YearIncomeLabel;
        private System.Windows.Forms.Label YearTotalLabel;
        private System.Windows.Forms.Button ViewTransactionsbtn;
        private System.Windows.Forms.Button ViewCategoriesbtn;
    }
}

