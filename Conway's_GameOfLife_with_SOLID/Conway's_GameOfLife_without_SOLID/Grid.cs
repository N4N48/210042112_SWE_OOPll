using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conway_s_GameOfLife_without_SOLID
{
    public class Grid
    {
        private int[,] grid;
        private int rows;
        private int cols;
        private readonly Random rand = new Random();

        public Grid(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            this.grid = new int[rows, cols];
        }

        public void InitializeRandomGrid()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    grid[i, j] = rand.Next(2);
                }
            }
        }

        public int GetRows() => rows;
        public int GetCols() => cols;
        public int GetCellValue(int x, int y) => grid[x, y];
        public void SetCellValue(int x, int y, int value) => grid[x, y] = value;
    }
}
