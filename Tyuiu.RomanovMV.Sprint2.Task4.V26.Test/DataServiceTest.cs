
using Tyuiu.RomanovMV.Sprint2.Task4.V26.Lib;

namespace Tyuiu.RomanovMV.Sprint2.Task4.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 1; double y = 2;
            double res = ds.Calculate(x, y);
            double wait = 144;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 5; double y = 4;
            double res = ds.Calculate(x, y);
            double wait = 24.75;
            Assert.AreEqual(wait, res);
        }
    }
}
