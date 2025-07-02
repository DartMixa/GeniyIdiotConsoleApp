using CatchMe;
using System;
using System.Drawing;
using System.ComponentModel;

namespace CatchMe2
{
    public partial class MainForm : Form
    {
        public List<Ball> balls = [];
        public List<Ball> particles = [];
        public Graphics graphics;

        Bitmap buffer;
        public Graphics bufferGraphics;

        private int result = 0;
        public MainForm()
        {
            InitializeComponent();
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
                if (!ball.IsOnForm(this))
                {
                    ball.Kill();
                }
                i++;
            }
            foreach (var ball in balls)
            {
                ball.Go();
                ball.Draw(bufferGraphics);
            }
            i = 0;
            while (i < particles.Count)
            {
                var particle = particles[i];
                particle.Go();
                particle.Draw(bufferGraphics);
                i++;
            }
            bufferGraphics.DrawString("Поймано шариков: " + Convert.ToString(result), Font, Brushes.Black, 10, 10);
            graphics.DrawImage(buffer, 0, 0);
        }
        private void SpawnTimer_Tick(object sender, EventArgs e)
        {
            balls.Add(new BoomBall(balls, ClientSize.Width, ClientSize.Height));
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                balls.Add(new BoomBall(balls, ClientSize.Width, ClientSize.Height));
            }
        }
        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            int i = 0;
            while (i < balls.Count)
            {
                var ball = balls[i];
                if (ball.PointCollision(e.X, e.Y))
                {
                    var part = ((BoomBall)ball).Boom();
                    particles.AddRange(part);
                    foreach (var item in part)
                    {
                        item.balls = particles;
                    }
                    ball.Kill();
                    result += 1;
                }
                i++;
            }
        }
    }
}
