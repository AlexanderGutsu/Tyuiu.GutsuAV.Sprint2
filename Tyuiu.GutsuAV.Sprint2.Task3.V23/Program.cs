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

            Console.WriteLine("Значение функции Y: " + Math.Round(y, 3));
            Console.ReadLine();
        }
        
    }
}
