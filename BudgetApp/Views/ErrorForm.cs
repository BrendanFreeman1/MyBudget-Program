using System.Drawing;
using System.Windows.Forms;

namespace BudgetApp.Views
{
    internal partial class ErrorForm : Form
    {
        public ErrorForm()
        {
            InitializeComponent();
        }

        internal void ErrorMessage(string message)
        {
            ErrorLabel.Text = message;
        }

        private void CancelBtn_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
