﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.GutsuAV.Sprint2.Task1.V13.Lib;
//ЗАДАНИЕ
//Написать программу из операций сравнений (==, !=, <, >, <=, >=) последовательность можно чередовать, но использовать один раз в выражении
//и логических операций (|, &, ||, &&, !, ^, последовательность операций не должна нарушаться)
//а также арифметических выражений, которая вернет логическую последовательность(массив): (True, True, True, True, True, False)
//при a = 145, b = 916, c = 164, d = 137

namespace Tyuiu.GutsuAV.Sprint2.Task1.V13
{
    class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();

            int a = 145;
            int b = 916;
            int c = 164;
            int d = 137;

            bool[] res = new bool[6];

            res = ds.GetLogicOperations(a, b, c, d);

            Console.Title = "Спринт #2 | Выполнил: Гуцу А. В. | ИИПБ-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Логические операции                                               *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: Гуцу Александр Владимирович | ИИПБ-23-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* вычисляет результат по формуле и печатает его на экране.                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            Console.WriteLine("d = " + d);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();
        }
    }
}
