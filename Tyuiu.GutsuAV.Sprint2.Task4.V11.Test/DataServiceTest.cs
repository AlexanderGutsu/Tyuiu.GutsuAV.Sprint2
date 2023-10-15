using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.GutsuAV.Sprint2.Task4.V11.Lib;

namespace Tyuiu.GutsuAV.Sprint2.Task4.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 10;
            double expectedZ = Math.Pow((3 + 8 / (x * x)), y);

            double actualZ = ds.Calculate(x, y);

            Assert.AreEqual(expectedZ, actualZ);
        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 20;
            double y = 5;
            double expectedZ = y - Math.Pow((x + 1 / (y + 2)), x);

            double actualZ = ds.Calculate(x, y);

            Assert.AreEqual(expectedZ, actualZ);
        }
    }
}
