
using Tyuiu.RomanovMV.Sprint2.Task1.V6.Lib;

//Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность можно
//чередовать, но использовать один раз в выражении) и логических операций (|, &, ||, &&, !, ^,
//последовательность операций не должна нарушаться), а также арифметических выражений, которая вернет
//логическую последовательность(массив): (False, False, True, False, True, False),
//при a = 915, b = 169, c = 174, d = 133

namespace Tyuiu.RomanovMV.Sprint2.Task1.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int a = 915; int b = 169; int c = 174; int d = 133;

            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);
            bool[] wait = new bool[6] { false, false, true, false, true, false };

            CollectionAssert.AreEquivalent(wait, res);
        }
    }
}
