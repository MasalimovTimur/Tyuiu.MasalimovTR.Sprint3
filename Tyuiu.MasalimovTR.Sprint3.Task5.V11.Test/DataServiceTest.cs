using Tyuiu.MasalimovTR.Sprint3.Task5.V11.Lib;

namespace Tyuiu.MasalimovTR.Sprint3.Task5.V11.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 5;
            int startValue1 = 1;
            int startValue2 = 1;
            int stopValue1 = 3;
            int stopValue2 = 10;
            double res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);
            double wait = 8.524;
            Assert.AreEqual(wait, res);
        }
    }
}