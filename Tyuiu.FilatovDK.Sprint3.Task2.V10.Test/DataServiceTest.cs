using Tyuiu.FilatovDK.Sprint3.Task2.V10.Lib;
namespace Tyuiu.FilatovDK.Sprint3.Task2.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidMultiplySeries()
        {
            DataService ds = new DataService();
            int value = 1;
            int startValue = 1;
            int stopValue = 13;
            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = 0;
            Assert.AreEqual(wait, res);
        }
    }
}