using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DDW.Numberline
{
    public class ColorFilterUniqueX : ColorFilter
    {
        Dictionary<int, int> set = new Dictionary<int, int>();

        public ColorFilterUniqueX(int gridWidth, int gridHeight) : base(gridWidth, gridHeight)
        {
        }

        public override void GetColor(double xUnitSize, int xSlot, int xTotalSlots, ref PixelData pd)
        {
            double x = xSlot * xUnitSize;
            //double above = sortedSet.Where(val => val >= x).FirstOrDefault();
            //double below = sortedSet.Where(val => val < x).FirstOrDefault();
            //double difAbove = Math.Abs(above - x);
            //double difBelow = Math.Abs(below - x);
            //double minDif = Math.Min(difAbove, difBelow);
            int pixelX = (int)x;
            bool isNew = !set.ContainsKey(pixelX);
            if (isNew)
            {
                set.Add(pixelX, 1);
            }
            else
            {
                int count = set[pixelX];
                set[pixelX] = count + 1;
                int difVal = (int)(Math.Abs((int)x - x) * 256);
                int g = (int)(xTotalSlots / (double)count * 0x80) % 0xFF;
                pd.ChangeTo(difVal, (int)(difVal / 2.0), (int)(g * 0.7));
            }
        }
    }
}
