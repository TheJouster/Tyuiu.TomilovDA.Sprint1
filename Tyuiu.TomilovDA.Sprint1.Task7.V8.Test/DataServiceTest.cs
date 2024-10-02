using Tyuiu.TomilovDA.Sprint1.Task7.V8.Lib;


namespace Tyuiu.TomilovDA.Sprint1.Task7.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3;
            double z = -1.384;

            Assert.AreEqual(z, ds.Calculate(x,y));
        }
    }
}