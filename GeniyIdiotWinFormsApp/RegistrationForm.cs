using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeniyIdiotWinFormsApp
{
    public partial class RegistrationForm : Form
    {
        public event Action<string> LogIn;
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RegistrationTextBox.Text.Contains(";;;") == false && RegistrationTextBox.Text.Length <= 15 && RegistrationTextBox.Text.Length > 0)
            {
                loginButton.Enabled = true;
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            LogIn(RegistrationTextBox.Text);
            Close();
        }
    }
}
