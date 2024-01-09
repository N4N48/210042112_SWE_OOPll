using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conway_s_GameOfLife_with_SOLID
{
    // Rules class implementing IRules
    public class Rules:IRules
    {
        public int GetNeighborCount(IGrid grid, int x, int y)
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
