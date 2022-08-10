using System;
using System.Windows.Forms;

namespace BudgetApp.Views
{
    public partial class MessageForm : Form
    {
        public MessageForm()
        {
            InitializeComponent();
        }

        internal void Message(string message)
        {
            MessageLabel.Text = message;
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
