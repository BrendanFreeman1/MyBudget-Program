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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.Importbtn = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.categoryExpencesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.toDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fromLabel = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.SortByDatebtn = new System.Windows.Forms.Button();
            this.incomeLabel = new System.Windows.Forms.Label();
            this.incomeValue = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.netValue = new System.Windows.Forms.Label();
            this.netLabel = new System.Windows.Forms.Label();
            this.expensesValue = new System.Windows.Forms.Label();
            this.expensesLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.monthChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.yearComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.categoryExpencesChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthChart)).BeginInit();
            this.SuspendLayout();
            // 
            // Importbtn
            // 
            this.Importbtn.Location = new System.Drawing.Point(827, 132);
            this.Importbtn.Name = "Importbtn";
            this.Importbtn.Size = new System.Drawing.Size(145, 23);
            this.Importbtn.TabIndex = 0;
            this.Importbtn.Text = "Select Excel File";
            this.Importbtn.UseVisualStyleBackColor = true;
            this.Importbtn.Click += new System.EventHandler(this.Importbtn_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
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
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorTickMark.Size = 0F;
            chartArea1.AxisX.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.None;
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
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackImageTransparentColor = System.Drawing.Color.Transparent;
            chartArea1.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.BorderWidth = 0;
            chartArea1.Name = "ChartArea1";
            this.categoryExpencesChart.ChartAreas.Add(chartArea1);
            this.categoryExpencesChart.Location = new System.Drawing.Point(267, 161);
            this.categoryExpencesChart.Name = "categoryExpencesChart";
            this.categoryExpencesChart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series1.BackSecondaryColor = System.Drawing.Color.Transparent;
            series1.BorderColor = System.Drawing.Color.Transparent;
            series1.BorderWidth = 0;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.White;
            series1.CustomProperties = "CollectedColor=Black";
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsVisibleInLegend = false;
            series1.LabelForeColor = System.Drawing.Color.Empty;
            series1.MarkerColor = System.Drawing.Color.White;
            series1.Name = "Category Totals";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
            this.categoryExpencesChart.Series.Add(series1);
            this.categoryExpencesChart.Size = new System.Drawing.Size(705, 271);
            this.categoryExpencesChart.TabIndex = 2;
            title1.Alignment = System.Drawing.ContentAlignment.TopCenter;
            title1.BackColor = System.Drawing.Color.Transparent;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            title1.ForeColor = System.Drawing.Color.White;
            title1.Name = "totalPerCategoryTitle";
            title1.Text = "Expences Per Category";
            this.categoryExpencesChart.Titles.Add(title1);
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromDateTimePicker.Location = new System.Drawing.Point(22, 135);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(96, 20);
            this.fromDateTimePicker.TabIndex = 3;
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.toDateTimePicker.Location = new System.Drawing.Point(134, 135);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.Size = new System.Drawing.Size(96, 20);
            this.toDateTimePicker.TabIndex = 4;
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.ForeColor = System.Drawing.Color.White;
            this.fromLabel.Location = new System.Drawing.Point(57, 116);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(30, 13);
            this.fromLabel.TabIndex = 5;
            this.fromLabel.Text = "From";
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.ForeColor = System.Drawing.Color.White;
            this.toLabel.Location = new System.Drawing.Point(166, 116);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(20, 13);
            this.toLabel.TabIndex = 6;
            this.toLabel.Text = "To";
            // 
            // SortByDatebtn
            // 
            this.SortByDatebtn.Location = new System.Drawing.Point(247, 135);
            this.SortByDatebtn.Name = "SortByDatebtn";
            this.SortByDatebtn.Size = new System.Drawing.Size(56, 20);
            this.SortByDatebtn.TabIndex = 7;
            this.SortByDatebtn.Text = "Go";
            this.SortByDatebtn.UseVisualStyleBackColor = true;
            this.SortByDatebtn.Click += new System.EventHandler(this.SortByDatebtn_Click);
            // 
            // incomeLabel
            // 
            this.incomeLabel.AutoSize = true;
            this.incomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeLabel.ForeColor = System.Drawing.Color.White;
            this.incomeLabel.Location = new System.Drawing.Point(45, 248);
            this.incomeLabel.Name = "incomeLabel";
            this.incomeLabel.Size = new System.Drawing.Size(90, 26);
            this.incomeLabel.TabIndex = 8;
            this.incomeLabel.Text = "Income:";
            // 
            // incomeValue
            // 
            this.incomeValue.AutoSize = true;
            this.incomeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeValue.ForeColor = System.Drawing.Color.White;
            this.incomeValue.Location = new System.Drawing.Point(141, 248);
            this.incomeValue.Name = "incomeValue";
            this.incomeValue.Size = new System.Drawing.Size(120, 26);
            this.incomeValue.TabIndex = 9;
            this.incomeValue.Text = "000000000";
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(413, 30);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(168, 37);
            this.titleLabel.TabIndex = 10;
            this.titleLabel.Text = "My Budget";
            // 
            // netValue
            // 
            this.netValue.AutoSize = true;
            this.netValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.netValue.ForeColor = System.Drawing.Color.White;
            this.netValue.Location = new System.Drawing.Point(141, 206);
            this.netValue.Name = "netValue";
            this.netValue.Size = new System.Drawing.Size(120, 26);
            this.netValue.TabIndex = 12;
            this.netValue.Text = "000000000";
            // 
            // netLabel
            // 
            this.netLabel.AutoSize = true;
            this.netLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.netLabel.ForeColor = System.Drawing.Color.White;
            this.netLabel.Location = new System.Drawing.Point(83, 206);
            this.netLabel.Name = "netLabel";
            this.netLabel.Size = new System.Drawing.Size(52, 26);
            this.netLabel.TabIndex = 11;
            this.netLabel.Text = "Net:";
            // 
            // expensesValue
            // 
            this.expensesValue.AutoSize = true;
            this.expensesValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expensesValue.ForeColor = System.Drawing.Color.White;
            this.expensesValue.Location = new System.Drawing.Point(141, 290);
            this.expensesValue.Name = "expensesValue";
            this.expensesValue.Size = new System.Drawing.Size(120, 26);
            this.expensesValue.TabIndex = 14;
            this.expensesValue.Text = "000000000";
            // 
            // expensesLabel
            // 
            this.expensesLabel.AutoSize = true;
            this.expensesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expensesLabel.ForeColor = System.Drawing.Color.White;
            this.expensesLabel.Location = new System.Drawing.Point(21, 290);
            this.expensesLabel.Name = "expensesLabel";
            this.expensesLabel.Size = new System.Drawing.Size(114, 26);
            this.expensesLabel.TabIndex = 13;
            this.expensesLabel.Text = "Expenses:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-22, 419);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1015, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________________" +
    "_______";
            // 
            // monthChart
            // 
            this.monthChart.BackColor = System.Drawing.Color.Transparent;
            this.monthChart.BorderlineColor = System.Drawing.Color.Empty;
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
            chartArea2.AxisX.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.ScaleBreakStyle.BreakLineStyle = System.Windows.Forms.DataVisualization.Charting.BreakLineStyle.None;
            chartArea2.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.TitleForeColor = System.Drawing.Color.Empty;
            chartArea2.AxisX2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisX2.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX2.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX2.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX2.MinorTickMark.LineColor = System.Drawing.Color.White;
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
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.BorderColor = System.Drawing.Color.Empty;
            chartArea2.BorderWidth = 0;
            chartArea2.Name = "ChartArea1";
            this.monthChart.ChartAreas.Add(chartArea2);
            this.monthChart.Location = new System.Drawing.Point(12, 549);
            this.monthChart.Name = "monthChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.LabelForeColor = System.Drawing.Color.Empty;
            series2.Name = "Month Totals";
            this.monthChart.Series.Add(series2);
            this.monthChart.Size = new System.Drawing.Size(960, 250);
            this.monthChart.TabIndex = 16;
            this.monthChart.Text = "chart1";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            title2.ForeColor = System.Drawing.Color.White;
            title2.Name = "MonthTotalsChart";
            title2.Text = "Month Totals";
            this.monthChart.Titles.Add(title2);
            // 
            // yearComboBox
            // 
            this.yearComboBox.FormattingEnabled = true;
            this.yearComboBox.Location = new System.Drawing.Point(79, 549);
            this.yearComboBox.Name = "yearComboBox";
            this.yearComboBox.Size = new System.Drawing.Size(75, 21);
            this.yearComboBox.TabIndex = 17;
            this.yearComboBox.SelectedIndexChanged += new System.EventHandler(this.yearComboBox_SelectedIndexChanged);
            // 
            // BudgetApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(984, 811);
            this.Controls.Add(this.yearComboBox);
            this.Controls.Add(this.monthChart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.expensesValue);
            this.Controls.Add(this.expensesLabel);
            this.Controls.Add(this.netValue);
            this.Controls.Add(this.netLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.incomeValue);
            this.Controls.Add(this.incomeLabel);
            this.Controls.Add(this.SortByDatebtn);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.toDateTimePicker);
            this.Controls.Add(this.fromDateTimePicker);
            this.Controls.Add(this.categoryExpencesChart);
            this.Controls.Add(this.Importbtn);
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

        private System.Windows.Forms.Button Importbtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.DataVisualization.Charting.Chart categoryExpencesChart;
        private System.Windows.Forms.DateTimePicker fromDateTimePicker;
        private System.Windows.Forms.DateTimePicker toDateTimePicker;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Button SortByDatebtn;
        private System.Windows.Forms.Label incomeLabel;
        private System.Windows.Forms.Label incomeValue;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label netValue;
        private System.Windows.Forms.Label netLabel;
        private System.Windows.Forms.Label expensesValue;
        private System.Windows.Forms.Label expensesLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart monthChart;
        private System.Windows.Forms.ComboBox yearComboBox;
    }
}

