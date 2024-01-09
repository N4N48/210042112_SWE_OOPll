using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conway_s_GameOfLife_with_SOLID
{
    // Interface for the grid representation
    public interface IGrid
    {
        int GetRows();
        int GetCols();
        int GetCellValue(int x, int y);
        void SetCellValue(int x, int y, int value);
        void InitializeRandomGrid();
    }
}
