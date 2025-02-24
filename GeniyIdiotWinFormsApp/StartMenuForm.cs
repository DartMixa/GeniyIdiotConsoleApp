using GeniyIdiotConsoleApp;
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
            resultsTableForm?.Dispose();
            resultsTableForm = new();
            resultsTableForm.UpdateTable(usersResultStorage.GetResults());
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
            gameForm?.Dispose();
            gameForm = new(questionsStorage);
            gameForm.FinishGame += FinishGame;
            gameForm.Show();
            Hide();
        }
        private void FinishGame(int result) 
        {
            Show();
            string diagnose = DiagnoseCalculator.GetDiagnose(result, questionsStorage.Questions.Count());
            usersResultStorage.AddDiagnose(user, new Diagnose(result, diagnose));
            usersResultStorage.Save();
            resultsTableForm?.UpdateTable(usersResultStorage.GetResults());
        }
    }
}
