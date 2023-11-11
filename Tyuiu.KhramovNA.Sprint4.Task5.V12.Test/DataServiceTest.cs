using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KhramovNA.Sprint4.Task5.V12.Lib;

namespace Tyuiu.KhramovNA.Sprint4.Task5.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] num = new int[5, 5]    { {-6, 2, -5, 4, 2},
                                            {-4, 2, 3, -2, 4},
                                            {4, -1, 2, -2, -4},
                                            {3, 4, -3, 3, -2},
                                            {-5, -3, 4, 2, -1} };
            int res = ds.Calculate(num);
            int wait = 12;
            Assert.AreEqual(res, wait);
        }
    }
}