using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conway_s_GameOfLife_with_SOLID
{
    // Interface for applying rules
    public interface IRules
    {
        int GetNeighborCount(IGrid grid, int x, int y);
    }
}
