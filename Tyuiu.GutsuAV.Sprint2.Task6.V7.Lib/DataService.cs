using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GutsuAV.Sprint2.Task6.V7.Lib
{
    public class DataService : ISprint2Task6V7
    {
        public string FindMonthName(int startYear, int n)
        {
            int month = (n - 2) % 12; 
            switch (month)
            {
                case 0: return "январь";
                case 1: return "февраль";
                case 2: return "март";
                case 3: return "апрель";
                case 4: return "май";
                case 5: return "июнь";
                case 6: return "июль";
                case 7: return "август";
                case 8: return "сентябрь";
                case 9: return "октябрь";
                case 10: return "ноябрь";
                case 11: return "декабрь";
                default: return "неверное значение";
            }
        }
    }
}
