﻿using Tyuiu.AntonovVV.Sprint2.Task7.V1.Lib;
namespace Tyuiu.AntonovVV.Sprint2.Task7.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void VoidExpression()
        {
            DataService ds = new DataService();

            double x = 0.5;
            double y = 0.5;

            var res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(true, res);
        }
    }
}