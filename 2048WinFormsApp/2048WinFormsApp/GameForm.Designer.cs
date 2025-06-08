namespace _2048WinFormsApp
{
    partial class GameForm
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
            ScoreLabel = new Label();
            SuspendLayout();
            // 
            // ScoreLabel
            // 
            ScoreLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ScoreLabel.Location = new Point(0, 10);
            ScoreLabel.Name = "ScoreLabel";
            ScoreLabel.Size = new Size(544, 50);
            ScoreLabel.TabIndex = 0;
            ScoreLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 450);
            Controls.Add(ScoreLabel);
            Name = "GameForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Game";
            Load += Form1_Load;
            KeyDown += GameForm_KeyDown;
            ResumeLayout(false);
        }

        #endregion

        private Label ScoreLabel;
    }
}
