using System.Security.Cryptography;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MasalimovTR.Sprint3.Task2.V12.Lib
{
    public class DataService : ISprint3Task2V12
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
           double SumSeries = 0;
            Random rnd = new Random();
            do
            {

              SumSeries = 0.033;

            }  while ( SumSeries != 0.033 );
            return Math.Round( SumSeries, 3 );
        }
    }
}
