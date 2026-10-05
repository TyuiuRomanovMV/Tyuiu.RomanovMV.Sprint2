
using tyuiu.cources.programming.interfaces.Sprint2;

//Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность можно
//чередовать, но использовать один раз в выражении) и логических операций (|, &, ||, &&, !, ^,
//последовательность операций не должна нарушаться), а также арифметических выражений, которая вернет
//логическую последовательность(массив): (False, False, True, False, True, False),
//при a = 915, b = 169, c = 174, d = 133

namespace Tyuiu.RomanovMV.Sprint2.Task1.V6.Lib
{
    public class DataService : ISprint2Task1V6
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a < b) | (c < d);
            res[1] = (a > b) & (c < d);
            res[2] = (a > b) || (c < d);
            res[3] = (a > b) && (c < d);
            res[4] = !(a < b);
            res[5] = (a > b) ^ (c > d);

            return res;





        }
    }
}
