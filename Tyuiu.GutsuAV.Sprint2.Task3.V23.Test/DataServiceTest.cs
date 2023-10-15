using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.GutsuAV.Sprint2.Task3.V23.Lib;

namespace Tyuiu.GutsuAV.Sprint2.Task3.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {

        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 2;
            double expectedY = 22;

            double actualY = ds.Calculate(x);

            Assert.AreEqual(expectedY, actualY);
        }
        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            double x = 0;
            double expectedY = 13;

            double actualY = ds.Calculate(x);

            Assert.AreEqual(expectedY, actualY);
        }
        [TestMethod]
        public void ValidCondition4()
        {
            DataService ds = new DataService();

            double x = 1;
            double expectedY = 4;

            double actualY = ds.Calculate(x);

            Assert.AreEqual(expectedY, actualY);
        }
        [TestMethod]
        public void ValidCondition5()
        {
            DataService ds = new DataService();
            double x = -30;
            double expectedY = -2900.911;

            double actualY = ds.Calculate(x);

            Assert.AreEqual(expectedY, actualY);
        }

    }
}
