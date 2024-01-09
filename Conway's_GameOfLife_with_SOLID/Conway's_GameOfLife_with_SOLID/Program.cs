using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conway_s_GameOfLife_with_SOLID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = 20;
            int cols = 40;
            int generations = 50;

            IGrid grid = new ExtendedGrid(rows, cols); // Using the ExtendedGrid class
            IDisplay display = new Display();
            IRules rules = new Rules();

            GameOfLife game = new GameOfLife(grid, display, rules);
            game.RunGame(generations);
            Console.ReadKey();
        }
    }
}
