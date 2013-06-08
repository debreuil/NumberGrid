using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DDW.Numberline
{
    public struct PixelData
    {
        public PixelData(int r, int g, int b)
        {
            this.red = (byte)r;
            this.green = (byte)g;
            this.blue = (byte)b;
        }
        public PixelData(byte r, byte g, byte b)
        {
            this.red = r;
            this.green = g;
            this.blue = b;
        }

        public void ChangeTo(byte r, byte g, byte b)
        {
            this.red = r;
            this.green = g;
            this.blue = b;
        }

        public void ChangeTo(int r, int g, int b)
        {
            this.red = (byte)r;
            this.green = (byte)g;
            this.blue = (byte)b;
        }

        public void ChangeTo(PixelData pd)
        {
            this.red = pd.red;
            this.green = pd.green;
            this.blue = pd.blue;
        }

        public byte blue;
        public byte green;
        public byte red;
    }
}
