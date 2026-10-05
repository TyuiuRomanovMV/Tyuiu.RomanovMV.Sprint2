
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.RomanovMV.Sprint2.Task3.V17.Lib
{
    public class DataService : ISprint2Task3V17
    {
        public double Calculate(double x)
        {
            double y = 0;

            if (x > 1)
            {
                y = Math.Round((x * x + Math.Pow((x + 1) / (x - 1), 8)), 3);
            }
            else
            {
                if (x == 0)
                {
                    y = Math.Round(((2 + x - 3 * x) / (x - 7)), 3);
                }
                else
                {
                    if ((x > -21) && (x < 2))
                    {
                        y = Math.Round(Math.Pow((1 + 1 / (x * x)), 4), 3);
                    }
                    else
                    {
                        if (x<-21)
                        {
                            y = Math.Round((x + 10 * x - (1 / x)), 3);
                        }
                    }
                }
            }
            return y;
        }
    }
}
