using Tyuiu.MasalimovTR.Sprint3.Task0.V7.Lib;

namespace Tyuiu.MasalimovTR.Sprint3.Task0.V7.Test
{
    [TestClass]
    public class DataServiseTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double value = 0.75;
            int startvalue = 1;
            int stopvalue = 20;
            double res = ds.GetSumSeries(value, startvalue, stopvalue);
            double wait = 0.333;
            Assert.AreEqual(wait, res);
        }
    }
}