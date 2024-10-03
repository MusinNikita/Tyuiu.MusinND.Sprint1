using Tyuiu.MusinND.Sprint1.Task0.V21.Lib;

namespace Tyuiu.MusinND.Sprint1.Task0.V21.Test
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
            var res = ds.Calculate();
            Assert.AreEqual(17, res);
        }
    }
}