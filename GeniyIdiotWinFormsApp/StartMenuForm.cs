using GeniyIdiotConsoleApp;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GeniyIdiotWinFormsApp
{
    public partial class StartMenuForm : Form
    {
        static UsersResultStorage usersResultStorage = new();
        QuestionsStorage questionsStorage;
        User user;

        ResultsTableForm resultsTableForm;
        GameForm gameForm;

        User User
        {
            get
            {
                return user;
            }
            set
            {
                user = value;
                userNameLable.Text = "Пользователь: " + value.Name;
            }
        }

        public StartMenuForm()
        {
            InitializeComponent();
            usersResultStorage.Load();
            questionsStorage = QuestionsStorage.Load();
            Authorization("noname");
        }

        private void ResultsTableButton_Click(object sender, EventArgs e)
        {
            resultsTableForm?.Close();
            resultsTableForm = new();
			UpdateTable();
			resultsTableForm.Show();
        }
        
        private void registrationButton_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new();
            registrationForm.LogIn += Authorization;
            registrationForm.ShowDialog();
        }

        private void Authorization(string name)
        {
            User = new User(name);
        }

        private void StartGameButton_Click(object sender, EventArgs e)
        {
            gameForm?.Close();
            gameForm = new(questionsStorage);
            gameForm.FinishGame += FinishGame;
            gameForm.FormClosed += GameFormClose;
            gameForm.Show();
            Hide();
        }

        private void FinishGame(int result)
        {
            Show();
            string diagnose = DiagnoseCalculator.GetDiagnose(result, questionsStorage.Questions.Count());
            usersResultStorage.AddDiagnose(user, new Diagnose(result, diagnose));
            usersResultStorage.Save();
            if (resultsTableForm is not null && !resultsTableForm.IsDisposed)
            {
				UpdateTable();
            }
        }
        private void UpdateTable()
        {
			resultsTableForm?.UpdateTable(usersResultStorage.GetResults());
		}

        private void GameFormClose(object? sender, FormClosedEventArgs e)
        {
            Close();
        }

        private void AddQuestionButton_Click(object sender, EventArgs e)
        {
            AddQuestionForm addQuestionForm = new(questionsStorage);
            addQuestionForm.ShowDialog();
        }
    }
}
