using Tyuiu.IvanovMS.Sprint2.Task6.V13.Lib;
namespace Tyuiu.IvanovMS.Sprint2.Task6.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod()
        {
            DataService ds = new DataService();
            int g = 2020;
            int m = 12;
            int n = 31;
            string wait = "01.01.2021";
            string res = ds.FindDateOfNextDay(g, m, n);
            Assert.AreEqual(wait, res);
        }
    }
}
