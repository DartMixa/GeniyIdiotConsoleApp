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
            SizeGridNumericUpDown = new NumericUpDown();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)SizeGridNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(12, 127);
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
            button2.Location = new Point(12, 312);
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
            label1.Location = new Point(0, 180);
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
            // SizeGridNumericUpDown
            // 
            SizeGridNumericUpDown.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SizeGridNumericUpDown.Location = new Point(209, 67);
            SizeGridNumericUpDown.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
            SizeGridNumericUpDown.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            SizeGridNumericUpDown.Name = "SizeGridNumericUpDown";
            SizeGridNumericUpDown.Size = new Size(63, 43);
            SizeGridNumericUpDown.TabIndex = 4;
            SizeGridNumericUpDown.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 67);
            label2.Name = "label2";
            label2.Size = new Size(177, 37);
            label2.TabIndex = 5;
            label2.Text = "Размер Поля";
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 369);
            Controls.Add(label2);
            Controls.Add(SizeGridNumericUpDown);
            Controls.Add(BestScoreLabel);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "MenuForm";
            Text = "Menu";
            Load += MenuForm_Load;
            ((System.ComponentModel.ISupportInitialize)SizeGridNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label BestScoreLabel;
        private NumericUpDown SizeGridNumericUpDown;
        private Label label2;
    }
}