namespace BudgetApp.Views
{
    partial class AllTransactionsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.UpdateCategorybtn = new System.Windows.Forms.Button();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.toLabel = new System.Windows.Forms.Label();
            this.fromLabel = new System.Windows.Forms.Label();
            this.ToDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CustomCategoryBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.dataGridView.Location = new System.Drawing.Point(12, 70);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 4;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(1018, 766);
            this.dataGridView.TabIndex = 3;
            // 
            // Deletebtn
            // 
            this.Deletebtn.ForeColor = System.Drawing.Color.Black;
            this.Deletebtn.Location = new System.Drawing.Point(14, 843);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(138, 24);
            this.Deletebtn.TabIndex = 4;
            this.Deletebtn.Text = "Delete Selection";
            this.Deletebtn.UseVisualStyleBackColor = true;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // UpdateCategorybtn
            // 
            this.UpdateCategorybtn.ForeColor = System.Drawing.Color.Black;
            this.UpdateCategorybtn.Location = new System.Drawing.Point(892, 12);
            this.UpdateCategorybtn.Name = "UpdateCategorybtn";
            this.UpdateCategorybtn.Size = new System.Drawing.Size(138, 21);
            this.UpdateCategorybtn.TabIndex = 5;
            this.UpdateCategorybtn.Text = "Update Selection";
            this.UpdateCategorybtn.UseVisualStyleBackColor = true;
            this.UpdateCategorybtn.Click += new System.EventHandler(this.UpdateCategorybtn_Click);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(892, 39);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(138, 21);
            this.categoryComboBox.Sorted = true;
            this.categoryComboBox.TabIndex = 19;
            // 
            // CloseBtn
            // 
            this.CloseBtn.ForeColor = System.Drawing.Color.Black;
            this.CloseBtn.Location = new System.Drawing.Point(892, 843);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(138, 23);
            this.CloseBtn.TabIndex = 20;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toLabel.ForeColor = System.Drawing.Color.White;
            this.toLabel.Location = new System.Drawing.Point(148, 16);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(25, 17);
            this.toLabel.TabIndex = 24;
            this.toLabel.Text = "To";
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromLabel.ForeColor = System.Drawing.Color.White;
            this.fromLabel.Location = new System.Drawing.Point(36, 16);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(40, 17);
            this.fromLabel.TabIndex = 23;
            this.fromLabel.Text = "From";
            // 
            // ToDateTimePicker
            // 
            this.ToDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ToDateTimePicker.Location = new System.Drawing.Point(114, 36);
            this.ToDateTimePicker.Name = "ToDateTimePicker";
            this.ToDateTimePicker.Size = new System.Drawing.Size(96, 20);
            this.ToDateTimePicker.TabIndex = 22;
            this.ToDateTimePicker.ValueChanged += new System.EventHandler(this.ToDateTimePicker_ValueChanged);
            // 
            // FromDateTimePicker
            // 
            this.FromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FromDateTimePicker.Location = new System.Drawing.Point(12, 36);
            this.FromDateTimePicker.Name = "FromDateTimePicker";
            this.FromDateTimePicker.Size = new System.Drawing.Size(96, 20);
            this.FromDateTimePicker.TabIndex = 21;
            this.FromDateTimePicker.ValueChanged += new System.EventHandler(this.FromDateTimePicker_ValueChanged);
            // 
            // CustomCategoryBtn
            // 
            this.CustomCategoryBtn.ForeColor = System.Drawing.Color.Black;
            this.CustomCategoryBtn.Location = new System.Drawing.Point(748, 843);
            this.CustomCategoryBtn.Name = "CustomCategoryBtn";
            this.CustomCategoryBtn.Size = new System.Drawing.Size(138, 23);
            this.CustomCategoryBtn.TabIndex = 25;
            this.CustomCategoryBtn.Text = "Create Category";
            this.CustomCategoryBtn.UseVisualStyleBackColor = true;
            this.CustomCategoryBtn.Click += new System.EventHandler(this.CustomCategoryBtn_Click);
            // 
            // AllTransactionsForm
            // 
            this.AcceptButton = this.UpdateCategorybtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1042, 878);
            this.Controls.Add(this.CustomCategoryBtn);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.ToDateTimePicker);
            this.Controls.Add(this.FromDateTimePicker);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.UpdateCategorybtn);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.dataGridView);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AllTransactionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transactions";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button UpdateCategorybtn;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.DateTimePicker ToDateTimePicker;
        private System.Windows.Forms.DateTimePicker FromDateTimePicker;
        private System.Windows.Forms.Button CustomCategoryBtn;
    }
}