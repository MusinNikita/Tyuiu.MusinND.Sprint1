using Tyuiu.MusinND.Sprint1.Task1.V6.Lib;

namespace Tyuiu.MusinND.Sprint1.Task1.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Мусин Никита Денисович | ИИПБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Базовые навыки работы в C#                                              *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #6                                                             *");
            Console.WriteLine("* Выполнил: Мусин Никита Денисович | ИИПБ-24-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные  *");
            Console.WriteLine("* вычисляет результат по формуле (x + y) / (3 * y) и печатает его         *");
            Console.WriteLine("* на экране.                                                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* (x + y) / (3 * y)                                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double x, y;

            Console.WriteLine("Введите число X:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите число Y:");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(ds.Calculate(x, y));
            Console.ReadKey();
        }
    }
}