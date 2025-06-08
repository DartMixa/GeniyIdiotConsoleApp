using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048WinFormsApp
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var game = new GameForm();
            //game.Location = this.Location + Size / 2 - game.Size / 2;
            game.Show();
            this.Hide();
            game.FormClosed += gameFormClosed;
        }
        private void gameFormClosed(object sender, EventArgs e) 
        {
            this.Show();
        }
    }
}
