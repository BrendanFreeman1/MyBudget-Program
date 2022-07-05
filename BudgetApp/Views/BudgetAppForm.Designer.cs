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
            this.Importbtn = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.CustomCategorybtn = new System.Windows.Forms.Button();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.TotalValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Importbtn
            // 
            this.Importbtn.Location = new System.Drawing.Point(13, 13);
            this.Importbtn.Name = "Importbtn";
            this.Importbtn.Size = new System.Drawing.Size(122, 23);
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
            this.CustomCategorybtn.Location = new System.Drawing.Point(652, 771);
            this.CustomCategorybtn.Name = "CustomCategorybtn";
            this.CustomCategorybtn.Size = new System.Drawing.Size(145, 23);
            this.CustomCategorybtn.TabIndex = 1;
            this.CustomCategorybtn.Text = "Create Custom Category";
            this.CustomCategorybtn.UseVisualStyleBackColor = true;
            this.CustomCategorybtn.Click += new System.EventHandler(this.CustomCategorybtn_Click);
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.ForeColor = System.Drawing.Color.Snow;
            this.TotalLabel.Location = new System.Drawing.Point(22, 169);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(34, 13);
            this.TotalLabel.TabIndex = 2;
            this.TotalLabel.Text = "Total:";
            // 
            // TotalValue
            // 
            this.TotalValue.AutoSize = true;
            this.TotalValue.ForeColor = System.Drawing.Color.Snow;
            this.TotalValue.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TotalValue.Location = new System.Drawing.Point(62, 169);
            this.TotalValue.Name = "TotalValue";
            this.TotalValue.Size = new System.Drawing.Size(58, 13);
            this.TotalValue.TabIndex = 3;
            this.TotalValue.Text = "TotalValue";
            // 
            // BudgetApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(809, 806);
            this.Controls.Add(this.TotalValue);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.CustomCategorybtn);
            this.Controls.Add(this.Importbtn);
            this.Name = "BudgetApp";
            this.Text = "BudgetApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Importbtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button CustomCategorybtn;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label TotalValue;
    }
}

