namespace BudgetApp.Views
{
    partial class MessageForm
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
            this.MessageLabel = new System.Windows.Forms.Label();
            this.ConfirmBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MessageLabel
            // 
            this.MessageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessageLabel.Location = new System.Drawing.Point(0, 0);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(784, 461);
            this.MessageLabel.TabIndex = 0;
            this.MessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConfirmBtn
            // 
            this.ConfirmBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ConfirmBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmBtn.ForeColor = System.Drawing.Color.Black;
            this.ConfirmBtn.Location = new System.Drawing.Point(331, 410);
            this.ConfirmBtn.Name = "ConfirmBtn";
            this.ConfirmBtn.Size = new System.Drawing.Size(138, 24);
            this.ConfirmBtn.TabIndex = 20;
            this.ConfirmBtn.Text = "OK";
            this.ConfirmBtn.UseVisualStyleBackColor = true;
            this.ConfirmBtn.Click += new System.EventHandler(this.ConfirmBtn_Click);
            // 
            // MessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.ConfirmBtn);
            this.Controls.Add(this.MessageLabel);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "MessageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessageForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.Button ConfirmBtn;
    }
}