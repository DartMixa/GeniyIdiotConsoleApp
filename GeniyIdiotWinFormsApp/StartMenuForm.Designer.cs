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
            registrationButton = new Button();
            userNameLable = new Label();
            StartGameButton = new Button();
            AddQuestionButton = new Button();
            DeleteQuestionButton = new Button();
            SuspendLayout();
            // 
            // ResultsTableButton
            // 
            ResultsTableButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ResultsTableButton.Location = new Point(43, 73);
            ResultsTableButton.Name = "ResultsTableButton";
            ResultsTableButton.Size = new Size(174, 85);
            ResultsTableButton.TabIndex = 0;
            ResultsTableButton.Text = "Табица результатов";
            ResultsTableButton.UseVisualStyleBackColor = true;
            ResultsTableButton.Click += ResultsTableButton_Click;
            // 
            // registrationButton
            // 
            registrationButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            registrationButton.Location = new Point(255, 73);
            registrationButton.Name = "registrationButton";
            registrationButton.Size = new Size(174, 85);
            registrationButton.TabIndex = 1;
            registrationButton.Text = "Сменить Имя";
            registrationButton.UseVisualStyleBackColor = true;
            registrationButton.Click += registrationButton_Click;
            // 
            // userNameLable
            // 
            userNameLable.AutoSize = true;
            userNameLable.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            userNameLable.Location = new Point(106, 22);
            userNameLable.Name = "userNameLable";
            userNameLable.Size = new Size(143, 25);
            userNameLable.TabIndex = 2;
            userNameLable.Text = "Пользователь: ";
            // 
            // StartGameButton
            // 
            StartGameButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            StartGameButton.Location = new Point(146, 195);
            StartGameButton.Name = "StartGameButton";
            StartGameButton.Size = new Size(175, 84);
            StartGameButton.TabIndex = 3;
            StartGameButton.Text = "Играть";
            StartGameButton.UseVisualStyleBackColor = true;
            StartGameButton.Click += StartGameButton_Click;
            // 
            // AddQuestionButton
            // 
            AddQuestionButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AddQuestionButton.Location = new Point(43, 312);
            AddQuestionButton.Name = "AddQuestionButton";
            AddQuestionButton.Size = new Size(175, 84);
            AddQuestionButton.TabIndex = 4;
            AddQuestionButton.Text = "Добавить вопрос";
            AddQuestionButton.UseVisualStyleBackColor = true;
            AddQuestionButton.Click += AddQuestionButton_Click;
            // 
            // DeleteQuestionButton
            // 
            DeleteQuestionButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DeleteQuestionButton.Location = new Point(254, 312);
            DeleteQuestionButton.Name = "DeleteQuestionButton";
            DeleteQuestionButton.Size = new Size(175, 84);
            DeleteQuestionButton.TabIndex = 5;
            DeleteQuestionButton.Text = "Удалить вопрос";
            DeleteQuestionButton.UseVisualStyleBackColor = true;
            DeleteQuestionButton.Click += DeleteQuestionButton_Click;
            // 
            // StartMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 450);
            Controls.Add(DeleteQuestionButton);
            Controls.Add(AddQuestionButton);
            Controls.Add(StartGameButton);
            Controls.Add(userNameLable);
            Controls.Add(registrationButton);
            Controls.Add(ResultsTableButton);
            Name = "StartMenuForm";
            Text = "Гений и идиот";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ResultsTableButton;
        private Button registrationButton;
        private Label userNameLable;
        private Button StartGameButton;
        private Button AddQuestionButton;
        private Button DeleteQuestionButton;
    }
}
