using Tyuiu.MasalimovTR.Sprint3.Task3.V14.Lib;

namespace Tyuiu.MasalimovTR.Sprint3.Task3.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Масалимов Т.Р. | РППб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: foreach                                                         *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Масалимов Тимур Рyсланович | РППб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach заменить буквы d  на ’ в строке: dgt ghedd bed  *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Результат:");
            DataService ds = new DataService();
            string value = "dgt ghedd bed";
            char replaceable = 'd';
            char replacement = '’';
            string res = ds.ReplaceCharInString(value, replaceable, replacement);
            Console.WriteLine(res);
        }
    }
}
