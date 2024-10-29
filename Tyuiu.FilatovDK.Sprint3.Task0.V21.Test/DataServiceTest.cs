using Tyuiu.FilatovDK.Sprint3.Task0.V21.Lib;
namespace Tyuiu.FilatovDK.Sprint3.Task0.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            double value = 1.5;
            int stsrtValue = 1;
            int stopValue = 13;
            double res = ds.GetSumSeries(value, stsrtValue, stopValue);
            double wait = -63.727;
            Assert.AreEqual(wait, res);
        }
    }
}