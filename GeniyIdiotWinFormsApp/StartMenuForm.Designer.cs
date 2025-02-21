namespace GeniyIdiotWinFormsApp
{
	partial class StartMenuForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			ResultsTableButton = new Button();
			SuspendLayout();
			// 
			// ResultsTableButton
			// 
			ResultsTableButton.Location = new Point(74, 62);
			ResultsTableButton.Name = "ResultsTableButton";
			ResultsTableButton.Size = new Size(132, 50);
			ResultsTableButton.TabIndex = 0;
			ResultsTableButton.Text = "Табица результатов";
			ResultsTableButton.UseVisualStyleBackColor = true;
			ResultsTableButton.Click += ResultsTableButton_Click;
			// 
			// StartMenuForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(ResultsTableButton);
			Name = "StartMenuForm";
			Text = "Гений и идиот";
			ResumeLayout(false);
		}

		#endregion

		private Button ResultsTableButton;
	}
}
