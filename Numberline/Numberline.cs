using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace DDW.Numberline
{
    public class Numberline
    {
        private UnsafeBitmap bmp;
        private int gridWidth = 1024;
        private int gridHeight = 1024;
        private DisplayState displayState = DisplayState.None;
        private ColorFilter colorFilter;

        public Numberline()
        {
            bmp = new UnsafeBitmap(gridWidth, gridHeight);
        }

        public void SetState(DisplayState state)
        {
            if (displayState != state)
            {
                displayState = state;
                switch (displayState)
                {
                    case DisplayState.Full:
                        colorFilter = new ColorFilter(gridWidth, gridHeight);
                        break;
                    case DisplayState.StepsFromEdge:
                        colorFilter = new ColorFilterStepsFromEdge(gridWidth, gridHeight);
                        break;
                    case DisplayState.LightColumns:
                        break;
                    case DisplayState.EvenOnly:
                        colorFilter = new ColorFilterEvenOnly(gridWidth, gridHeight);
                        break;
                    case DisplayState.UniqueX:
                        colorFilter = new ColorFilterUniqueX(gridWidth, gridHeight);
                        break;
                }
                Redraw();
            }
        }

        private void Redraw()
        {
            Dictionary<double, int> dict = new Dictionary<double, int>();

            bmp.LockBitmap();
            //bmp.Clear(ColorFilter.white);
            bmp.Clear(ColorFilter.black);
            for (int y = 1; y < gridHeight; y++)
            {
                double xUnitSize = gridWidth / (double)y;
                int totalSlots = y;
                for (int x = 0; x < totalSlots; x++)
                {
                    PixelData pd = new PixelData(0xFF, 0xFF, 0xFF);
                    colorFilter.GetColor(xUnitSize, x, totalSlots, ref pd);
                    int xp = (int)Math.Round(x * xUnitSize);
                    bmp.SetPixel(xp, y, pd);

                    //double gridX =Math.Round(x * ratio * 10);
                    //if (!dict.ContainsKey(gridX))// && dict.Count < colors.Count)
                    //{
                    //    dict.Add(gridX, dict.Count);
                    //    isNew = true;
                    //}


                    //int slot = 1;
                    //double left = y - x;
                    //int b = left % 8 != slot ? 255 : 0;
                    //int r = x % 8 != slot ? 255 : 0;
                    //int g = x % 32 != slot ? (left % 32 != slot ? 255 : 0) : 0;
                    //pd = new PixelData(r, g, b);

                }
            }
            bmp.UnlockBitmap();
            bmp.Bitmap.Save("test.png");
        }

        public Image Bitmap
        {
            get
            {
                return bmp.Bitmap;
            }
        }
    }
}
