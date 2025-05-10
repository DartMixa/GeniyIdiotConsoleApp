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
    public partial class DeleteQuestionForm : Form
    {
        QuestionsStorage storage;
        public DeleteQuestionForm(QuestionsStorage storage)
        {
            InitializeComponent();
            this.storage = storage;
        }

        private void DeleteQuestionForm_Load(object sender, EventArgs e)
        {
            TableUpdate();
        }
        private void TableUpdate()
        {
            questionsDataGridView.Rows.Clear();
            for (int i = 0; i < storage.Questions.Count; i++)
            {
                questionsDataGridView.Rows.Add();
                questionsDataGridView.Rows[i].Cells[0].Value = i;
                questionsDataGridView.Rows[i].Cells[1].Value = storage.Questions[i].question;
                questionsDataGridView.Rows[i].Cells[2].Value = storage.Questions[i].answer;
            }
        }

        private void NumberTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(numberTextBox.Text, out int res) && res >= 0 && res < storage.Questions.Count)
            {
                deleteButton.Enabled = true;
            }
            else
            {
                deleteButton.Enabled = false;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            storage.Questions.RemoveAt(int.Parse(numberTextBox.Text));
            storage.Save();
            TableUpdate();
            deleteButton.Enabled = false;
        }
    }
}
