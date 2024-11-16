using Tyuiu.MasalimovTR.Sprint3.Task2.V12.Lib;

namespace Tyuiu.MasalimovTR.Sprint3.Task2.V12.Test
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
            int stopvalue = 5;
            double res = ds.GetMultiplySeries(value, startvalue, stopvalue);
            double wait = 186.383;
            Assert.AreEqual(wait, res);
        }
    }
}