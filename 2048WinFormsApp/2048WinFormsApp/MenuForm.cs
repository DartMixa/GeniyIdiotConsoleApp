using Microsoft.VisualBasic;
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
        private int bestResult;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int BestResult
        {
            get
            {
                return bestResult;
            }
            set
            {
                bestResult = value;
                BestScoreLabel.Text = "Рекорд: " + bestResult.ToString();
            }
        }
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
            var game = new GameForm(bestResult);
            //game.Location = this.Location + Size / 2 - game.Size / 2;
            game.Show();
            this.Hide();
            game.FormClosed += gameFormClosed;
        }
        private void gameFormClosed(object sender, EventArgs e)
        {
            LoadBestResult();
            this.Show();
        }
        private void LoadBestResult() 
        {
            string str = "0";
            try
            {
                str = FileSystem.ReadFile("bestResult.txt");
            }
            catch (Exception ex)
            {
                FileSystem.WriteFile("bestResult.txt", str);
            }
            BestResult = Convert.ToInt32(str);
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            LoadBestResult();
        }
    }
}
