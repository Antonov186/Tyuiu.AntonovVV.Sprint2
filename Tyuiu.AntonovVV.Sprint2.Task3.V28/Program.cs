using Tyuiu.AntonovVV.Sprint2.Task3.V28.Lib;
namespace Tyuiu.AntonovVV.Sprint2.Task3.V28
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Антонов В.В. | ИСПб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Вложенные операторы if - else                                     *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #28                                                             *");
            Console.WriteLine("* Выполнил: Антонов В.В. | ИСПб-24-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Написать программу, вычисляет требуемое значение функции Y              *");
            Console.WriteLine("* с использованием вложенных операторов if-else, где пользователь         *");
            Console.WriteLine("* вводите значение переменной X с клавиатуры.                             *");
            Console.WriteLine("* Округлить полученное значение до трех знаков после запятой.             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите значение переменной X:");
            double x = Convert.ToDouble(Console.ReadLine());
            double res = ds.Calculate(x);
            Console.WriteLine($"Значение выражения: {res}");
            Console.ReadKey();
        }
    }
}