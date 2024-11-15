using Tyuiu.MasalimovTR.Sprint3.Task1.V26.Lib;

namespace Tyuiu.MasalimovTR.Sprint3.Task1.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int value = 5;
            int startvalue = 1;
            int stopvalue = 8;
            double res = ds.GetSumSeries(value, startvalue, stopvalue);
            double wait = 1.5;
            Assert.AreEqual(wait, res);
        }
    }
}