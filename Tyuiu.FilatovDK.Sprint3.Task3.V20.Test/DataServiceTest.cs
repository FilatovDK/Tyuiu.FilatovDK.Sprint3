using System.Net.Http.Headers;
using Tyuiu.FilatovDK.Sprint3.Task3.V20.Lib;
namespace Tyuiu.FilatovDK.Sprint3.Task3.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCharCount()
        {
            DataService ds = new DataService();
            string str = "gfft ntf f opf";
            char chr = 'f';
            int res = ds.GetCharCount(str, chr);
            int wait = 5;
            Assert.AreEqual(wait, res);
        }
    }
}