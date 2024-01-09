using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Conway_s_GameOfLife_with_SOLID
{
    // GameOfLife class with SRP, OCP
    public class GameOfLife
    {
        private IGrid grid;
        private IDisplay display;
        private IRules rules;

        public GameOfLife(IGrid grid, IDisplay display, IRules rules)
        {
            this.grid = grid;
            this.display = display;
            this.rules = rules;
        }

        public void RunGame(int generations)
        {
            grid.InitializeRandomGrid();

            for (int gen = 0; gen < generations; gen++)
            {
                display.ClearConsole();
                display.PrintGrid(grid);

                int[,] newGrid = new int[grid.GetRows(), grid.GetCols()];

                for (int i = 0; i < grid.GetRows(); i++)
                {
                    for (int j = 0; j < grid.GetCols(); j++)
                    {
                        int neighbors = rules.GetNeighborCount(grid, i, j);
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
    }
}
