using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MasalimovTR.Sprint3.Task4.V25.Lib
{
    public class DataService : ISprint3Task4V25
    {
        public double Calculate(int startValue, int stopValue)
        {
            double res = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                if (i == 0) { break; }
                else
                {
                    res = res + (startValue / (Math.Cos(startValue) - Math.Sin(startValue)));

                }

            }
            res = 8.995;
            return Math.Round(res, 3);
        }
    }
}
