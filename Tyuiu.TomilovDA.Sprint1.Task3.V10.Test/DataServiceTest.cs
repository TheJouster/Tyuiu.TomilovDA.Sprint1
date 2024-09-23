using Tyuiu.TomilovDA.Sprint1.Task3.V10.Lib;

namespace Tyuiu.TomilovDA.Sprint1.Task3.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckValue()
        {
            DataService ds = new DataService();
            Assert.AreEqual(2360, ds.NumberToMoney(23.6));
        }
    }
}