using Tyuiu.IvanovMS.Sprint2.Task0.V6.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        int x = 107;
        int y = 754;
        bool[] res = new bool[6];
        res = ds.GetCompareOperations(x, y);

        Console.Title = "Спринт #2 | Выолнил: Иванов М. С. | ПКТБ-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Операции сравнения                                                      *");
        Console.WriteLine("* Задание #0                                                              *");
        Console.WriteLine("* Вариант #6                                                              *");
        Console.WriteLine("* Выполнила: Иванов Максим Сергеевич  | ПКТБ-25-1                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,         *");
        Console.WriteLine("* последовательность операций не должна нарушаться) и арифметических      *");
        Console.WriteLine("* выражений, которая вернет логическую последовательность(массив):        *");
        Console.WriteLine("* (True, True, True, False, True, False),)                                *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* x = 107, y = 754                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine(res[i]);
        }

        Console.ReadKey();
    }
}