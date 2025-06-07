using Tyuiu.AntonovVV.Sprint2.Task6.V14.Lib;
namespace Tyuiu.AntonovVV.Sprint2.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest

    {

        [TestMethod]

        public void ValidFindDayName()

        {

            DataService ds = new DataService();

            int k = 15;

            int d = 7;

            string res = ds.FindDayName(k, d);

            string wait = "Âîñêðåñåíüå";

            Assert.IsTrue(res == wait);





        }

    }

}