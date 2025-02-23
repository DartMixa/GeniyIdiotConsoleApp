namespace GeniyIdiotWinFormsApp
{
    partial class RegistrationForm
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
            label1 = new Label();
            RegistrationTextBox = new TextBox();
            loginButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(65, 9);
            label1.Name = "label1";
            label1.Size = new Size(171, 25);
            label1.TabIndex = 0;
            label1.Text = "Введите ваше имя";
            // 
            // RegistrationTextBox
            // 
            RegistrationTextBox.Location = new Point(12, 37);
            RegistrationTextBox.Name = "RegistrationTextBox";
            RegistrationTextBox.Size = new Size(287, 23);
            RegistrationTextBox.TabIndex = 1;
            RegistrationTextBox.TextChanged += RegistrationTextBox_TextChanged;
            // 
            // loginButton
            // 
            loginButton.Enabled = false;
            loginButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loginButton.Location = new Point(76, 76);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(149, 36);
            loginButton.TabIndex = 2;
            loginButton.Text = "Войти";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(311, 117);
            Controls.Add(loginButton);
            Controls.Add(RegistrationTextBox);
            Controls.Add(label1);
            Name = "RegistrationForm";
            Text = "RegistrationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox RegistrationTextBox;
        private Button loginButton;
    }
}