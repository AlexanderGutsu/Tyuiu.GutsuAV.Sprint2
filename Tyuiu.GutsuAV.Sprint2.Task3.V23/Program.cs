using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.GutsuAV.Sprint2.Task3.V23.Lib;

namespace Tyuiu.GutsuAV.Sprint2.Task3.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Гуцу А. В. | ИИПБ-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Вложенные операторы if - else                                     *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("* Выполнил: Гуцу Александр Владимирович | ИИПБ-23-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* вычисляет результат по формуле и печатает его на экране.                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите значение переменной X: ");
            double x = double.Parse(Console.ReadLine());

            double y = 0;

            if (x > 1)
            {
                y = x * Math.Pow((x + 1 / x - 1), x);
            }
            else if (x == 0)
            {
                y = Math.Pow(x, 2) + Math.Cos(Math.Pow(x, 2)) - 17 / Math.Pow(x, 2) - Math.Sin(Math.Pow(x, 2)) + 13;
            }
            else if (-27 < x && x < 2)
            {
                y = Math.Pow((3 + 1 / Math.Pow(x, 2)), x);
            }
            else if (x < -27)
            {
                y = x + 10 * x - (1 / Math.Pow(x, 2));
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Значение функции Y: " + Math.Round(y, 3));
            Console.ReadKey();
        }
        
    }
}
