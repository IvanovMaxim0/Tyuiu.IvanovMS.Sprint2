using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.IvanovMS.Sprint2.Task6.V13.Lib
{
    public class DataService : ISprint2Task6V13
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            if (m < 1 || m > 12 || g < 0)
            {
                return "Неверный ввод.";
            }

            int res_n;
            res_n = m switch
            {
                1 => 31,
                2 => (g % 4 == 0 && g % 100 != 0) || (g % 400 == 0) ? 29 : 28,
                3 => 31,
                4 => 30,
                5 => 31,
                6 => 30,
                7 => 31,
                8 => 31,
                9 => 30,
                10 => 31,
                11 => 30,
                12 => 31,
                _ => 0
            };

            if (n < 1 || n > res_n)
            {
                return "Неверный ввод.";
            }

            int next_n = n;
            int next_m = m;
            int next_g = g;

            if (n < res_n)
            {
                next_n = n + 1;
            }
            else
            {
                next_n = 1;
                if (m < 12)
                {
                    next_m = m + 1;
                }
                else
                {
                    next_m = 1;
                    next_g = g + 1;
                }
            }

            
            return $"{next_n:D2}.{next_m:D2}.{next_g}";
        }
    }
}