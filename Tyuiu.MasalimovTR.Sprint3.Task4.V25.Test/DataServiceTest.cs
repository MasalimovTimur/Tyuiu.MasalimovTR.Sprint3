using Tyuiu.MasalimovTR.Sprint3.Task4.V25.Lib;
namespace Tyuiu.MasalimovTR.Sprint3.Task4.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double res = ds.Calculate(startValue, stopValue);
            double wait = 37.023;
            Assert.AreEqual(wait, res);
        }
    }
}