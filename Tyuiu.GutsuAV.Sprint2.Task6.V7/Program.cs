using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.GutsuAV.Sprint2.Task6.V7.Lib;

//ЗАДАНИЕ
//Написать программу, которая использует сокращенную форму записи оператора switch вычисляет требуемое значение и возвращает результат.
//Условие: С начала 1990 года по некоторый день прошло n месяцев и 2 дня. Определить название месяца (январь, февраль и т. п.) этого дня.

namespace Tyuiu.GutsuAV.Sprint2.Task6.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Гуцу А. В. | ИИПБ-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Получение результата из Switch                                    *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Гуцу Александр Владимирович | ИИПБ-23-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* вычисляет результат по формуле и печатает его на экране.                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            Console.WriteLine("Введите количество месяцев:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество дней:");
            int days = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string monthName = ds.FindMonthName(n, days);
            Console.WriteLine("Месяц: " + monthName);
            Console.ReadLine();
        }
    }
}
