using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conway_s_GameOfLife_with_SOLID
{
    // Display class implementing IDisplay
    public class Display:IDisplay
    {
        public void ClearConsole() => Console.Clear();
        public void PrintGrid(IGrid grid)
        {
            for (int i = 0; i < grid.GetRows(); i++)
            {
                for (int j = 0; j < grid.GetCols(); j++)
                {
                    Console.Write(grid.GetCellValue(i, j) == 1 ? "█" : " ");
                }
                Console.WriteLine();
            }
        }

    }
}
