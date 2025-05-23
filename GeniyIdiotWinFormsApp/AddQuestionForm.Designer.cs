namespace GeniyIdiotWinFormsApp
{
    partial class AddQuestionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			questionTextBox = new TextBox();
			answerTextBox = new TextBox();
			acceptButton = new Button();
			label1 = new Label();
			label2 = new Label();
			questionsDataGridView = new DataGridView();
			Column3 = new DataGridViewTextBoxColumn();
			Column1 = new DataGridViewTextBoxColumn();
			Column2 = new DataGridViewTextBoxColumn();
			label3 = new Label();
			DeleteButton = new Button();
			((System.ComponentModel.ISupportInitialize)questionsDataGridView).BeginInit();
			SuspendLayout();
			// 
			// questionTextBox
			// 
			questionTextBox.Location = new Point(655, 65);
			questionTextBox.Multiline = true;
			questionTextBox.Name = "questionTextBox";
			questionTextBox.Size = new Size(381, 96);
			questionTextBox.TabIndex = 0;
			questionTextBox.TextAlign = HorizontalAlignment.Center;
			questionTextBox.TextChanged += TextBox_TextChanged;
			// 
			// answerTextBox
			// 
			answerTextBox.Location = new Point(655, 192);
			answerTextBox.Name = "answerTextBox";
			answerTextBox.Size = new Size(381, 23);
			answerTextBox.TabIndex = 1;
			answerTextBox.TextAlign = HorizontalAlignment.Center;
			answerTextBox.TextChanged += TextBox_TextChanged;
			// 
			// acceptButton
			// 
			acceptButton.Enabled = false;
			acceptButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
			acceptButton.Location = new Point(655, 221);
			acceptButton.Name = "acceptButton";
			acceptButton.Size = new Size(381, 56);
			acceptButton.TabIndex = 3;
			acceptButton.Text = "Добавить";
			acceptButton.UseVisualStyleBackColor = true;
			acceptButton.Click += acceptButton_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
			label1.Location = new Point(655, 37);
			label1.Name = "label1";
			label1.Size = new Size(150, 25);
			label1.TabIndex = 4;
			label1.Text = "Введите вопрос";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
			label2.Location = new Point(655, 164);
			label2.Name = "label2";
			label2.Size = new Size(203, 25);
			label2.TabIndex = 5;
			label2.Text = "Введите ответ (число)";
			// 
			// questionsDataGridView
			// 
			questionsDataGridView.AllowUserToAddRows = false;
			questionsDataGridView.AllowUserToDeleteRows = false;
			questionsDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			questionsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			questionsDataGridView.Columns.AddRange(new DataGridViewColumn[] { Column3, Column1, Column2 });
			questionsDataGridView.Location = new Point(12, 12);
			questionsDataGridView.Name = "questionsDataGridView";
			questionsDataGridView.ReadOnly = true;
			questionsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			questionsDataGridView.Size = new Size(623, 374);
			questionsDataGridView.TabIndex = 6;
			questionsDataGridView.KeyDown += questionsDataGridView_KeyDown;
			// 
			// Column3
			// 
			Column3.HeaderText = "№";
			Column3.Name = "Column3";
			Column3.ReadOnly = true;
			Column3.Width = 30;
			// 
			// Column1
			// 
			Column1.HeaderText = "Вопрос";
			Column1.Name = "Column1";
			Column1.ReadOnly = true;
			Column1.Width = 500;
			// 
			// Column2
			// 
			Column2.HeaderText = "Ответ";
			Column2.Name = "Column2";
			Column2.ReadOnly = true;
			Column2.Width = 50;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
			label3.Location = new Point(641, 12);
			label3.Name = "label3";
			label3.Size = new Size(164, 25);
			label3.TabIndex = 7;
			label3.Text = "Добавить вопрос";
			// 
			// DeleteButton
			// 
			DeleteButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
			DeleteButton.Location = new Point(655, 320);
			DeleteButton.Name = "DeleteButton";
			DeleteButton.Size = new Size(381, 56);
			DeleteButton.TabIndex = 8;
			DeleteButton.Text = "Удолить выбранный вопрос";
			DeleteButton.UseVisualStyleBackColor = true;
			DeleteButton.Click += DeleteButton_Click;
			// 
			// AddQuestionForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1045, 408);
			Controls.Add(DeleteButton);
			Controls.Add(label3);
			Controls.Add(questionsDataGridView);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(acceptButton);
			Controls.Add(answerTextBox);
			Controls.Add(questionTextBox);
			Name = "AddQuestionForm";
			Text = "Добавить вопрос";
			Load += QuestionForm_Load;
			((System.ComponentModel.ISupportInitialize)questionsDataGridView).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox questionTextBox;
        private TextBox answerTextBox;
        private Button acceptButton;
        private Label label1;
        private Label label2;
		private DataGridView questionsDataGridView;
		private DataGridViewTextBoxColumn Column3;
		private DataGridViewTextBoxColumn Column1;
		private DataGridViewTextBoxColumn Column2;
		private Label label3;
		private Button DeleteButton;
	}
}