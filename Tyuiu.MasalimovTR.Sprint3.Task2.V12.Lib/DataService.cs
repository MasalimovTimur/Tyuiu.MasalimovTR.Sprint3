using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MasalimovTR.Sprint3.Task2.V12.Lib
{
    public class DataService : ISprint3Task2V12
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
           double SumSeries = 0;
            do
            {
                SumSeries = SumSeries + Math.Pow((300/(startValue+Math.Pow(value, startValue))) ,startValue) ;
                startValue++;
            }  while ( startValue < stopValue );
            return Math.Round( SumSeries, 3 );
        }
    }
}
