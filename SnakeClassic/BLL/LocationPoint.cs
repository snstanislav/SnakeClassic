using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;

namespace SnakeClassic.BLL
{
    /// <summary>
    /// Class LocationPoint represents the basic entity of the application. 
    /// The class describes simple 2D-point with x and y coordinates.
    /// </summary>
    class LocationPoint
    {
        /// <summary>
        /// <value>Property <c>X</c> represents the point's x-coordinate.</value>
        /// </summary>
        public int X { get; set; }
        /// <summary>
        /// <value>Property <c>Y</c> represents the point's x-coordinate.</value>
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocationPoint"/> class with the specified coordinates.
        /// </summary>
        /// <param name="x">The x-coordinate of the new location point.</param>
        /// <param name="y">The y-coordinate of the new location point.</param>
        public LocationPoint(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
