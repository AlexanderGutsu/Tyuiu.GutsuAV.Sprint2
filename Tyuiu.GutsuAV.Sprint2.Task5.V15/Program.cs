using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.GutsuAV.Sprint2.Task5.V15.Lib;

namespace Tyuiu.GutsuAV.Sprint2.Task5.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Гуцу А. В. | ИИПБ-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Операторы Switch                                                  *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Гуцу Александр Владимирович | ИИПБ-23-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* вычисляет результат по формуле и печатает его на экране.                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите число от 1 до 365:");
            int k = int.Parse(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string dayName = FindDayName(k);
            Console.WriteLine("День недели: " + dayName);

            Console.ReadLine();
        }

        static string FindDayName(int k)
        {
            int dayNumber = (k - 1) % 7; 

            switch (dayNumber)
            {
                case 0:
                    return "понедельник";
                case 1:
                    return "вторник";
                case 2:
                    return "среда";
                case 3:
                    return "четверг";
                case 4:
                    return "пятница";
                case 5:
                    return "суббота";
                case 6:
                    return "воскресенье";
                default:
                    return "";
            }
            }
    }
}
