using Tyuiu.MusinND.Sprint1.Task2.V10.Lib;

namespace Tyuiu.MusinND.Sprint1.Task2.V10.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int meters = 1; 
            double expectedInches = meters * 39.37;
            var res = (double)meters * 39.37;
            Assert.AreEqual(expectedInches, res, 0.001);
        }
    }
}