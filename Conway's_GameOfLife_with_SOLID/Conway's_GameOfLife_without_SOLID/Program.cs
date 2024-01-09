using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conway_s_GameOfLife_without_SOLID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = 20;
            int cols = 40;
            int generations = 50;

            Grid grid = new Grid(rows, cols);

            GameOfLife game = new GameOfLife(grid, generations);
            game.RunGame();

            Console.ReadKey();
        }
    }
}
