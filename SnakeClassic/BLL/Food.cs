using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SnakeClassic.BLL
{
    /// <summary>
    /// Class Food represents and models the food object.
    /// </summary>
    class Food
    {
        /// <summary>
        /// <value>Property <c>random</c>is used for generating new random food locations.</value>
        /// </summary>
        private Random random;

        /// <summary>
        /// <value>Property <c>Location</c> represents the point of the current food location.</value>
        /// </summary>
        public LocationPoint Location { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Food"/> class, random instance and default empty location. 
        /// Invokes GenerateNewFoodLocation method to set a new random location for the food object.
        /// </summary>
        /// <param name="top">The upper boundary of the current game panel in which the food can be placed.</param>
        /// <param name="bottom">The lower boundary of the current game panel in which the food can be placed.</param>
        /// <param name="left">The left boundary of the current game panel in which the food can be placed.</param>
        /// <param name="right">The right boundary of the current game panel in which the food can be placed.</param>
        /// <param name="singleSellSize">The size of a single cell of the food on the game panel.</param>
        public Food(int top, int bottom, int left, int right,
            int singleSellSize)
        {
            this.random = new Random();
            this.Location = new LocationPoint(0, 0);
            GenerateNewFoodLocation(top, bottom, left, right, singleSellSize);
        }

        /// <summary>
        /// Generates and assignes a new random location for the food within the specified boundaries.
        /// </summary>
        public void GenerateNewFoodLocation(int top, int bottom, int left, int right,
            int singleSellSize)
        {
            this.Location.X = Convert.ToInt32(random.Next(left, right - singleSellSize) / singleSellSize) * singleSellSize;
            this.Location.Y = Convert.ToInt32(random.Next(top, bottom - singleSellSize) / singleSellSize) * singleSellSize;
        }
    }
}