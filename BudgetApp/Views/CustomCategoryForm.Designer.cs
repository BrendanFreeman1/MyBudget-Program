namespace BudgetApp.Views
{
    partial class CustomCategoryForm
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
            this.tagBox = new System.Windows.Forms.TextBox();
            this.textLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.categoryNameBox = new System.Windows.Forms.TextBox();
            this.ConfirmBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tagBox
            // 
            this.tagBox.Location = new System.Drawing.Point(65, 49);
            this.tagBox.Name = "tagBox";
            this.tagBox.Size = new System.Drawing.Size(250, 20);
            this.tagBox.TabIndex = 0;
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.ForeColor = System.Drawing.Color.Snow;
            this.textLabel.Location = new System.Drawing.Point(62, 33);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(133, 13);
            this.textLabel.TabIndex = 1;
            this.textLabel.Text = "Text to auto categorise by:";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.ForeColor = System.Drawing.Color.Snow;
            this.categoryLabel.Location = new System.Drawing.Point(62, 88);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(106, 13);
            this.categoryLabel.TabIndex = 3;
            this.categoryLabel.Text = "Category for this text:";
            // 
            // categoryNameBox
            // 
            this.categoryNameBox.Location = new System.Drawing.Point(65, 104);
            this.categoryNameBox.Name = "categoryNameBox";
            this.categoryNameBox.Size = new System.Drawing.Size(250, 20);
            this.categoryNameBox.TabIndex = 2;
            // 
            // ConfirmBtn
            // 
            this.ConfirmBtn.Location = new System.Drawing.Point(139, 149);
            this.ConfirmBtn.Name = "ConfirmBtn";
            this.ConfirmBtn.Size = new System.Drawing.Size(100, 25);
            this.ConfirmBtn.TabIndex = 4;
            this.ConfirmBtn.Text = "Confirm";
            this.ConfirmBtn.UseVisualStyleBackColor = true;
            this.ConfirmBtn.Click += new System.EventHandler(this.ConfirmBtn_Click);
            // 
            // CustomCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.ConfirmBtn);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.categoryNameBox);
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.tagBox);
            this.Name = "CustomCategoryForm";
            this.Text = "CustomCategoryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tagBox;
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.TextBox categoryNameBox;
        private System.Windows.Forms.Button ConfirmBtn;
    }
}