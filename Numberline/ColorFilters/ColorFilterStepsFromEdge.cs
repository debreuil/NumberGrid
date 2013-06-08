using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DDW.Numberline
{
    public class ColorFilterStepsFromEdge : ColorFilter
    {
        private bool showColums = true;
        private int columnCount = 4;
        private int slotToShow = 1;
        private int showEvery = 8;
        private int highlightEvery = 32;

        PixelData off = new PixelData(0x20, 0x00, 0x00);

        public ColorFilterStepsFromEdge(int gridWidth, int gridHeight) : base(gridWidth, gridHeight)
        {
        }

        public override void GetColor(double xUnitSize, int xSlot, int xTotalSlots, ref PixelData pd)
        {
            double left = xTotalSlots - xSlot;
            int b = left % showEvery != slotToShow ? 0xFF : 0;
            int r = xSlot % showEvery != slotToShow ? 0xFF : 0;
            int g = xSlot % highlightEvery != slotToShow ? (left % highlightEvery != slotToShow ? 0xFF : 0) : 0;

            pd.ChangeTo(r, g, b);
        }
    }
}
