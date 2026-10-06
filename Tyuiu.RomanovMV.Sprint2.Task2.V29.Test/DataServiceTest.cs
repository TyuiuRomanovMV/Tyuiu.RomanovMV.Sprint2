
using Tyuiu.RomanovMV.Sprint2.Task2.V29.Lib;

namespace Tyuiu.RomanovMV.Sprint2.Task2.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadeArea()
        {
            DataService ds = new DataService();
            int x = 4; int y = 4;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}
