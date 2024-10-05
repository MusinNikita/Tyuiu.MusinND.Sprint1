using Tyuiu.MusinND.Sprint1.Task7.V19.Lib;

namespace Tyuiu.MusinND.Sprint1.Task7.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Мусин Никита Денисович | ИИПб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Добавление к решению итоговых проектов по спринту                       *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнил: Мусин Никита Денисович | ИИПб-24-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по       *");
            Console.WriteLine("* исходным значениям данных, вводимых пользователем.                      *");
            Console.WriteLine("*Ответ округлите до 3 знаков после запятой.                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("*z = x - ((7x^2) / (x^3)) + sin (x) + |x^4 - x^5|                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите X:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(ds.Calculate(x));
        }
    }
}