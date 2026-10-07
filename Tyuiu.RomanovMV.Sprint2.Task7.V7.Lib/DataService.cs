
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.RomanovMV.Sprint2.Task7.V7.Lib
{
    public class DataService : ISprint2Task7V7
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            double d = 2 - x * x;

            if (((y <= d) && (y >= x)) || ((y <= x) && (y >= 0) && (y <= d))) 
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
