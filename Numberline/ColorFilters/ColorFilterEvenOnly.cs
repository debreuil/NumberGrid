using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DDW.Numberline
{
    public class ColorFilterEvenOnly : ColorFilter
    {
        private double tolerance = 0.01;
        PixelData off = new PixelData(0x20, 0x00, 0x00);

        public ColorFilterEvenOnly(int gridWidth, int gridHeight) : base(gridWidth, gridHeight)
        {
        }

        public override void GetColor(double xUnitSize, int xSlot, int xTotalSlots, ref PixelData pd)
        {
            double dif = Math.Abs(xSlot * xUnitSize - (int)(xSlot * xUnitSize));
            if (dif > tolerance)
            {
                pd.ChangeTo(off);
            }
        }
    }
}
