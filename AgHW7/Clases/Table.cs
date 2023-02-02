using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Point;



namespace AgHW7.Clases
{
    internal class Table
    {
        internal int Width;
        internal int Height;
        internal int Angle;
        public Point TopLeft;
        internal Point TopRight;
        private static int WidthMax = 3;
        private static int HeightMax = 3;
        private static int AriaMax = 6;
        private static Random Rnd = new Random();

        internal Table()
        {
            TopLeft++;
        }
    }
}
