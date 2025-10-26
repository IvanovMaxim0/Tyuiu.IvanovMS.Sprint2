using Tyuiu.IvanovMS.Sprint2.Task3.V25.Lib;
class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #2 | Выолнил: Иванов М. С. | ПКТБ-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Вложенные операторы if - else                                           *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #25                                                             *");
        Console.WriteLine("* Выполнил: Иванов Максим Сергеевич | ПКТБ-25-1                           *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Y с    *");
        Console.WriteLine("* использованием вложенных оператор if-else, где пользователь вводит      *");
        Console.WriteLine("* значение переменной X с клавиатуры.                                     *");
        Console.WriteLine("* Округлить полученное значение до трех знаков после запятой.             *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Введите значение х:");
        int x = 0;
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(ds.Calculate(x));
    }
}