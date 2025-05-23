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
			TableUpdate();

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
		private void QuestionForm_Load(object sender, EventArgs e)
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

		private void questionsDataGridView_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete)
			{
				DeleteSelectecdQuestion();
			}
		}
		private void DeleteButton_Click(object sender, EventArgs e)
		{
			DeleteSelectecdQuestion();
		}

		private void DeleteSelectecdQuestion()
		{
			storage.Questions.RemoveAt((int)(questionsDataGridView.SelectedRows[0].Cells[0].Value ?? throw new Exception()));
			storage.Save();
			TableUpdate();
		}
	}
}
