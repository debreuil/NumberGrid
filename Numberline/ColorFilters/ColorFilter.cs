using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DDW.Numberline
{
    public class ColorFilter
    {
        private int gridWidth;
        private int gridHeight;

        public ColorFilter(int gridWidth, int gridHeight)
        {
            this.gridWidth = gridWidth;
            this.gridHeight = gridHeight;
        }

        public virtual void GetColor(double xUnitSize, int xSlot, int xTotalSlots, ref PixelData pd)
        {
        }

        public static PixelData white = new PixelData(0xFF, 0xFF, 0xFF);
        public static PixelData lightGrey = new PixelData(0xAA, 0xAA, 0xAA);
        public static PixelData darkGrey = new PixelData(0x44, 0x44, 0x44);
        public static PixelData black = new PixelData(0x00, 0x00, 0x00);

        public static PixelData red = new PixelData(0xFF, 0x00, 0x00);
        public static PixelData yellow = new PixelData(0xFF, 0xFF, 0x00);
        public static PixelData green = new PixelData(0x00, 0xFF, 0x00);
        public static PixelData cyan = new PixelData(0x00, 0xFF, 0xFF);
        public static PixelData blue = new PixelData(0x00, 0x00, 0xFF);
        public static PixelData magenta = new PixelData(0xFF, 0x00, 0xFF);

        public static List<PixelData> colors = new List<PixelData>()
        {
            new PixelData(160,138,181),
            new PixelData(72,222,54),
            new PixelData(232,67,33),
            new PixelData(49,85,35),
            new PixelData(235,47,202),
            new PixelData(227,194,52),
            new PixelData(97,232,185),
            new PixelData(77,25,43),
            new PixelData(226,55,117),
            new PixelData(95,114,227),
            new PixelData(224,145,90),
            new PixelData(109,200,218),
            new PixelData(187,204,127),
            new PixelData(126,53,136),
            new PixelData(40,67,90),
            new PixelData(221,135,234),
            new PixelData(102,55,21),
            new PixelData(228,160,153),
            new PixelData(99,172,44),
            new PixelData(92,161,227),
            new PixelData(81,158,112),
            new PixelData(153,44,68),
            new PixelData(202,226,50),
            new PixelData(151,115,32),
            new PixelData(47,49,105),
            new PixelData(102,226,113),
            new PixelData(233,108,172),
            new PixelData(168,42,33),
            new PixelData(165,211,171),
            new PixelData(70,124,147),
            new PixelData(31,56,48),
            new PixelData(217,119,34),
            new PixelData(84,108,184),
            new PixelData(187,220,99),
            new PixelData(227,154,212),
            new PixelData(184,95,228),
            new PixelData(220,104,126),
            new PixelData(221,56,81),
            new PixelData(223,189,213),
            new PixelData(115,135,83),
            new PixelData(91,81,30),
            new PixelData(167,160,49),
            new PixelData(82,23,73),
            new PixelData(71,134,47),
            new PixelData(84,184,166),
            new PixelData(179,103,146),
            new PixelData(167,83,32),
            new PixelData(225,124,108),
            new PixelData(151,104,62),
            new PixelData(168,153,227),
            new PixelData(103,24,25),
            new PixelData(173,192,205),
            new PixelData(85,191,116),
            new PixelData(229,98,72),
            new PixelData(90,68,101),
            new PixelData(175,52,109),
            new PixelData(92,78,173),
            new PixelData(116,123,42),
            new PixelData(174,108,102),
            new PixelData(61,101,101),
            new PixelData(171,108,185),
            new PixelData(155,119,137),
            new PixelData(123,70,83),
            new PixelData(234,166,47),
            new PixelData(164,65,176),
            new PixelData(218,195,108),
            new PixelData(61,29,20),
            new PixelData(172,233,149),
            new PixelData(47,51,22),
            new PixelData(94,143,237),
            new PixelData(224,57,149),
            new PixelData(46,29,63),
            new PixelData(230,145,173),
            new PixelData(103,90,146),
            new PixelData(49,44,55),
            new PixelData(204,162,102),
            new PixelData(146,189,232),
            new PixelData(223,78,234),
            new PixelData(64,119,95),
            new PixelData(162,73,64),
            new PixelData(213,102,191),
            new PixelData(130,63,113),
            new PixelData(125,33,79),
            new PixelData(143,233,63),
            new PixelData(103,65,52),
            new PixelData(236,108,227),
            new PixelData(169,126,229),
            new PixelData(160,44,130),
            new PixelData(90,154,151),
            new PixelData(126,232,229),
            new PixelData(201,182,234),
            new PixelData(219,216,80),
            new PixelData(78,156,198),
            new PixelData(139,100,230),
            new PixelData(45,77,128),
            new PixelData(58,121,182),
            new PixelData(215,59,179),
            new PixelData(108,118,145),
            new PixelData(88,48,118),
            new PixelData(130,97,166)
        };
    }
}
