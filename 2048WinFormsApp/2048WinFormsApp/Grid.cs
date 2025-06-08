using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048WinFormsApp
{
    internal class Grid
    {
        public Label[,] grid;
        private int?[,] gridInt;
        private List<(int, int)> tempIndexList = [];
        private Random random = new Random();
        public int size;
        public bool IsFreePlace() 
        {
            return tempIndexList.Count != 0;
        }
        public Grid(int GredSize, int sep, int ButtonSize)
        {
            grid = new Label[GredSize, GredSize];
            gridInt = new int?[GredSize, GredSize];
            GenerateGrid(GredSize, sep, ButtonSize);
            size = GredSize;
        }
        public void SetRandomPos(int value)
        {
            int ind = random.Next(tempIndexList.Count);
            (int, int) val = tempIndexList[ind];
            this[val.Item1, val.Item2] = value;
        }
        private void GenerateGrid(int GredSize = 4, int sep = 20, int ButtonSize = 70, int UpperMargin = 100)
        {
            for (int i = 0; i < GredSize; i++)
            {
                for (int j = 0; j < GredSize; j++)
                {
                    var label = new Label();
                    SetColor(label);
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    label.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
                    label.Location = new Point(sep + i * (ButtonSize + sep), UpperMargin + sep + j * (ButtonSize + sep));
                    label.Size = new Size(ButtonSize, ButtonSize);
                    label.TabIndex = 0;
                    label.Enabled = false;
                    grid[i, j] = label;
                    tempIndexList.Add((i, j));
                }
            }
        }
        public int? this [int i, int j] 
        {
            get { return gridInt[i, j]; }
            set 
            {
                gridInt[i, j] = value;
                if (value is null)
                {
                    tempIndexList.Add((i, j));
                    grid[i, j].Text = "";
                    SetColor(grid[i, j]);
                }
                else
                {
                    if (tempIndexList.Contains((i, j)))
                    {
                        tempIndexList.Remove((i, j));
                    }
                    grid[i, j].Text = Convert.ToString(value);
                    SetColor(grid[i, j], (int)value);
                }
            }
        }
        static public void SetColor(Label cell, int value)
        {
            int lg = (int)Math.Log2(value);
            int col = 255 - lg * 40;
            cell.BackColor = Color.FromArgb(Math.Max(col, 0), 255 + (col > 0 ? 0 : col), 255 + (col > 0 ? 0 : col));
        }
        static public void SetColor(Label cell)
        {
            cell.BackColor = Color.FromArgb(255, 255, 255);
        }
    }
}
