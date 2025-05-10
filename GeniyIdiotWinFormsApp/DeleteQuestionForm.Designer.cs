namespace GeniyIdiotWinFormsApp
{
    partial class DeleteQuestionForm
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
            questionsDataGridView = new DataGridView();
            Column3 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            numberTextBox = new TextBox();
            label1 = new Label();
            cancelButton = new Button();
            deleteButton = new Button();
            ((System.ComponentModel.ISupportInitialize)questionsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // questionsDataGridView
            // 
            questionsDataGridView.AllowUserToAddRows = false;
            questionsDataGridView.AllowUserToDeleteRows = false;
            questionsDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            questionsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            questionsDataGridView.Columns.AddRange(new DataGridViewColumn[] { Column3, Column1, Column2 });
            questionsDataGridView.Location = new Point(33, 30);
            questionsDataGridView.Name = "questionsDataGridView";
            questionsDataGridView.ReadOnly = true;
            questionsDataGridView.Size = new Size(623, 332);
            questionsDataGridView.TabIndex = 0;
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
            // numberTextBox
            // 
            numberTextBox.Location = new Point(56, 393);
            numberTextBox.Name = "numberTextBox";
            numberTextBox.Size = new Size(577, 23);
            numberTextBox.TabIndex = 1;
            numberTextBox.TextChanged += NumberTextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(67, 365);
            label1.Name = "label1";
            label1.Size = new Size(435, 25);
            label1.TabIndex = 2;
            label1.Text = "Введите номер вопроса который хотите удалить";
            // 
            // cancelButton
            // 
            cancelButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cancelButton.Location = new Point(143, 422);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(188, 66);
            cancelButton.TabIndex = 3;
            cancelButton.Text = "Отмена";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Enabled = false;
            deleteButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            deleteButton.Location = new Point(337, 422);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(188, 66);
            deleteButton.TabIndex = 4;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += DeleteButton_Click;
            // 
            // DeleteQuestionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 499);
            Controls.Add(deleteButton);
            Controls.Add(cancelButton);
            Controls.Add(label1);
            Controls.Add(numberTextBox);
            Controls.Add(questionsDataGridView);
            Name = "DeleteQuestionForm";
            Text = "DeleteQuestionForm";
            Load += DeleteQuestionForm_Load;
            ((System.ComponentModel.ISupportInitialize)questionsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView questionsDataGridView;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private TextBox numberTextBox;
        private Label label1;
        private Button cancelButton;
        private Button deleteButton;
    }
}