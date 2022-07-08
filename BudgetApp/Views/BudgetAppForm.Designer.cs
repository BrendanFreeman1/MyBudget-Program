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
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // Importbtn
            // 
            this.Importbtn.Location = new System.Drawing.Point(1073, 730);
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
            this.CustomCategorybtn.Location = new System.Drawing.Point(1073, 759);
            this.CustomCategorybtn.Name = "CustomCategorybtn";
            this.CustomCategorybtn.Size = new System.Drawing.Size(145, 23);
            this.CustomCategorybtn.TabIndex = 1;
            this.CustomCategorybtn.Text = "Create Custom Category";
            this.CustomCategorybtn.UseVisualStyleBackColor = true;
            this.CustomCategorybtn.Click += new System.EventHandler(this.CustomCategorybtn_Click);
            // 
            // chart1
            // 
            this.chart1.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 429);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "Total";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(603, 347);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // BudgetApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1230, 794);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.CustomCategorybtn);
            this.Controls.Add(this.Importbtn);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "BudgetApp";
            this.Text = "BudgetApp";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Importbtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button CustomCategorybtn;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

