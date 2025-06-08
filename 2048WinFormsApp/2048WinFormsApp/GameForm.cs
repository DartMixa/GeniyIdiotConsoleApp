using System.CodeDom.Compiler;
using System.Diagnostics.CodeAnalysis;
using System.ComponentModel;

namespace _2048WinFormsApp
{
    public partial class GameForm : Form
    {
        private Gred gred;
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
            gred.SetRandomPos(2);
            GeneratePosScoreLabel();
        }
        private void GeneratePosScoreLabel(int UpperMargin = 100)
        {
            ScoreLabel.Size = new System.Drawing.Size(this.Size.Width, 50);
            ScoreLabel.Location = new System.Drawing.Point(0, (UpperMargin - 50) / 2);
        }
        private void GenerateGrid(int GredSize = 4, int sep = 20, int ButtonSize = 60, int UpperMargin = 100)
        {
            gred = new Gred(GredSize, sep, ButtonSize);
            ClientSize = new Size(sep + GredSize * (ButtonSize + sep), UpperMargin + sep + GredSize * (ButtonSize + sep));
            for (int i = 0; i < GredSize; i++)
            {
                for (int j = 0; j < GredSize; j++)
                {
                    Controls.Add(gred.grid[i, j]);
                }
            }
        }
        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                for (int i = 0; i < gred.size; i++) 
                {
                    for (int j = 0; j < gred.size; j++)
                    {
                        if (gred[i, j] is not null)
                        {
                            for (int k = j - 1; k >= 0; k--)
                            {
                                if (gred[i, k] is not null) 
                                {
                                    if (gred[i, k] == gred[i, j])
                                    {
                                        gred[i, k] = gred[i, k] + gred[i, j];
                                        gred[i, j] = null;
                                        Score += (int)gred[i, k];
                                    }
                                    else 
                                    {
                                        gred[i, k + 1] = gred[i, j];
                                        if (k + 1 != j)
                                        {
                                            gred[i, j] = null;
                                        }
                                    }
                                    break;
                                }
                                if (k == 0)
                                {
                                    gred[i, k] = gred[i, j];
                                    gred[i, j] = null;
                                }
                            }
                        }
                    }
                }
                gred.SetRandomPos(2);
            }
            if (e.KeyCode == Keys.Down)
            {
                for (int i = 0; i < gred.size; i++)
                {
                    for (int j = gred.size - 1; j >= 0; j--)
                    {
                        if (gred[i, j] is not null)
                        {
                            for (int k = j + 1; k < gred.size; k++)
                            {
                                if (gred[i, k] is not null)
                                {
                                    if (gred[i, k] == gred[i, j])
                                    {
                                        gred[i, k] = gred[i, k] + gred[i, j];
                                        gred[i, j] = null;
                                        Score += (int)gred[i, k];
                                    }
                                    else
                                    {
                                        gred[i, k - 1] = gred[i, j];
                                        if (k - 1 != j)
                                        {
                                            gred[i, j] = null;
                                        }
                                    }
                                    break;
                                }
                                if (k == gred.size - 1)
                                {
                                    gred[i, k] = gred[i, j];
                                    gred[i, j] = null;
                                }
                            }
                        }
                    }
                }
                gred.SetRandomPos(2);
            }
            if (e.KeyCode == Keys.Right)
            {
                for (int i = 0; i < gred.size; i++)
                {
                    for (int j = gred.size - 1; j >= 0; j--)
                    {
                        if (gred[j, i] is not null)
                        {
                            for (int k = j + 1; k < gred.size; k++)
                            {
                                if (gred[k, i] is not null)
                                {
                                    if (gred[k, i] == gred[j, i])
                                    {
                                        gred[k, i] = gred[k, i] + gred[j, i];
                                        gred[j, i] = null;
                                        Score += (int)gred[k, i];
                                    }
                                    else
                                    {
                                        gred[k - 1, i] = gred[j, i];
                                        if (k - 1 != j)
                                        {
                                            gred[j, i] = null;
                                        }
                                    }
                                    break;
                                }
                                if (k == gred.size - 1)
                                {
                                    gred[k, i] = gred[j, i];
                                    gred[j, i] = null;
                                }
                            }
                        }
                    }
                }
                gred.SetRandomPos(2);
            }
            if (e.KeyCode == Keys.Left)
            {
                for (int i = 0; i < gred.size; i++)
                {
                    for (int j = 0; j < gred.size; j++)
                    {
                        if (gred[j, i] is not null)
                        {
                            for (int k = j - 1; k >= 0; k--)
                            {
                                if (gred[k, i] is not null)
                                {
                                    if (gred[k, i] == gred[j, i])
                                    {
                                        gred[k, i] = gred[k, i] + gred[j, i];
                                        gred[j, i] = null;
                                        Score += (int)gred[k, i];
                                    }
                                    else
                                    {
                                        gred[k + 1, i] = gred[j, i];
                                        if (k + 1 != j)
                                        {
                                            gred[j, i] = null;
                                        }
                                    }
                                    break;
                                }
                                if (k == 0)
                                {
                                    gred[k, i] = gred[j, i];
                                    gred[j, i] = null;
                                }
                            }
                        }
                    }
                }
                gred.SetRandomPos(2);
            }
        }
    }
}
