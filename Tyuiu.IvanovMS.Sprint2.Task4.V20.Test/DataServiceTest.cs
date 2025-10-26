using Tyuiu.IvanovMS.Sprint2.Task4.V20.Lib;
namespace Tyuiu.IvanovMS.Sprint2.Task4.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 5;
            var res = ds.Calculate(x, y);
            double wait = 121661515.609;
            Assert.AreEqual(wait, res);

        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 15;
            var res = ds.Calculate(x, y);
            double wait = 99.933;
            Assert.AreEqual(wait, res);

        }
    }
}
