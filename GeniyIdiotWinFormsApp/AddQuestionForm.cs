using GeniyIdiotConsoleApp;
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
    public partial class AddQuestionForm : Form
    {
        QuestionsStorage storage;
        public AddQuestionForm(QuestionsStorage storage)
        {
            InitializeComponent();
            this.storage = storage;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            storage.Add(new Question(questionTextBox.Text, int.Parse(answerTextBox.Text)));
            storage.Save();
            Close();
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (questionTextBox.Text.Contains(";;;") == false && int.TryParse(answerTextBox.Text, out var answer))
            {
                acceptButton.Enabled = true;
            }
            else
            {
                acceptButton.Enabled = false;
            }
        }
    }
}
