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
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CustomCategoryBtn = new System.Windows.Forms.Button();
            this.UpdateCategoryBtn = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ViewAllCategoriesBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(1023, 44);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(138, 21);
            this.categoryComboBox.Sorted = true;
            this.categoryComboBox.TabIndex = 18;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(1023, 817);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(138, 24);
            this.SaveBtn.TabIndex = 14;
            this.SaveBtn.Text = "Save All";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CustomCategoryBtn
            // 
            this.CustomCategoryBtn.Location = new System.Drawing.Point(1023, 757);
            this.CustomCategoryBtn.Name = "CustomCategoryBtn";
            this.CustomCategoryBtn.Size = new System.Drawing.Size(138, 24);
            this.CustomCategoryBtn.TabIndex = 15;
            this.CustomCategoryBtn.Text = "Create Category";
            this.CustomCategoryBtn.UseVisualStyleBackColor = true;
            this.CustomCategoryBtn.Click += new System.EventHandler(this.CustomCategoryBtn_Click);
            // 
            // UpdateCategoryBtn
            // 
            this.UpdateCategoryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateCategoryBtn.Location = new System.Drawing.Point(1023, 12);
            this.UpdateCategoryBtn.Name = "UpdateCategoryBtn";
            this.UpdateCategoryBtn.Size = new System.Drawing.Size(138, 24);
            this.UpdateCategoryBtn.TabIndex = 17;
            this.UpdateCategoryBtn.Text = "Update Selection";
            this.UpdateCategoryBtn.UseVisualStyleBackColor = true;
            this.UpdateCategoryBtn.Click += new System.EventHandler(this.UpdateCategorybtn_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 4;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(1000, 830);
            this.dataGridView.TabIndex = 2;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // ViewAllCategoriesBtn
            // 
            this.ViewAllCategoriesBtn.Location = new System.Drawing.Point(1023, 787);
            this.ViewAllCategoriesBtn.Name = "ViewAllCategoriesBtn";
            this.ViewAllCategoriesBtn.Size = new System.Drawing.Size(138, 24);
            this.ViewAllCategoriesBtn.TabIndex = 19;
            this.ViewAllCategoriesBtn.Text = "View All Categories";
            this.ViewAllCategoriesBtn.UseVisualStyleBackColor = true;
            this.ViewAllCategoriesBtn.Click += new System.EventHandler(this.ViewAllCategoriesBtn_Click);
            // 
            // ImportDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1173, 853);
            this.Controls.Add(this.ViewAllCategoriesBtn);
            this.Controls.Add(this.UpdateCategoryBtn);
            this.Controls.Add(this.CustomCategoryBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.dataGridView);
            this.Name = "ImportDataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImportDataForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button CustomCategoryBtn;
        private System.Windows.Forms.Button UpdateCategoryBtn;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Button ViewAllCategoriesBtn;
    }
}