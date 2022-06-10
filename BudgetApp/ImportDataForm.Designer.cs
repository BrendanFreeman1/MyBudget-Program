namespace BudgetApp
{
    partial class ImportDataForm
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.SelectCategoryLabel = new System.Windows.Forms.Label();
            this.ConfirmCategoryBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.ColumnHeadersVisible = false;
            this.dataGridView.Location = new System.Drawing.Point(2, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 4;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView.Size = new System.Drawing.Size(1100, 837);
            this.dataGridView.TabIndex = 2;
            this.dataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DataGridView_DataError);
            // 
            // SelectCategoryLabel
            // 
            this.SelectCategoryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectCategoryLabel.AutoSize = true;
            this.SelectCategoryLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SelectCategoryLabel.Location = new System.Drawing.Point(1108, 12);
            this.SelectCategoryLabel.Name = "SelectCategoryLabel";
            this.SelectCategoryLabel.Size = new System.Drawing.Size(264, 13);
            this.SelectCategoryLabel.TabIndex = 4;
            this.SelectCategoryLabel.Text = "Select a category for each transaction, Then press OK";
            // 
            // ConfirmCategoryBtn
            // 
            this.ConfirmCategoryBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfirmCategoryBtn.Location = new System.Drawing.Point(1207, 43);
            this.ConfirmCategoryBtn.Name = "ConfirmCategoryBtn";
            this.ConfirmCategoryBtn.Size = new System.Drawing.Size(75, 23);
            this.ConfirmCategoryBtn.TabIndex = 5;
            this.ConfirmCategoryBtn.Text = "OK";
            this.ConfirmCategoryBtn.UseVisualStyleBackColor = true;
            this.ConfirmCategoryBtn.Click += new System.EventHandler(this.ConfirmCategoryBtn_Click);
            // 
            // ImportDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1384, 861);
            this.Controls.Add(this.ConfirmCategoryBtn);
            this.Controls.Add(this.SelectCategoryLabel);
            this.Controls.Add(this.dataGridView);
            this.Name = "ImportDataForm";
            this.Text = "ImportDataForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label SelectCategoryLabel;
        private System.Windows.Forms.Button ConfirmCategoryBtn;
    }
}