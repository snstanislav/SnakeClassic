using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SnakeClassic.BLL
{
    class Snake
    {
        private List<LocationPoint> snakeBody = new List<LocationPoint>();

        public List<LocationPoint> SnakeBody => snakeBody;
        public int InitLength { get; set; }
        public int SingleSellSize { get; set; }

        public Snake(int initLength, int initX, int initY, int singleSellSize)
        {
            this.InitLength = initLength;
            this.SingleSellSize = singleSellSize;
            for (int i = 0; i < initLength; i++)
            {
                this.snakeBody.Add(new LocationPoint(initX, initY + i * singleSellSize));
            }
        }

        public void MakeOneStepUp()
        {
            for (int i = this.snakeBody.Count - 1; i >= 1; --i)
            {
                this.snakeBody[i].Y = this.snakeBody[i - 1].Y;
                this.snakeBody[i].X = this.snakeBody[i - 1].X;
            }
            this.snakeBody[0].Y -= this.SingleSellSize;
        }

        public void MakeOneStepDown()
        {
            for (int i = this.snakeBody.Count - 1; i >= 1; --i)
            {
                this.snakeBody[i].Y = this.snakeBody[i - 1].Y;
                this.snakeBody[i].X = this.snakeBody[i - 1].X;
            }
            this.snakeBody[0].Y += this.SingleSellSize;
        }

        public void MakeOneStepLeft()
        {
            for (int i = this.snakeBody.Count - 1; i >= 1; --i)
            {
                this.snakeBody[i].X = this.snakeBody[i - 1].X;
                this.snakeBody[i].Y = this.snakeBody[i - 1].Y;
            }
            this.snakeBody[0].X -= this.SingleSellSize;
        }

        public void MakeOneStepRight()
        {
            for (int i = this.snakeBody.Count - 1; i >= 1; --i)
            {
                this.snakeBody[i].X = this.snakeBody[i - 1].X;
                this.snakeBody[i].Y = this.snakeBody[i - 1].Y;
            }
            this.snakeBody[0].X += this.SingleSellSize;
        }

        public void GrowSnake()
        {
            LocationPoint newTailPoint = new LocationPoint(
                this.snakeBody[this.snakeBody.Count - 1].X + this.SingleSellSize,
                this.snakeBody[this.snakeBody.Count - 1].Y + this.SingleSellSize);
            this.snakeBody.Add(newTailPoint);
        }

        public bool IsSelfCollided()
        {
            for (int j = 1; j < this.snakeBody.Count - 1; j++)
            {
                if (this.snakeBody[0].X == this.snakeBody[j].X &&
                    this.snakeBody[0].Y == this.snakeBody[j].Y)
                {
                    return true;
                }
            }
            return false;
        }
        public bool IsFoodCatched(LocationPoint foodLocation)
        {
            return this.snakeBody[0].X == foodLocation.X && this.snakeBody[0].Y == foodLocation.Y;
        }
            
        public bool IsNewFoodAppearsOnSnakeBody(LocationPoint foodLocation)
        {
            for (int i = 0; i < this.snakeBody.Count - 1; ++i)
            {
                if (this.snakeBody[i].X == foodLocation.X &&
                    this.snakeBody[i].Y == foodLocation.Y)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
