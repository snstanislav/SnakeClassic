using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SnakeClassic.BLL
{
    class LocationPoint
    {
        public int X { get; set; }
        public int Y { get; set; }

        public LocationPoint(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
