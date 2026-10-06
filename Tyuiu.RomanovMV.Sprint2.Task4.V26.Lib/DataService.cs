
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.RomanovMV.Sprint2.Task4.V26.Lib
{
    public class DataService : ISprint2Task4V26
    {
        public double Calculate(double x, double y)
        {
            double z = (x - 2) < y / 2 ? Math.Pow((10 + 2 / (x * x)), y) : x * x - (1 / y);

            return Math.Round(z, 3);
        }
    }
}
