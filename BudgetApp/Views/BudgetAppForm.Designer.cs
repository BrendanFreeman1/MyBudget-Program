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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Importbtn = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.CustomCategorybtn = new System.Windows.Forms.Button();
            this.categoryTotalsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.toDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fromLabel = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.SortByDatebtn = new System.Windows.Forms.Button();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalValueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.categoryTotalsChart)).BeginInit();
            this.SuspendLayout();
            // 
            // Importbtn
            // 
            this.Importbtn.Location = new System.Drawing.Point(858, 730);
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
            // CustomCategorybtn
            // 
            this.CustomCategorybtn.Location = new System.Drawing.Point(858, 759);
            this.CustomCategorybtn.Name = "CustomCategorybtn";
            this.CustomCategorybtn.Size = new System.Drawing.Size(145, 23);
            this.CustomCategorybtn.TabIndex = 1;
            this.CustomCategorybtn.Text = "Create Custom Category";
            this.CustomCategorybtn.UseVisualStyleBackColor = true;
            this.CustomCategorybtn.Click += new System.EventHandler(this.CustomCategorybtn_Click);
            // 
            // categoryTotalsChart
            // 
            this.categoryTotalsChart.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.categoryTotalsChart.BorderlineColor = System.Drawing.Color.Transparent;
            this.categoryTotalsChart.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            this.categoryTotalsChart.BorderSkin.BorderColor = System.Drawing.Color.Transparent;
            this.categoryTotalsChart.BorderSkin.BorderWidth = 0;
            this.categoryTotalsChart.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackImageTransparentColor = System.Drawing.Color.Transparent;
            chartArea1.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.BorderWidth = 0;
            chartArea1.Name = "ChartArea1";
            this.categoryTotalsChart.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.BackImageTransparentColor = System.Drawing.Color.Transparent;
            legend1.BackSecondaryColor = System.Drawing.Color.Transparent;
            legend1.BorderColor = System.Drawing.Color.Transparent;
            legend1.Enabled = false;
            legend1.ForeColor = System.Drawing.Color.Transparent;
            legend1.HeaderSeparatorColor = System.Drawing.Color.White;
            legend1.ItemColumnSeparatorColor = System.Drawing.Color.White;
            legend1.Name = "Legend1";
            this.categoryTotalsChart.Legends.Add(legend1);
            this.categoryTotalsChart.Location = new System.Drawing.Point(12, 527);
            this.categoryTotalsChart.Name = "categoryTotalsChart";
            this.categoryTotalsChart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series1.BackSecondaryColor = System.Drawing.Color.Transparent;
            series1.BorderColor = System.Drawing.Color.Transparent;
            series1.BorderWidth = 0;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Transparent;
            series1.CustomProperties = "CollectedColor=Black";
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.LabelBackColor = System.Drawing.Color.Transparent;
            series1.LabelBorderColor = System.Drawing.Color.Transparent;
            series1.LabelForeColor = System.Drawing.Color.Transparent;
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.Transparent;
            series1.MarkerColor = System.Drawing.Color.Transparent;
            series1.Name = "Category Totals";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
            series1.XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            this.categoryTotalsChart.Series.Add(series1);
            this.categoryTotalsChart.Size = new System.Drawing.Size(840, 255);
            this.categoryTotalsChart.TabIndex = 2;
            this.categoryTotalsChart.Text = "chart1";
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromDateTimePicker.Location = new System.Drawing.Point(12, 27);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(96, 20);
            this.fromDateTimePicker.TabIndex = 3;
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.toDateTimePicker.Location = new System.Drawing.Point(124, 27);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.Size = new System.Drawing.Size(96, 20);
            this.toDateTimePicker.TabIndex = 4;
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.ForeColor = System.Drawing.Color.White;
            this.fromLabel.Location = new System.Drawing.Point(47, 8);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(30, 13);
            this.fromLabel.TabIndex = 5;
            this.fromLabel.Text = "From";
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.ForeColor = System.Drawing.Color.White;
            this.toLabel.Location = new System.Drawing.Point(156, 8);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(20, 13);
            this.toLabel.TabIndex = 6;
            this.toLabel.Text = "To";
            // 
            // SortByDatebtn
            // 
            this.SortByDatebtn.Location = new System.Drawing.Point(237, 27);
            this.SortByDatebtn.Name = "SortByDatebtn";
            this.SortByDatebtn.Size = new System.Drawing.Size(56, 20);
            this.SortByDatebtn.TabIndex = 7;
            this.SortByDatebtn.Text = "Go";
            this.SortByDatebtn.UseVisualStyleBackColor = true;
            this.SortByDatebtn.Click += new System.EventHandler(this.SortByDatebtn_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.ForeColor = System.Drawing.Color.White;
            this.totalLabel.Location = new System.Drawing.Point(12, 511);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(34, 13);
            this.totalLabel.TabIndex = 8;
            this.totalLabel.Text = "Total:";
            // 
            // totalValueLabel
            // 
            this.totalValueLabel.AutoSize = true;
            this.totalValueLabel.ForeColor = System.Drawing.Color.White;
            this.totalValueLabel.Location = new System.Drawing.Point(48, 511);
            this.totalValueLabel.Name = "totalValueLabel";
            this.totalValueLabel.Size = new System.Drawing.Size(13, 13);
            this.totalValueLabel.TabIndex = 9;
            this.totalValueLabel.Text = "0";
            // 
            // BudgetApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1014, 794);
            this.Controls.Add(this.totalValueLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.SortByDatebtn);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.toDateTimePicker);
            this.Controls.Add(this.fromDateTimePicker);
            this.Controls.Add(this.categoryTotalsChart);
            this.Controls.Add(this.CustomCategorybtn);
            this.Controls.Add(this.Importbtn);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "BudgetApp";
            this.Text = "BudgetApp";
            ((System.ComponentModel.ISupportInitialize)(this.categoryTotalsChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Importbtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button CustomCategorybtn;
        private System.Windows.Forms.DataVisualization.Charting.Chart categoryTotalsChart;
        private System.Windows.Forms.DateTimePicker fromDateTimePicker;
        private System.Windows.Forms.DateTimePicker toDateTimePicker;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Button SortByDatebtn;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label totalValueLabel;
    }
}

