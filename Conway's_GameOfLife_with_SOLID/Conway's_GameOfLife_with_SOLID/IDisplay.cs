using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conway_s_GameOfLife_with_SOLID
{
    // Interface for displaying the grid
    public interface IDisplay
    {
        void ClearConsole();
        void PrintGrid(IGrid grid);
    }
}
