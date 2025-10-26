using Tyuiu.IvanovMS.Sprint2.Task6.V13.Lib;
class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #2 | Выолнил: Иванов М. С. | ПКТБ-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Получение результата из switch                                          *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #13                                                             *");
        Console.WriteLine("* Выполнил: Иванов Максим Сергеевич | ПКТБ-25-1                           *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дата некоторого дня характеризуется тремя натуральными числами:         *");
        Console.WriteLine("* g (год), m (порядковый номер месяца) и n (число).                       *");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Введите год:");
        int g = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите месяц:");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите день:");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(ds.FindDateOfNextDay(g, m, n));
    }
}
