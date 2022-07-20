namespace BudgetApp.Views
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
            categoryComboBox = new System.Windows.Forms.ComboBox();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.descriptionText = new System.Windows.Forms.Label();
            this.dateText = new System.Windows.Forms.Label();
            this.valueText = new System.Windows.Forms.Label();
            this.valueLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.FinishBtn = new System.Windows.Forms.Button();
            this.CustomCategoryBtn = new System.Windows.Forms.Button();
            this.CurrentTransactionLabel = new System.Windows.Forms.Label();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // categoryComboBox
            // 
            categoryComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Location = new System.Drawing.Point(896, 42);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new System.Drawing.Size(138, 21);
            categoryComboBox.Sorted = true;
            categoryComboBox.TabIndex = 18;
            // 
            // confirmBtn
            // 
            this.confirmBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.confirmBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmBtn.Location = new System.Drawing.Point(896, 12);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(138, 24);
            this.confirmBtn.TabIndex = 4;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.ConfirmBtn_Click);
            // 
            // descriptionText
            // 
            this.descriptionText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.descriptionText.AutoSize = true;
            this.descriptionText.ForeColor = System.Drawing.Color.Black;
            this.descriptionText.Location = new System.Drawing.Point(48, 14);
            this.descriptionText.Name = "descriptionText";
            this.descriptionText.Size = new System.Drawing.Size(60, 13);
            this.descriptionText.TabIndex = 6;
            this.descriptionText.Text = "Description";
            // 
            // dateText
            // 
            this.dateText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateText.AutoSize = true;
            this.dateText.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dateText.ForeColor = System.Drawing.Color.Black;
            this.dateText.Location = new System.Drawing.Point(12, 14);
            this.dateText.Name = "dateText";
            this.dateText.Size = new System.Drawing.Size(30, 13);
            this.dateText.TabIndex = 7;
            this.dateText.Text = "Date";
            // 
            // valueText
            // 
            this.valueText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.valueText.AutoSize = true;
            this.valueText.ForeColor = System.Drawing.Color.Black;
            this.valueText.Location = new System.Drawing.Point(114, 14);
            this.valueText.Name = "valueText";
            this.valueText.Size = new System.Drawing.Size(34, 13);
            this.valueText.TabIndex = 8;
            this.valueText.Text = "Value";
            // 
            // valueLabel
            // 
            this.valueLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.valueLabel.AutoSize = true;
            this.valueLabel.ForeColor = System.Drawing.Color.Snow;
            this.valueLabel.Location = new System.Drawing.Point(828, 50);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(68, 13);
            this.valueLabel.TabIndex = 12;
            this.valueLabel.Text = "CurrentValue";
            // 
            // dateLabel
            // 
            this.dateLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateLabel.AutoSize = true;
            this.dateLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dateLabel.ForeColor = System.Drawing.Color.Snow;
            this.dateLabel.Location = new System.Drawing.Point(18, 50);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(64, 13);
            this.dateLabel.TabIndex = 11;
            this.dateLabel.Text = "CurrentDate";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.ForeColor = System.Drawing.Color.Snow;
            this.descriptionLabel.Location = new System.Drawing.Point(150, 50);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(94, 13);
            this.descriptionLabel.TabIndex = 10;
            this.descriptionLabel.Text = "CurrentDescription";
            this.descriptionLabel.Click += new System.EventHandler(this.descriptionLabel_Click);
            // 
            // FinishBtn
            // 
            this.FinishBtn.Location = new System.Drawing.Point(896, 821);
            this.FinishBtn.Name = "FinishBtn";
            this.FinishBtn.Size = new System.Drawing.Size(138, 23);
            this.FinishBtn.TabIndex = 14;
            this.FinishBtn.Text = "Finish";
            this.FinishBtn.UseVisualStyleBackColor = true;
            this.FinishBtn.Click += new System.EventHandler(this.FinishBtn_Click);
            // 
            // CustomCategoryBtn
            // 
            this.CustomCategoryBtn.Location = new System.Drawing.Point(753, 821);
            this.CustomCategoryBtn.Name = "CustomCategoryBtn";
            this.CustomCategoryBtn.Size = new System.Drawing.Size(137, 23);
            this.CustomCategoryBtn.TabIndex = 15;
            this.CustomCategoryBtn.Text = "Create Custom Category";
            this.CustomCategoryBtn.UseVisualStyleBackColor = true;
            this.CustomCategoryBtn.Click += new System.EventHandler(this.CustomCategoryBtn_Click);
            // 
            // CurrentTransactionLabel
            // 
            this.CurrentTransactionLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CurrentTransactionLabel.AutoSize = true;
            this.CurrentTransactionLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CurrentTransactionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentTransactionLabel.ForeColor = System.Drawing.Color.Snow;
            this.CurrentTransactionLabel.Location = new System.Drawing.Point(17, 14);
            this.CurrentTransactionLabel.Name = "CurrentTransactionLabel";
            this.CurrentTransactionLabel.Size = new System.Drawing.Size(153, 20);
            this.CurrentTransactionLabel.TabIndex = 16;
            this.CurrentTransactionLabel.Text = "Current Transaction:";
            // 
            // Updatebtn
            // 
            this.Updatebtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Updatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updatebtn.Location = new System.Drawing.Point(15, 821);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(138, 23);
            this.Updatebtn.TabIndex = 17;
            this.Updatebtn.Text = "Update Category";
            this.Updatebtn.UseVisualStyleBackColor = true;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.ColumnHeadersVisible = false;
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView.Location = new System.Drawing.Point(12, 82);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 4;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView.Size = new System.Drawing.Size(1021, 733);
            this.dataGridView.TabIndex = 2;
            // 
            // ImportDataForm
            // 
            this.AcceptButton = this.confirmBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1046, 853);
            this.Controls.Add(this.Updatebtn);
            this.Controls.Add(this.CurrentTransactionLabel);
            this.Controls.Add(this.CustomCategoryBtn);
            this.Controls.Add(this.FinishBtn);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.valueText);
            this.Controls.Add(this.dateText);
            this.Controls.Add(this.descriptionText);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(categoryComboBox);
            this.Controls.Add(this.dataGridView);
            this.Name = "ImportDataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImportDataForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Label descriptionText;
        private System.Windows.Forms.Label dateText;
        private System.Windows.Forms.Label valueText;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Button FinishBtn;
        private System.Windows.Forms.Button CustomCategoryBtn;
        private System.Windows.Forms.Label CurrentTransactionLabel;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.DataGridView dataGridView;
        private static System.Windows.Forms.ComboBox categoryComboBox;
    }
}