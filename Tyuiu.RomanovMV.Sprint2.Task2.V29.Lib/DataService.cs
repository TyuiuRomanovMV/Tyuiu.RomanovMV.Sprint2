
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.RomanovMV.Sprint2.Task2.V29.Lib
{
    public class DataService : ISprint2Task2V29
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            if ((y == 3) && ((x >= 3) || (x <= 5)))
            { return true; }
            if ((y == 3) && ((x >= 9) || (x <= 12)))
            { return true; }


            if ((y == 4) && ((x >= 1) || (x <= 5)))
            { return true; }
            if ((y == 4) && ((x >= 9) || (x <= 12)))
            { return true; }


            if ((y == 5) && ((x >= 1) || (x <= 12)))
            { return true; }


            if ((y == 6) && ((x >= 3) || (x <= 13)))
            { return true; }


            if ((y == 7) && ((x >= 3) || (x <= 13)))
            { return true; }


            if ((y == 8) && (x==6))
            { return true; }
            if ((y == 8) && ((x >= 10) || (x <= 13)))
            { return true; }


            if ((y == 9) && (x == 6))
            { return true; }
            if ((y == 9) && ((x >= 10) || (x <= 12)))
            { return true; }


            if ((y == 10) && (x == 6))
            { return true; }
            if ((y == 10) && ((x >= 10) || (x <= 12)))
            { return true; }


            if ((y == 11) && ((x >= 3) || (x <= 6)))
            { return true; }
            if ((y == 11) && ((x >= 10) || (x <= 12)))
            { return true; }


            if ((y == 12) && ((x >= 4) || (x <= 5)))
            { return true; }
            if ((y == 12) && (x == 10))
            { return true; }

            else
            { return false; }    
        }
    }
}
