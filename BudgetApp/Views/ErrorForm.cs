using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
