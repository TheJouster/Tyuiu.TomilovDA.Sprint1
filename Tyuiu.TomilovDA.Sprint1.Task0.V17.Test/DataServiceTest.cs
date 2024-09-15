using Tyuiu.TomilovDA.Sprint1.Task0.V17.Lib;

namespace Tyuiu.TomilovDA.Sprint1.Task0.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(2, res);
        }
    }
}