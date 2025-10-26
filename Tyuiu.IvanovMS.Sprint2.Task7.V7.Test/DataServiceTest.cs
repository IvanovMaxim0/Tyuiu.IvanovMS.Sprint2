using Tyuiu.IvanovMS.Sprint2.Task7.V7.Lib;
namespace Tyuiu.IvanovMS.Sprint2.Task7.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int x = 0;
            int y = 1;
            DataService ds = new DataService();
            bool wait = true;
            var res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}