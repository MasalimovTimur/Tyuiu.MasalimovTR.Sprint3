﻿using System.Diagnostics;
using Tyuiu.MasalimovTR.Sprint3.Task7.V24.Lib;
using System.IO;
using System.Diagnostics.CodeAnalysis;

namespace Tyuiu.MasalimovTR.Sprint3.Task7.V24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Масалимов Т.Р. | РППб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Обработка целочисленной информации                                *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнил: Масалимов Тимур Рyсланович | РППб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");            
            Console.WriteLine("* КАРТИНКА                                                                *");
            string executablePath = AppContext.BaseDirectory ;
            string imagePath = Path.Combine(executablePath, "Task7v30.png"); ;
                Process.Start(new ProcessStartInfo
                {
                    FileName = imagePath,
                    UseShellExecute = true
                }
                );            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Результат:");
            DataService dataService = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double[] sum = dataService.GetMassFunction(startValue, stopValue);
            Console.WriteLine(sum);
        }
    }
}
