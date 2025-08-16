using SnakeClassic.BLL;

namespace SnakeClassic.Tests
{
    public class TestFood
    {
        [Theory]
        [InlineData(0, 200, 1)]
        [InlineData(0, 200, 2)]
        [InlineData(0, 200, 5)]
        [InlineData(0, 200, 10)]
        [InlineData(0, 200, 20)]
        [InlineData(0, 200, 30)]
        [InlineData(0, 200, 40)]
        [InlineData(0, 200, 50)]
        [InlineData(0, 200, 80)]
        [InlineData(0, 200, 100)]
        public void TestResultRange_GenerateNewFoodLocation(int borderCoordStart, int borderCoordEnd, int cellStepSize)
        {
            // int top, int bottom, int left, int right, int singleSellSize
            var food = new Food(borderCoordStart, borderCoordEnd, borderCoordStart, borderCoordEnd, cellStepSize);

            Assert.InRange(food.Location.X, borderCoordStart, borderCoordEnd - cellStepSize);
            Assert.InRange(food.Location.Y, borderCoordStart, borderCoordEnd - cellStepSize);

            Assert.Equal(0, food.Location.X % cellStepSize);
            Assert.Equal(0, food.Location.Y % cellStepSize);
        }
    }
}