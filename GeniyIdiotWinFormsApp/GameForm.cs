using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeniyIdiotConsoleApp;

namespace GeniyIdiotWinFormsApp
{
	public partial class GameForm : Form
	{
		QuestionsStorage storage;
		int CountRightAnswers = 0;
		public event Action<int> FinishGame;
		Question currentQuestion;
		Question CurrentQuestion
		{
			get { return currentQuestion; }
			set
			{
				currentQuestion = value;
				questionTextBox1.Text = value.question;
			}
		}

		int time = 10;

		private int Time 
		{
			get { return time; }
			set 
			{
				time = value;
				if (time == 0) 
				{
					time = 10;
					Respond();
				}
				label1.Text = Convert.ToString(time);
			}
		}

		public GameForm(QuestionsStorage storage)
		{
			InitializeComponent();
			respondButton.Enabled = false;
			this.storage = storage;
			this.storage.Reset();
			CurrentQuestion = this.storage.Next;
			EndGameTimer.Start();
		}

		private void respondTextBox1_TextChanged(object sender, EventArgs e)
		{
			if (int.TryParse(respondTextBox1.Text, out var answer))
			{
				respondButton.Enabled = true;
			}
			else
			{
				respondButton.Enabled = false;
			}
		}

		private void respondButton_Click(object sender, EventArgs e)
		{
			Respond();
		}
		private void respondTextBox1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				Respond();
			}
		}
		private void Respond()
		{
			if (int.TryParse(respondTextBox1.Text, out var answer) && Convert.ToInt32(respondTextBox1.Text) == currentQuestion.answer)
			{
				CountRightAnswers++;
			}
			if (storage.MoveNext())
			{
				CurrentQuestion = storage.Next;
				respondTextBox1.Text = "";
				respondButton.Enabled = false;
			}
			else
			{
				Finish();
			}
		}

		private void Finish()
		{
			FinishGame(CountRightAnswers);
			Dispose();
		}

		private void EndGameTimerTick(object sender, EventArgs e)
		{
			Time -= 1;
		}
	}
}
