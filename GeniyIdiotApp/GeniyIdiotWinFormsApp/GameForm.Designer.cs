namespace GeniyIdiotWinFormsApp
{
    partial class GameForm
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
			components = new System.ComponentModel.Container();
			respondTextBox1 = new TextBox();
			respondButton = new Button();
			questionTextBox1 = new TextBox();
			EndGameTimer = new System.Windows.Forms.Timer(components);
			label1 = new Label();
			SuspendLayout();
			// 
			// respondTextBox1
			// 
			respondTextBox1.Location = new Point(39, 226);
			respondTextBox1.Name = "respondTextBox1";
			respondTextBox1.Size = new Size(367, 23);
			respondTextBox1.TabIndex = 0;
			respondTextBox1.TextAlign = HorizontalAlignment.Center;
			respondTextBox1.TextChanged += respondTextBox1_TextChanged;
			respondTextBox1.KeyDown += respondTextBox1_KeyDown;
			// 
			// respondButton
			// 
			respondButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
			respondButton.Location = new Point(147, 306);
			respondButton.Name = "respondButton";
			respondButton.Size = new Size(138, 63);
			respondButton.TabIndex = 2;
			respondButton.Text = "Ответить";
			respondButton.UseVisualStyleBackColor = true;
			respondButton.Click += respondButton_Click;
			// 
			// questionTextBox1
			// 
			questionTextBox1.Enabled = false;
			questionTextBox1.Location = new Point(39, 68);
			questionTextBox1.Multiline = true;
			questionTextBox1.Name = "questionTextBox1";
			questionTextBox1.Size = new Size(367, 96);
			questionTextBox1.TabIndex = 3;
			questionTextBox1.TextAlign = HorizontalAlignment.Center;
			// 
			// EndGameTimer
			// 
			EndGameTimer.Interval = 1000;
			EndGameTimer.Tick += EndGameTimerTick;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
			label1.Location = new Point(352, 9);
			label1.Name = "label1";
			label1.Size = new Size(54, 45);
			label1.TabIndex = 4;
			label1.Text = "10";
			// 
			// GameForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(446, 450);
			Controls.Add(label1);
			Controls.Add(questionTextBox1);
			Controls.Add(respondButton);
			Controls.Add(respondTextBox1);
			Name = "GameForm";
			Text = "Игра";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox respondTextBox1;
        private Button respondButton;
        private TextBox questionTextBox1;
		private System.Windows.Forms.Timer EndGameTimer;
		private Label label1;
	}
}