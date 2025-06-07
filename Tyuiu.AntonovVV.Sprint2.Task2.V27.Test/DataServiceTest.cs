using Tyuiu.AntonovVV.Sprint2.Task2.V27.Lib;
namespace Tyuiu.AntonovVV.Sprint2.Task2.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            int x = 4;
            int y = 4;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}