
using Tyuiu.RomanovMV.Sprint2.Task0.V15.Lib;

//Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность
//операций не должна нарушаться) и арифметических выражений, которая вернет логическую
//последовательность(массив): (False, False, True, True, False, False), при x = 3105, y = 275

namespace Tyuiu.RomanovMV.Sprint2.Task0.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperation()
        {
            DataService ds = new DataService();
            int x = 3105;
            int y = 275;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            bool[] wait = new bool[6] { false, false, true, true, false, false};
            
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
