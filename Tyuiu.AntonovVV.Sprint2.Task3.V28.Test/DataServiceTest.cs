﻿using Tyuiu.AntonovVV.Sprint2.Task3.V28.Lib;
namespace Tyuiu.AntonovVV.Sprint2.Task3.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = -5;
            Assert.AreEqual(wait, res);
        }
    }
}