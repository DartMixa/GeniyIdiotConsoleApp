namespace GeniyIdiotWinFormsApp
{
	public partial class StartMenuForm : Form
	{

		public StartMenuForm()
		{
			InitializeComponent();
		}

		private void ResultsTableButton_Click(object sender, EventArgs e)
		{
			ResultsTableForm resultsTableForm = new();
			resultsTableForm.Show();
		}
	}
}
