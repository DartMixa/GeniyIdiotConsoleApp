namespace _2048WinFormsApp
{
    partial class MenuForm
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            BestScoreLabel = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(12, 77);
            button1.Name = "button1";
            button1.Size = new Size(260, 50);
            button1.TabIndex = 0;
            button1.Text = "Начать Игру";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button2.Location = new Point(12, 262);
            button2.Name = "button2";
            button2.Size = new Size(260, 50);
            button2.TabIndex = 1;
            button2.Text = "Выйти";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(0, 130);
            label1.Name = "label1";
            label1.Size = new Size(282, 129);
            label1.TabIndex = 2;
            label1.Text = "Правила: используйте стрелки для перемещения чисел в направлении стрело, одинаковые числа складываются и к счйту добавляется их сумма";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BestScoreLabel
            // 
            BestScoreLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BestScoreLabel.Location = new Point(0, 9);
            BestScoreLabel.Name = "BestScoreLabel";
            BestScoreLabel.Size = new Size(282, 50);
            BestScoreLabel.TabIndex = 3;
            BestScoreLabel.Text = "Рекорд: 0";
            BestScoreLabel.TextAlign = ContentAlignment.BottomCenter;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 323);
            Controls.Add(BestScoreLabel);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "MenuForm";
            Text = "Menu";
            Load += MenuForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label BestScoreLabel;
    }
}