using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conway_s_GameOfLife_with_SOLID
{
    public class ExtendedGrid:Grid
    {
        public ExtendedGrid(int rows, int cols) : base(rows, cols)
        {
            // Additional functionality or changes specific to ExtendedGrid can be added here
        }

        // Overriding the SetCellValue method to provide a new behavior
        public override void SetCellValue(int x, int y, int value)
        {
            if (value != 0 && value != 1)
            {
                throw new ArgumentException("Cell value should be either 0 or 1.");
            }
            base.SetCellValue(x, y, value);
        }

    }
}
