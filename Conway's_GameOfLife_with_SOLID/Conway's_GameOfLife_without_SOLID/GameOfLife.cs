using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Conway_s_GameOfLife_without_SOLID
{
    public class GameOfLife
    {
        private Grid grid;
        private readonly int generations;

        public GameOfLife(Grid grid, int generations)
        {
            this.grid = grid;
            this.generations = generations;
        }

        public void RunGame()
        {
            grid.InitializeRandomGrid();

            for (int gen = 0; gen < generations; gen++)
            {
                ClearConsole();
                PrintGrid(grid);

                int[,] newGrid = new int[grid.GetRows(), grid.GetCols()];

                for (int i = 0; i < grid.GetRows(); i++)
                {
                    for (int j = 0; j < grid.GetCols(); j++)
                    {
                        int neighbors = GetNeighborCount(grid, i, j);
                        if (grid.GetCellValue(i, j) == 1 && (neighbors < 2 || neighbors > 3))
                        {
                            newGrid[i, j] = 0;
                        }
                        else if (grid.GetCellValue(i, j) == 0 && neighbors == 3)
                        {
                            newGrid[i, j] = 1;
                        }
                        else
                        {
                            newGrid[i, j] = grid.GetCellValue(i, j);
                        }
                    }
                }

                for (int i = 0; i < grid.GetRows(); i++)
                {
                    for (int j = 0; j < grid.GetCols(); j++)
                    {
                        grid.SetCellValue(i, j, newGrid[i, j]);
                    }
                }

                Thread.Sleep(100);
            }
        }

        private void ClearConsole() => Console.Clear();

        private void PrintGrid(Grid grid)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            for (int i = 0; i < grid.GetRows(); i++)
            {
                for (int j = 0; j < grid.GetCols(); j++)
                {
                    Console.Write(grid.GetCellValue(i, j) == 1 ? "█" : " ");
                }
                Console.WriteLine();
            }
            Console.ResetColor();
        }

        private int GetNeighborCount(Grid grid, int x, int y)
        {
            int count = 0;
            int rows = grid.GetRows();
            int cols = grid.GetCols();

            for (int i = x - 1; i <= x + 1; i++)
            {
                for (int j = y - 1; j <= y + 1; j++)
                {
                    if (i >= 0 && i < rows && j >= 0 && j < cols && !(i == x && j == y))
                    {
                        count += grid.GetCellValue(i, j);
                    }
                }
            }
            return count;
        }
    }
}
