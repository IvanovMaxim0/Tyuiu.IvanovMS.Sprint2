using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.IvanovMS.Sprint2.Task7.V7.Lib
{
    public class DataService : ISprint2Task7V7
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if (((y + x * x - 2 < 0) && (y > 0)) || ((y + x * x - 2 < 0) && (y - x) > 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
