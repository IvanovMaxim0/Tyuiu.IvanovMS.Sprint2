using Tyuiu.IvanovMS.Sprint2.Task5.V11.Lib;
class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #2 | Выолнил: Иванов М. С. | ПКТБ-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Оператор Switch                                                         *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #11                                                             *");
        Console.WriteLine("* Выполнил: Иванов Максим Сергеевич | ПКТБ-25-1                           *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дата некоторого дня характеризуется тремя натуральными числами: g (год),*");
        Console.WriteLine("* m (порядковый номер месяца) и n (число). По заданным g, n и m определить*");
        Console.WriteLine("* дату следующего дня. Заданный год не является високосным.               *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Введите год:");
        int g = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите порядковый номер месяца:");
        int m = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите число:");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        if (g <= 0 || m <= 0 || m > 12 || n <= 0 || n > 31)
        {
            Console.WriteLine("Введены некорректные данные!");
        }
        else
        {
            Console.WriteLine(ds.FindDateOfNextDay(g, m, n));
        }

        Console.ReadKey();
    }
}