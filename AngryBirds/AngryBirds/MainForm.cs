using System.DirectoryServices.ActiveDirectory;
using System.Net.NetworkInformation;
using System.Security.Cryptography;

namespace AngryBirds
{
    public partial class MainForm : Form
    {
        DrawGroup drawGroup = new();
        Bird bird;
        LineSight lineSight = new();
        DrawGroup PigGroup = new();


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

            drawGroup.AddObject(lineSight);

            MouseDown += lineSight.MainForm_MouseDown;
            MouseUp += lineSight.MainForm_MouseUp;
            MouseMove += lineSight.MainForm_MouseMove;

            var font = new Font("Segoe Print", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Text txt = new(0, 0, Brushes.Aqua, font, "Натяните и отпустите чтобы выстрелить");
            drawGroup.AddObject(txt);
        }
        public void Clear()
        {
            bufferGraphics.Clear(Color.White);
        }
        private void Update(object sender, EventArgs e)
        {
            drawGroup.Update();
            
            if (bird.BallsCollision(PigGroup, out var collision))
            {
                foreach (var pig in collision)
                {
                    pig.Kill();
                    SpawnPig();
                }
            }

            Clear();
            drawGroup.Draw(bufferGraphics);
            graphics.DrawImage(buffer, 0, 0);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SpawnBird();
            for (int i = 0; i < 5; i++)
            {
                SpawnPig();
            }
        }
        private void SpawnBird()
        {
            bird = new(this);
            bird.Death += BirdDeath;
            lineSight.Shot += bird.Shot;
            drawGroup.AddObject(bird);
        }
        private void SpawnPig()
        {
            var pig = new Pig(this);
            PigGroup.AddObject(pig);
            drawGroup.AddObject(pig);
        }
        private void BirdDeath(object? sender, EventArgs e) 
        {
            SpawnBird();
        }
    }
}
