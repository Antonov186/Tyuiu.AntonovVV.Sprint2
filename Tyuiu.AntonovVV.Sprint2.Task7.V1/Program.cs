using Tyuiu.AntonovVV.Sprint2.Task7.V1.Lib;
namespace Tyuiu.AntonovVV.Sprint2.Task7.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            double x, y;


            Console.Title = "Спринт #2 | Выполнил: Антонов В.В. | ИСПБ-24-1";
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine("- Спринт #2                                                                            -");
            Console.WriteLine("- Тема: Операции сравнения                                                             -");
            Console.WriteLine("- Задание #7                                                                           -");
            Console.WriteLine("- Вариант #1                                                                           -");
            Console.WriteLine("- Выполнил: Антонов В.В. | ИСПБ-24-1                                                   -");
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine("- УСЛОВИЕ:                                                                             -");
            Console.WriteLine("- Написать программу на C#, которая запрашивает исходные данные (вещественные значения)-");
            Console.WriteLine("- и вычисляет, находится ли точка с координатами                                       -");
            Console.WriteLine("- X,Y в заштрихованной области.                                                        -");
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine("- ИСХОДНЫЕ ДАННЫЕ:                                                                     -");
            Console.WriteLine("----------------------------------------------------------------------------------------");

            Console.WriteLine("Введите x: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y: ");
            y = Convert.ToDouble(Console.ReadLine());





            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine("- РЕЗУЛЬТАТ:                                                                           -");
            Console.WriteLine("----------------------------------------------------------------------------------------");

            Console.WriteLine("Результат: " + ds.CheckDotInShadedArea(x, y));
            Console.ReadKey();


            Console.ReadLine();
        }
    }
}