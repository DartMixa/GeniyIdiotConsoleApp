using System.CodeDom.Compiler;
using System.Diagnostics.CodeAnalysis;
using System.ComponentModel;

namespace _2048WinFormsApp
{
    public partial class GameForm : Form
    {
        private Grid grid;
        private int score = 0;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int Score
        {
            get { return score; }
            set 
            { 
                score = value;
                ScoreLabel.Text = "Ñ÷¸ò: " + score.ToString();
            }
        }
        public GameForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Score = 0;
            GenerateGrid(4);
            grid.SetRandomPos(2);
            GeneratePosScoreLabel();
        }
        private void GeneratePosScoreLabel(int UpperMargin = 100)
        {
            ScoreLabel.Size = new System.Drawing.Size(this.Size.Width, 50);
            ScoreLabel.Location = new System.Drawing.Point(0, (UpperMargin - 50) / 2);
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
                grid.SetRandomPos(2);
            }
            else 
            {
                Close();
            }
        }
    }
}
