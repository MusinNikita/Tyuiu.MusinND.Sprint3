using Tyuiu.MusinND.Sprint3.Task0.V11.Lib;

namespace Tyuiu.MusinND.Sprint3.Task0.V11.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            DataService ds = new DataService();
            int value = 2;
            int startValue = 1;
            int stopValue = 3;
            double expectedResult = Math.Pow(1.0 / (value * 1), 2) +
                                    Math.Pow(1.0 / (value * 2), 2) +
                                    Math.Pow(1.0 / (value * 3), 2);

            var res = ds.GetSumSeries(value, startValue, stopValue);

            Assert.AreEqual(expectedResult, res, 1e-10);
        }
    }
}