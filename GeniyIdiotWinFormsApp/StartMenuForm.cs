using GeniyIdiotConsoleApp;
using System.Xml.Linq;

namespace GeniyIdiotWinFormsApp
{
    public partial class StartMenuForm : Form
    {
        static UsersResultStorage usersResultStorage = new();
        ResultsTableForm resultsTableForm;
        User user;
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
    }
}
