using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.IvanovMS.Sprint2.Task5.V11.Lib
{
    public class DataService : ISprint2Task5V11
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            {
                int nextg, nextm, nextn;

                switch (m)
                {
                    case 2:
                        if (n < 28)
                        {
                            nextg = g;
                            nextm = m;
                            nextn = n + 1;
                        }
                        else if (n == 28)
                        {
                            nextg = g;
                            nextm = m + 1;
                            nextn = 1;
                        }
                        else
                        {
                            nextg = 0;
                            nextm = 0;
                            nextn = 0;
                        }
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        if (n < 30)
                        {
                            nextg = g;
                            nextm = m;
                            nextn = n + 1;
                        }
                        else if (n == 30)
                        {
                            nextg = g;
                            nextm = m + 1;
                            nextn = 1;
                        }
                        else
                        {
                            nextg = 0;
                            nextm = 0;
                            nextn = 0;
                        }
                        break;

                    default:
                        if (n < 31)
                        {
                            nextg = g;
                            nextm = m;
                            nextn = n + 1;
                        }
                        else if (n == 31)
                        {
                            nextg = g;
                            if (m == 12)
                            {
                                nextm = 1;
                                nextg = g + 1;
                            }
                            else
                            {
                                nextm = m + 1;
                            }
                            nextn = 1;
                        }
                        else
                        {
                            nextg = 0;
                            nextm = 0;
                            nextn = 0;
                        }
                        break;
                }
                string res = Convert.ToString(($"Следующий день: {nextn}.{nextm}.{nextg}"));
                return res;
            }

        }
    }
}