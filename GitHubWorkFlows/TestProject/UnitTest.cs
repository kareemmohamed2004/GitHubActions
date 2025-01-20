namespace TestProject
{
    public class UnitTest
    {
        [Fact]
        public void AdditionTest()
        {
            Assert.Equal(3, 1 + 1);
        }

        [Fact]
        public void SubtractionTest()
        {
            Assert.Equal(0, 1 - 1);
        }

        [Fact]
        public void MultiplicationTest()
        {
            Assert.Equal(1, 1 * 1);
        }

        [Fact]
        public void DivisionTest()
        {
            Assert.Equal(1, 1 / 1);
        }
    }
}