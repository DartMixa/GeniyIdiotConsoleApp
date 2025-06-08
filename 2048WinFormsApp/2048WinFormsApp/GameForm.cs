using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using static System.Net.WebRequestMethods;

namespace _2048WinFormsApp
{
    public partial class GameForm : Form
    {
        private Grid grid;
        private Random random = new();
        private int size;
        private int score = 0;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int Score
        {
            get { return score; }
            set 
            { 
                score = value;
                if (score > BestScore) 
                {
                    BestScore = score;
                }
                ScoreLabel.Text = "—чЄт: " + score.ToString();
            }
        }
        private int bestScore = 0;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int BestScore
        {
            get { return bestScore; }
            set
            {
                bestScore = value;
                FileSystem.WriteFile("bestResult.txt", bestScore.ToString());
                BestScoreLabel.Text = "Ћучший –езультат: " + bestScore.ToString();
            }
        }
        public GameForm(int bestScore, int size = 4)
        {
            InitializeComponent();
            BestScore = bestScore;
            this.size = size;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Score = 0;
            GenerateGrid(size);
            FillRandomCell();
            GeneratePosScoreLabel();
        }
        private void GeneratePosScoreLabel()
        {
            ScoreLabel.Size = new System.Drawing.Size(this.Size.Width, 50);
            ScoreLabel.Location = new System.Drawing.Point(0, 0);

            BestScoreLabel.Size = new System.Drawing.Size(this.Size.Width, 50);
            BestScoreLabel.Location = new System.Drawing.Point(0, 50);
        }
        private void GenerateGrid(int GredSize = 4, int sep = 20, int ButtonSize = 60, int UpperMargin = 100)
        {
            grid = new Grid(GredSize, sep, ButtonSize);
            ClientSize = new Size(sep + GredSize * (ButtonSize + sep), UpperMargin + sep + GredSize * (ButtonSize + sep));
            for (int i = 0; i < GredSize; i++)
            {
                for (int j = 0; j < GredSize; j++)
                {
                    Controls.Add(grid.grid[i, j]);
                }
            }
        }
        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                for (int i = 0; i < grid.size; i++) 
                {
                    for (int j = 0; j < grid.size; j++)
                    {
                        if (grid[i, j] is not null)
                        {
                            for (int k = j - 1; k >= 0; k--)
                            {
                                if (grid[i, k] is not null) 
                                {
                                    if (grid[i, k] == grid[i, j])
                                    {
                                        grid[i, k] = grid[i, k] + grid[i, j];
                                        grid[i, j] = null;
                                        Score += (int)grid[i, k];
                                    }
                                    else 
                                    {
                                        grid[i, k + 1] = grid[i, j];
                                        if (k + 1 != j)
                                        {
                                            grid[i, j] = null;
                                        }
                                    }
                                    break;
                                }
                                if (k == 0)
                                {
                                    grid[i, k] = grid[i, j];
                                    grid[i, j] = null;
                                }
                            }
                        }
                    }
                }
            }
            if (e.KeyCode == Keys.Down)
            {
                for (int i = 0; i < grid.size; i++)
                {
                    for (int j = grid.size - 1; j >= 0; j--)
                    {
                        if (grid[i, j] is not null)
                        {
                            for (int k = j + 1; k < grid.size; k++)
                            {
                                if (grid[i, k] is not null)
                                {
                                    if (grid[i, k] == grid[i, j])
                                    {
                                        grid[i, k] = grid[i, k] + grid[i, j];
                                        grid[i, j] = null;
                                        Score += (int)grid[i, k];
                                    }
                                    else
                                    {
                                        grid[i, k - 1] = grid[i, j];
                                        if (k - 1 != j)
                                        {
                                            grid[i, j] = null;
                                        }
                                    }
                                    break;
                                }
                                if (k == grid.size - 1)
                                {
                                    grid[i, k] = grid[i, j];
                                    grid[i, j] = null;
                                }
                            }
                        }
                    }
                }
            }
            if (e.KeyCode == Keys.Right)
            {
                for (int i = 0; i < grid.size; i++)
                {
                    for (int j = grid.size - 1; j >= 0; j--)
                    {
                        if (grid[j, i] is not null)
                        {
                            for (int k = j + 1; k < grid.size; k++)
                            {
                                if (grid[k, i] is not null)
                                {
                                    if (grid[k, i] == grid[j, i])
                                    {
                                        grid[k, i] = grid[k, i] + grid[j, i];
                                        grid[j, i] = null;
                                        Score += (int)grid[k, i];
                                    }
                                    else
                                    {
                                        grid[k - 1, i] = grid[j, i];
                                        if (k - 1 != j)
                                        {
                                            grid[j, i] = null;
                                        }
                                    }
                                    break;
                                }
                                if (k == grid.size - 1)
                                {
                                    grid[k, i] = grid[j, i];
                                    grid[j, i] = null;
                                }
                            }
                        }
                    }
                }
            }
            if (e.KeyCode == Keys.Left)
            {
                for (int i = 0; i < grid.size; i++)
                {
                    for (int j = 0; j < grid.size; j++)
                    {
                        if (grid[j, i] is not null)
                        {
                            for (int k = j - 1; k >= 0; k--)
                            {
                                if (grid[k, i] is not null)
                                {
                                    if (grid[k, i] == grid[j, i])
                                    {
                                        grid[k, i] = grid[k, i] + grid[j, i];
                                        grid[j, i] = null;
                                        Score += (int)grid[k, i];
                                    }
                                    else
                                    {
                                        grid[k + 1, i] = grid[j, i];
                                        if (k + 1 != j)
                                        {
                                            grid[j, i] = null;
                                        }
                                    }
                                    break;
                                }
                                if (k == 0)
                                {
                                    grid[k, i] = grid[j, i];
                                    grid[j, i] = null;
                                }
                            }
                        }
                    }
                }
                
            }
            FillRandomCell();
        }
        private void FillRandomCell() 
        {
            if (grid.IsFreePlace())
            {
                int ver = random.Next(4);
                grid.SetRandomPos(ver >= 3 ? 4 : 2);
            }
            else 
            {
                Close();
            }
        }
    }
}
