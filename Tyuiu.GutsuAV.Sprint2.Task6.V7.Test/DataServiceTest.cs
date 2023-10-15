using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.GutsuAV.Sprint2.Task6.V7.Lib;

namespace Tyuiu.GutsuAV.Sprint2.Task6.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int n = 54;
            int days = 2;
            string monthName = ds.FindMonthName(n, days);
            Console.WriteLine("Месяц: " + monthName);
        }
    }
}
