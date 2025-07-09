namespace FruitNinja
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            UpdateTimer = new System.Windows.Forms.Timer(components);
            FruitSpawnTimer = new System.Windows.Forms.Timer(components);
            SlowdownTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // UpdateTimer
            // 
            UpdateTimer.Interval = 20;
            UpdateTimer.Tick += Update;
            // 
            // FruitSpawnTimer
            // 
            FruitSpawnTimer.Enabled = true;
            FruitSpawnTimer.Interval = 1500;
            FruitSpawnTimer.Tick += FruitSpawnTimer_Tick;
            // 
            // SlowdownTimer
            // 
            SlowdownTimer.Interval = 7000;
            SlowdownTimer.Tick += SlowdownTimer_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "MainForm";
            Text = " Fruit Ninja";
            MouseMove += MainForm_MouseMove;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer UpdateTimer;
        private System.Windows.Forms.Timer FruitSpawnTimer;
        private System.Windows.Forms.Timer SlowdownTimer;
    }
}
