using Tyuiu.AntonovVV.Sprint2.Task5.V9.Lib;
namespace Tyuiu.AntonovVV.Sprint2.Task5.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int n = 9;
            int m = 4;
            string wait = "04.10";
            Assert.AreEqual(wait, ds.FindDateOfNextDay(m, n));
        }
    }
}