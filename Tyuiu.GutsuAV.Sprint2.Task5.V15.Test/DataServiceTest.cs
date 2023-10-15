using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GutsuAV.Sprint2.Task5.V15.Lib;

namespace Tyuiu.GutsuAV.Sprint2.Task5.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {

        [TestMethod]
        public void ValindFindDay()
        {
            DataService ds = new DataService();
            int k = 1;
            string expected = "Понедельник";

            
            string actual = ds.FindDayName(k);

            
            Assert.AreEqual(expected, actual);
        }


    }
}
