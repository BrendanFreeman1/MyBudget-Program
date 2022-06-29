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
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.descriptionText = new System.Windows.Forms.Label();
            this.dateText = new System.Windows.Forms.Label();
            this.valueText = new System.Windows.Forms.Label();
            this.valueLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.Heading = new System.Windows.Forms.Label();
            this.FinishButton = new System.Windows.Forms.Button();
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
            this.dataGridView.Location = new System.Drawing.Point(12, 122);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 4;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView.Size = new System.Drawing.Size(1021, 735);
            this.dataGridView.TabIndex = 2;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(889, 36);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(138, 21);
            this.categoryComboBox.TabIndex = 3;
            // 
            // confirmButton
            // 
            this.confirmButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.confirmButton.Location = new System.Drawing.Point(889, 69);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(138, 21);
            this.confirmButton.TabIndex = 4;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // descriptionText
            // 
            this.descriptionText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.descriptionText.AutoSize = true;
            this.descriptionText.ForeColor = System.Drawing.Color.Snow;
            this.descriptionText.Location = new System.Drawing.Point(176, 39);
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
            this.dateText.ForeColor = System.Drawing.Color.Snow;
            this.dateText.Location = new System.Drawing.Point(12, 39);
            this.dateText.Name = "dateText";
            this.dateText.Size = new System.Drawing.Size(30, 13);
            this.dateText.TabIndex = 7;
            this.dateText.Text = "Date";
            // 
            // valueText
            // 
            this.valueText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.valueText.AutoSize = true;
            this.valueText.ForeColor = System.Drawing.Color.Snow;
            this.valueText.Location = new System.Drawing.Point(803, 39);
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
            this.valueLabel.Location = new System.Drawing.Point(803, 73);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(34, 13);
            this.valueLabel.TabIndex = 12;
            this.valueLabel.Text = "Value";
            // 
            // dateLabel
            // 
            this.dateLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateLabel.AutoSize = true;
            this.dateLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dateLabel.ForeColor = System.Drawing.Color.Snow;
            this.dateLabel.Location = new System.Drawing.Point(12, 73);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(30, 13);
            this.dateLabel.TabIndex = 11;
            this.dateLabel.Text = "Date";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.ForeColor = System.Drawing.Color.Snow;
            this.descriptionLabel.Location = new System.Drawing.Point(176, 73);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.descriptionLabel.TabIndex = 10;
            this.descriptionLabel.Text = "Description";
            // 
            // Heading
            // 
            this.Heading.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Heading.AutoSize = true;
            this.Heading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Heading.ForeColor = System.Drawing.Color.Snow;
            this.Heading.Location = new System.Drawing.Point(273, 9);
            this.Heading.Name = "Heading";
            this.Heading.Size = new System.Drawing.Size(501, 20);
            this.Heading.TabIndex = 13;
            this.Heading.Text = "Please select a Category for the current transaction and click \'Confirm\'";
            // 
            // FinishButton
            // 
            this.FinishButton.Location = new System.Drawing.Point(889, 894);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(138, 21);
            this.FinishButton.TabIndex = 14;
            this.FinishButton.Text = "Finish";
            this.FinishButton.UseVisualStyleBackColor = true;
            this.FinishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // ImportDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1046, 927);
            this.Controls.Add(this.FinishButton);
            this.Controls.Add(this.Heading);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.valueText);
            this.Controls.Add(this.dateText);
            this.Controls.Add(this.descriptionText);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.dataGridView);
            this.Name = "ImportDataForm";
            this.Text = "ImportDataForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Label descriptionText;
        private System.Windows.Forms.Label dateText;
        private System.Windows.Forms.Label valueText;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label Heading;
        private System.Windows.Forms.Button FinishButton;
    }
}