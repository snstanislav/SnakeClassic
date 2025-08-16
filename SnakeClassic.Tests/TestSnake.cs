using SnakeClassic.BLL;
using System.Runtime.CompilerServices;

namespace SnakeClassic.Tests
{
    public class TestSnake
    {
        [Fact]
        public void Test_SnakeInitLength()
        {
            // int initLength, int initX, int initY, int singleSellSize
            var snake = new Snake(5, 148, 333, 30);
            Assert.Equal(5, snake.SnakeBody.Count);

            snake = new Snake(7, 150, 210, 20);
            Assert.Equal(7, snake.SnakeBody.Count);

            snake = new Snake(444, 500, 500, 50);
            Assert.Equal(444, snake.SnakeBody.Count);
        }

        [Fact]
        public void Test_SnakeHead()
        {
            int headX = 190;
            int headY = 260;
            int stepSize = 30;
            var snake = new Snake(5, headX, headY, stepSize);
            Assert.Equal(headX, snake.SnakeBody[0].X);
            Assert.Equal(headY, snake.SnakeBody[0].Y);

            headX = 77;
            headY = 333;
            stepSize = 99;
            snake = new Snake(5, headX, headY, stepSize);
            Assert.Equal(headX, snake.SnakeBody[0].X);
            Assert.Equal(headY, snake.SnakeBody[0].Y);
        }

        [Fact]
        public void Test_SnakeSegmentsStep()
        {
            int headX = 190;
            int headY = 260;
            int stepSize = 30;
            var snake = new Snake(5, headX, headY, stepSize);
            Assert.Equal(stepSize, snake.SnakeBody[1].Y - snake.SnakeBody[0].Y);

            headX = 77;
            headY = 333;
            stepSize = 99;
            snake = new Snake(5, headX, headY, stepSize);
            Assert.Equal(stepSize, snake.SnakeBody[1].Y - snake.SnakeBody[0].Y);
        }

        [Fact]
        public void Test_SnakeOneStepUp()
        {
            var snake = new Snake(3, 400, 400, 20);
            var oldBodyPosition = snake.SnakeBody.Select(p => new LocationPoint(p.X, p.Y)).ToList();
            snake.MakeOneStepUp();
            Assert.Equal(snake.SnakeBody[0].Y, oldBodyPosition[0].Y - snake.SingleSellSize);

            snake = new Snake(7, 100, 200, 30);
            oldBodyPosition = snake.SnakeBody.Select(p => new LocationPoint(p.X, p.Y)).ToList();
            snake.MakeOneStepUp();
            Assert.Equal(snake.SnakeBody[0].Y, oldBodyPosition[0].Y - snake.SingleSellSize);

            snake = new Snake(144, 100, 200, 100);
            oldBodyPosition = snake.SnakeBody.Select(p => new LocationPoint(p.X, p.Y)).ToList();
            snake.MakeOneStepUp();
            Assert.Equal(snake.SnakeBody[0].Y, oldBodyPosition[0].Y - snake.SingleSellSize);
        }

        [Fact]
        public void Test_SnakeOneStepDown()
        {
            var snake = new Snake(3, 400, 400, 20);
            var oldBodyPosition = snake.SnakeBody.Select(p => new LocationPoint(p.X, p.Y)).ToList();
            snake.MakeOneStepDown();
            Assert.Equal(snake.SnakeBody[0].Y, oldBodyPosition[0].Y + snake.SingleSellSize);

            snake = new Snake(7, 100, 200, 30);
            oldBodyPosition = snake.SnakeBody.Select(p => new LocationPoint(p.X, p.Y)).ToList();
            snake.MakeOneStepDown();
            Assert.Equal(snake.SnakeBody[0].Y, oldBodyPosition[0].Y + snake.SingleSellSize);

            snake = new Snake(144, 100, 200, 100);
            oldBodyPosition = snake.SnakeBody.Select(p => new LocationPoint(p.X, p.Y)).ToList();
            snake.MakeOneStepDown();
            Assert.Equal(snake.SnakeBody[0].Y, oldBodyPosition[0].Y + snake.SingleSellSize);
        }

        [Fact]
        public void Test_SnakeOneStepLeft()
        {
            var snake = new Snake(3, 400, 400, 20);
            var oldBodyPosition = snake.SnakeBody.Select(p => new LocationPoint(p.X, p.Y)).ToList();
            snake.MakeOneStepLeft();
            Assert.Equal(snake.SnakeBody[0].X, oldBodyPosition[0].X - snake.SingleSellSize);

            snake = new Snake(7, 100, 200, 30);
            oldBodyPosition = snake.SnakeBody.Select(p => new LocationPoint(p.X, p.Y)).ToList();
            snake.MakeOneStepLeft();
            Assert.Equal(snake.SnakeBody[0].X, oldBodyPosition[0].X - snake.SingleSellSize);

            snake = new Snake(144, 100, 200, 100);
            oldBodyPosition = snake.SnakeBody.Select(p => new LocationPoint(p.X, p.Y)).ToList();
            snake.MakeOneStepLeft();
            Assert.Equal(snake.SnakeBody[0].X, oldBodyPosition[0].X - snake.SingleSellSize);
        }

