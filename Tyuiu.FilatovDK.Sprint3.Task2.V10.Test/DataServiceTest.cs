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
            double res = ds.GetMultiplySeries(1, 1, 13);
            double wait = 7.5;
            Assert.AreEqual(wait, res);
        }
    }
}