using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SnakeClassic.BLL
{
    /// <summary>
    /// Represents a snake in a grid-based game, providing functionality for movement, growth, and collision detection.
    /// </summary>
    /// <remarks>The <see cref="Snake"/> class models the behavior of a snake in a game, including its body,
    /// movement, and interactions with food or itself. The snake's body is represented as a list of <see
    /// cref="LocationPoint"/> objects, where each point corresponds to a segment of the snake. Movement is performed by
    /// shifting the positions of the body segments, and the snake can grow by adding a new segment to its
    /// tail.</remarks>
    class Snake
    {
        private List<LocationPoint> snakeBody = new List<LocationPoint>();

        /// <summary>
        /// <value>Property <c>SnakeBody</c> represents the list of coordinates of the snake body segments.</value>
        /// </summary>
        public List<LocationPoint> SnakeBody => snakeBody;

        /// <summary>
        /// <value>Property <c>InitLength</c> gets and sets the initial length of the snake.
        /// </summary>
        public int InitLength { get; set; }

        /// <summary>
        /// <value>Property <c>SingleSellSize</c> represents the size of the single game field sell.
        /// </summary>
        public int SingleSellSize { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Snake"/> class with the specified initial length, starting position, and cell size.
        /// </summary>
        /// <param name="initLength">The initial length of the snake, represented as the number of segments.</param>
        /// <param name="initX">The x-coordinate of the starting position of the snake's head.</param>
        /// <param name="initY">The y-coordinate of the starting position of the snake's head.</param>
        /// <param name="singleSellSize">The size of a single game field sell.</param>
        public Snake(int initLength, int initX, int initY, int singleSellSize)
        {
            this.InitLength = initLength;
            this.SingleSellSize = singleSellSize;
            for (int i = 0; i < initLength; i++)
            {
                this.snakeBody.Add(new LocationPoint(initX, initY + i * singleSellSize));
            }
        }

        /// <summary>
        /// Moves the snake one step upward by updating the positions of its body segments.
        /// </summary>
        /// <remarks>The movement is based on the size of a single cell, as defined by <see cref="SingleSellSize"/>.</remarks>
        public void MakeOneStepUp()
        {
            for (int i = this.snakeBody.Count - 1; i >= 1; --i)
            {
                this.snakeBody[i].Y = this.snakeBody[i - 1].Y;
                this.snakeBody[i].X = this.snakeBody[i - 1].X;
            }
            this.snakeBody[0].Y -= this.SingleSellSize;
        }

        /// <summary>
        /// Moves the snake one step downward by updating the positions of its body segments.
        /// </summary>
        /// <remarks>The movement is based on the size of a single cell, as defined by <see cref="SingleSellSize"/>.</remarks>
        public void MakeOneStepDown()
        {
            for (int i = this.snakeBody.Count - 1; i >= 1; --i)
            {
                this.snakeBody[i].Y = this.snakeBody[i - 1].Y;
                this.snakeBody[i].X = this.snakeBody[i - 1].X;
            }
            this.snakeBody[0].Y += this.SingleSellSize;
        }

        /// <summary>
        /// Moves the snake one step to the left by updating the positions of its body segments.
        /// </summary>
        /// <remarks>The movement is based on the size of a single cell, as defined by <see cref="SingleSellSize"/>.</remarks>
        public void MakeOneStepLeft()
        {
            for (int i = this.snakeBody.Count - 1; i >= 1; --i)
            {
                this.snakeBody[i].X = this.snakeBody[i - 1].X;
                this.snakeBody[i].Y = this.snakeBody[i - 1].Y;
            }
            this.snakeBody[0].X -= this.SingleSellSize;
        }

        /// <summary>
        /// Moves the snake one step to the right by updating the positions of its body segments.
        /// </summary>
        /// <remarks>The movement is based on the size of a single cell, as defined by <see cref="SingleSellSize"/>.</remarks>
        public void MakeOneStepRight()
        {
            for (int i = this.snakeBody.Count - 1; i >= 1; --i)
            {
                this.snakeBody[i].X = this.snakeBody[i - 1].X;
                this.snakeBody[i].Y = this.snakeBody[i - 1].Y;
            }
            this.snakeBody[0].X += this.SingleSellSize;
        }

        /// <summary>
        /// Adds a new segment to the end of the snake, increasing its length by one unit.
        /// </summary>
        /// <remarks>The new segment is added based on the position of the current tail segment, offset by the size of a single cell.</remarks>
        public void GrowSnake()
        {
            LocationPoint newTailPoint = new LocationPoint(
                this.snakeBody[this.snakeBody.Count - 1].X + this.SingleSellSize,
                this.snakeBody[this.snakeBody.Count - 1].Y + this.SingleSellSize);
            this.snakeBody.Add(newTailPoint);
        }

        /// <summary>
        /// Determines whether the snake's head has collided with its own body.
        /// </summary>
        /// <returns><see langword="true"/> if the snake's head occupies the same position as any other part of its body;
        /// otherwise, <see langword="false"/>.</returns>
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

        /// <summary>
        /// Determines whether the snake's head has reached the specified food location.
        /// </summary>
        /// <param name="foodLocation">The location of the food to check, represented as a <see cref="LocationPoint"/>.</param>
        /// <returns><see langword="true"/> if the snake's head is at the same position as the specified food location; 
        /// otherwise, <see langword="false"/>.</returns>
        public bool IsFoodCatched(LocationPoint foodLocation)
        {
            return this.snakeBody[0].X == foodLocation.X && this.snakeBody[0].Y == foodLocation.Y;
        }
        
        /// <summary>
        /// Determines whether the specified food location overlaps with any part of the snake's body.
        /// </summary>
        /// <param name="foodLocation">The location of the food to check, represented as a <see cref="LocationPoint"/>.</param>
        /// <returns><see langword="true"/> if the food location coincides with any segment of the snake's body;  
        /// otherwise, <see langword="false"/>.</returns>
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