        [Fact]
        public void Test_SnakeOneStepRight()
        {
            var snake = new Snake(3, 400, 400, 20);
            var oldBodyPosition = snake.SnakeBody.Select(p => new LocationPoint(p.X, p.Y)).ToList();
            snake.MakeOneStepRight();
            Assert.Equal(snake.SnakeBody[0].X, oldBodyPosition[0].X + snake.SingleSellSize);

            snake = new Snake(7, 100, 200, 30);
            oldBodyPosition = snake.SnakeBody.Select(p => new LocationPoint(p.X, p.Y)).ToList();
            snake.MakeOneStepRight();
            Assert.Equal(snake.SnakeBody[0].X, oldBodyPosition[0].X + snake.SingleSellSize);

            snake = new Snake(144, 100, 200, 100);
            oldBodyPosition = snake.SnakeBody.Select(p => new LocationPoint(p.X, p.Y)).ToList();
            snake.MakeOneStepRight();
            Assert.Equal(snake.SnakeBody[0].X, oldBodyPosition[0].X + snake.SingleSellSize);
        }

        [Theory]
        [InlineData(4, 5)]
        [InlineData(100, 101)]
        [InlineData(1111, 1112)]
        public void Test_GrowSnake(int initSize, int expectedSize)
        {
            var snake = new Snake(initSize, 133, 244, 55);
            snake.GrowSnake();
            Assert.Equal(expectedSize, snake.SnakeBody.Count);
        }

        [Theory]
        [InlineData(4, 20, 0)]
        [InlineData(100, 53, 0)]
        [InlineData(1111, 333, 0)]
        public void TestTail_GrowSnake(int initSize, int cellSize, int expected)
        {
            var snake = new Snake(initSize, 133, 244, cellSize);
            snake.GrowSnake();
            int tailX = snake.SnakeBody[snake.SnakeBody.Count - 1].X;
            int tailY = snake.SnakeBody[snake.SnakeBody.Count - 1].Y;
            int prevTailX = snake.SnakeBody[snake.SnakeBody.Count - 2].X;
            int prevTailY = snake.SnakeBody[snake.SnakeBody.Count - 2].Y;
            Assert.Equal(expected, tailX - prevTailX - cellSize);
            Assert.Equal(expected, tailY - prevTailY - cellSize);
        }

        [Fact]
        public void Test_IsSelfCollided()
        {
            var snake = new Snake(10, 100, 100, 20); // Init snake with random body
            // Create a snake body imitating a self-collision
            snake.SnakeBody[0] = new LocationPoint(100, 100); // Head
            snake.SnakeBody[1] = new LocationPoint(120, 100);
            snake.SnakeBody[2] = new LocationPoint(140, 100);
            snake.SnakeBody[3] = new LocationPoint(160, 100);
            snake.SnakeBody[4] = new LocationPoint(160, 120);
            snake.SnakeBody[5] = new LocationPoint(140, 120);
            snake.SnakeBody[6] = new LocationPoint(120, 120);
            snake.SnakeBody[7] = new LocationPoint(100, 120);
            snake.SnakeBody[8] = new LocationPoint(100, 100);
            snake.SnakeBody[9] = new LocationPoint(100, 80); // Tail
            
            Assert.True(snake.IsSelfCollided());
        }

        [Fact]
        public void Test_IsFoodCatched()
        {
            int headAndFoodX = 100;
            int headAndFoodY = 100;
            var snake = new Snake(5, headAndFoodX, headAndFoodY, 20);
            // Initialization
            // this.snakeBody.Add(new LocationPoint(initX, initY + i * singleSellSize));
            // [{100,100}, {100,120}, {100,140}, {100,150}, {100,160}]
            // CHeck if body was properly initialized in constructor
            for (int i = 0; i < snake.SnakeBody.Count; i++)
            {
                Assert.Equal(100, snake.SnakeBody[i].X);
                Assert.Equal(100 + i * 20, snake.SnakeBody[i].Y);
            }

            var food = new Food(0, 555, 0, 333, 20); // Food is initialized with random location
            food.Location = new LocationPoint(headAndFoodX, headAndFoodY);
            Assert.True(snake.IsFoodCatched(food.Location));

            food.Location = new LocationPoint(headAndFoodX + 77, headAndFoodY + 55);
            Assert.False(snake.IsFoodCatched(food.Location));
        }

        [Fact]
        public void Test_IsNewFoodAppearsOnSnakeBody()
        {
            // Initialization
            var snake = new Snake(5, 100, 100, 20);
            // this.snakeBody.Add(new LocationPoint(initX, initY + i * singleSellSize));
            // [{100,100}, {100,120}, {100,140}, {100,150}, {100,160}]
            // CHeck if body was properly initialized in constructor
            for (int i = 0; i < snake.SnakeBody.Count; i++)
            {
                Assert.Equal(100, snake.SnakeBody[i].X);
                Assert.Equal(100 + i * 20, snake.SnakeBody[i].Y);
            }

            var food = new Food(0, 555, 0, 333, 20); // Food is initialized with random location
            food.Location = new LocationPoint(100, 100);
            Assert.True(snake.IsNewFoodAppearsOnSnakeBody(food.Location));

            food.Location = new LocationPoint(100, 140);
            Assert.True(snake.IsNewFoodAppearsOnSnakeBody(food.Location));

            food.Location = new LocationPoint(100, 160);
            Assert.True(snake.IsNewFoodAppearsOnSnakeBody(food.Location));

            food.Location = new LocationPoint(90, 100);
            Assert.False(snake.IsNewFoodAppearsOnSnakeBody(food.Location));

            food.Location = new LocationPoint(100, 170);
            Assert.False(snake.IsNewFoodAppearsOnSnakeBody(food.Location));

            food.Location = new LocationPoint(110, 160);
            Assert.False(snake.IsNewFoodAppearsOnSnakeBody(food.Location));
        }
    }
}
