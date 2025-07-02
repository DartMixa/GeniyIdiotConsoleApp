namespace CatchMe
{
    partial class MainForm
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
            button2 = new Button();
            UpdateTimer = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(650, 12);
            button2.Name = "button2";
            button2.Size = new Size(138, 40);
            button2.TabIndex = 1;
            button2.Text = "Рисовать случайный шарик";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // UpdateTimer
            // 
            UpdateTimer.Interval = 20;
            UpdateTimer.Tick += Update;
            // 
            // button1
            // 
            button1.Location = new Point(650, 58);
            button1.Name = "button1";
            button1.Size = new Size(138, 36);
            button1.TabIndex = 2;
            button1.Text = "Остановить всё";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(button2);
            Name = "MainForm";
            Text = "Мячики";
            MouseClick += MainForm_MouseClick;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private System.Windows.Forms.Timer UpdateTimer;
        private Button button1;
        private Label label1;
    }
}