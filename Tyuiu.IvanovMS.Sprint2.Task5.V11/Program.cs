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
        int value = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(ds.FindDateOfNextDay(value));
    }
}