using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatchMe
{
    public partial class MainForm : Form
    {
        public List<Ball> balls = [];
        public Graphics graphics;

        Bitmap buffer;
        public Graphics bufferGraphics;

        public MainForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.UserPaint |
              ControlStyles.AllPaintingInWmPaint |
              ControlStyles.ResizeRedraw |
              ControlStyles.ContainerControl |
              ControlStyles.OptimizedDoubleBuffer |
              ControlStyles.SupportsTransparentBackColor
              , true);
            UpdateTimer.Start();
            graphics = CreateGraphics();
            buffer = new(ClientSize.Width, ClientSize.Height);
            bufferGraphics = Graphics.FromImage(buffer);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                balls.Add(new RandomVelBoll(this));
            }
        }

        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            //balls.Add(new PointBall(this, e.X, e.Y));
        }
        public void Clear()
        {
            bufferGraphics.Clear(Color.White);
        }

        private void Update(object sender, EventArgs e)
        {
            Clear();
            int i = 0;
            while (i < balls.Count)
            {
                var ball = balls[i];
                if (!ball.IsOnForm())
                {
                    ball.Kill();
                }
                i++;
            }
            foreach (var ball in balls)
            {

                ball.Go();
                ball.Draw();
            }

            graphics.DrawImage(buffer, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateTimer.Enabled = false;
            label1.Text = "Поймано шариков: " + Convert.ToString(balls.Count);
        }
    }
}
