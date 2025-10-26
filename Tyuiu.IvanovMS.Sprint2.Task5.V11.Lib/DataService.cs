using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.IvanovMS.Sprint2.Task5.V11.Lib
{
    public class DataService : ISprint2Task5V11
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            {
                int res_n;
                string date;

                res_n = 0;

                switch (m)
                {
                    case 1:
                        res_n = 31;

                        break;
                    case 2:
                        res_n = 28;
                        break;
                    case 3:
                        res_n = 31;
                        break;
                    case 4:
                        res_n = 30;
                        break;
                    case 5:
                        res_n = 31;
                        break;
                    case 6:
                        res_n = 30;
                        break;
                    case 7:
                        res_n = 31;
                        break;
                    case 8:
                        res_n = 31;
                        break;
                    case 9:
                        res_n = 30;
                        break;
                    case 10:
                        res_n = 31;
                        break;
                    case 11:
                        res_n = 30;
                        break;
                    case 12:
                        res_n = 31;
                        break;
                    default:
                        throw new ArgumentException($"Месяц должен быть от 1 до 12. Значение {m}");

                }
                if (n < res_n)
                {
                    n = n + 1;


                }
                else
                {
                    if (n == res_n & m != 12)
                    {
                        n = 1;
                        m = m + 1;

                    }
                    else
                    {
                        if (n == res_n & m == 12)
                        {
                            n = 1;
                            m = 1;
                            g = g + 1;
                        }
                        else
                        {
                            if (n > res_n || m > 12 || m < 1 || g < 0)
                            {
                                date = "Неверный ввод.";
                            }
                        }
                    }

                }
                //string rn = n.ToString();
                //string rm = m.ToString();
                //string rg = g.ToString();
                if (n < 10 & m < 10)
                {
                    date = "0" + n + "." + "0" + m + "." + g;
                }
                else
                {
                    if (m < 10)
                    {
                        date = n + "." + "0" + m + "." + g;
                    }
                    else
                    {
                        if (n < 10)
                        {
                            date = "0" + n + "." + m + "." + g;
                        }
                        else
                        {
                            date = n + "." + m + "." + g;
                        }
                    }
                }

                return date;
            }
        }
    }
}

