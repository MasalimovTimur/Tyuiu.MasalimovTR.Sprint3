using Tyuiu.MasalimovTR.Sprint3.Task7.V24.Lib;

namespace Tyuiu.MasalimovTR.Sprint3.Task7.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            int startValue = -5;
            int stopValue = 5;
            Double sum = Convert.ToDouble(dataService.GetMassFunction(startValue, stopValue));
        }
    }
}