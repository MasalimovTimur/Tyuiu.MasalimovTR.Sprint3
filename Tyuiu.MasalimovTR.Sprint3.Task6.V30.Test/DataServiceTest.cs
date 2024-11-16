using Tyuiu.MasalimovTR.Sprint3.Task6.V30.Lib;

namespace Tyuiu.MasalimovTR.Sprint3.Task6.V30.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = 11;
            int stopValue = 17;
            int res = ds.GetSumTheDivisors(startValue, stopValue);
            int wait = 133;
            Assert.AreEqual(wait, res);

        }
    }
}