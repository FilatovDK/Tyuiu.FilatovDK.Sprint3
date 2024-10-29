using Tyuiu.FilatovDK.Sprint3.Task5.V15.Lib;
namespace Tyuiu.FilatovDK.Sprint3.Task5.V15.Test
{
    [TestClass]
    public class DaraServiceTest
    {
        [TestMethod]
        public void VaidGetSumSumSeries()
        {
            DataService ds = new DataService();
            int x = 5;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 10;

            double res = ds.GetSumSumSeries(x, startValue1, stopValue1, startValue2, stopValue2);
            double wait = 28.329;
            Assert.AreEqual(wait, res);
        }
    }
}