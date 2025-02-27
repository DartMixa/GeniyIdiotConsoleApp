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
            cancelButton = new Button();
            acceptButton = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // questionTextBox
            // 
            questionTextBox.Location = new Point(12, 44);
            questionTextBox.Multiline = true;
            questionTextBox.Name = "questionTextBox";
            questionTextBox.Size = new Size(433, 96);
            questionTextBox.TabIndex = 0;
            questionTextBox.TextAlign = HorizontalAlignment.Center;
            questionTextBox.TextChanged += TextBox_TextChanged;
            // 
            // answerTextBox
            // 
            answerTextBox.Location = new Point(22, 180);
            answerTextBox.Name = "answerTextBox";
            answerTextBox.Size = new Size(413, 23);
            answerTextBox.TabIndex = 1;
            answerTextBox.TextAlign = HorizontalAlignment.Center;
            answerTextBox.TextChanged += TextBox_TextChanged;
            // 
            // cancelButton
            // 
            cancelButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cancelButton.Location = new Point(37, 221);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(188, 56);
            cancelButton.TabIndex = 2;
            cancelButton.Text = "Отмена";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // acceptButton
            // 
            acceptButton.Enabled = false;
            acceptButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            acceptButton.Location = new Point(231, 221);
            acceptButton.Name = "acceptButton";
            acceptButton.Size = new Size(188, 56);
            acceptButton.TabIndex = 3;
            acceptButton.Text = "Добавить";
            acceptButton.UseVisualStyleBackColor = true;
            acceptButton.Click += acceptButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(22, 16);
            label1.Name = "label1";
            label1.Size = new Size(150, 25);
            label1.TabIndex = 4;
            label1.Text = "Введите вопрос";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(22, 152);
            label2.Name = "label2";
            label2.Size = new Size(203, 25);
            label2.TabIndex = 5;
            label2.Text = "Введите ответ (число)";
            // 
            // AddQuestionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 289);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(acceptButton);
            Controls.Add(cancelButton);
            Controls.Add(answerTextBox);
            Controls.Add(questionTextBox);
            Name = "AddQuestionForm";
            Text = "Добавить вопрос";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox questionTextBox;
        private TextBox answerTextBox;
        private Button cancelButton;
        private Button acceptButton;
        private Label label1;
        private Label label2;
    }
}