using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SnakeClassic.BLL
{
    class Food
    {
        private Random random;
        public LocationPoint Location { get; set; }
        public Food(int top, int bottom, int left, int right,
            int singleSellSize)
        {
            this.random = new Random();
            this.Location = new LocationPoint(0, 0);
            GenerateNewFoodLocation(top, bottom, left, right, singleSellSize);
        }
        public void GenerateNewFoodLocation(int top, int bottom, int left, int right,
            int singleSellSize)
        {
            this.Location.X = Convert.ToInt32(random.Next(left, right - singleSellSize) / singleSellSize) * singleSellSize;
            this.Location.Y = Convert.ToInt32(random.Next(top, bottom - singleSellSize) / singleSellSize) * singleSellSize;
        }
    }
}