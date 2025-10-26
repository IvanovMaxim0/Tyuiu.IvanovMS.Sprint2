using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.IvanovMS.Sprint2.Task2.V21.Lib
{
    public class DataService : ISprint2Task2V21
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res = false;

            if ((((x == 3) && (y >= 3) && (y <= 7)) || (x >= 4) && (x <= 5) && (y >= 6) && (y <= 9)))
            {
                res = true;
            }
            if ((((x == 6) && (y >= 5) && (y <= 9)) || (x >= 7) && (x <= 8) && (y >= 5) && (y <= 7)))
            {
                res = true;
            }
            if ((((x == 9) && (y >= 3) && (y <= 7)) || (x == 9) && (y >= 11) && (y <= 12)))
            {
                res = true;
            }
            if (((((x >= 10) && (x <= 12) && (y >= 3) && (y <= 11)) || (x == 13) && (y >= 6) && (y <= 8))) || ((x == 10) && (y == 12)))
            {
                res = true;
            }
            return res;
        }
    }
}