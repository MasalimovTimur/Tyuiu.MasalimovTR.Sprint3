using Tyuiu.MasalimovTR.Sprint3.Task2.V12.Lib;

namespace Tyuiu.MasalimovTR.Sprint3.Task2.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Масалимов Т.Р. | РППб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: do-while                                                          *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнил: Масалимов Тимур Рyсланович | РППб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл do...while, которая вычисляет произведение ряда по формуле, при х=5  *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Результат:");
            DataService ds = new DataService();
            int value = 5;
            int startvalue = 1;
            int stopvalue = 5;
            double res = ds.GetMultiplySeries(value, startvalue, stopvalue);
            Console.WriteLine(res);
        }
    }
}
