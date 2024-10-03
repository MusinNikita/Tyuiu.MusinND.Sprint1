using Tyuiu.MusinND.Sprint1.Task2.V10.Lib;

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
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Мусин Никита Денисович | ИИПБ-24-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("* Известно расстояние в метрах. Вычислить расстояние в дюймах.            *");
            Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int x;

            Console.WriteLine("Введите количество метров для перевода в дюймы:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{ds.ConvertMetreToInchs(x)} дюймов");
            Console.ReadKey();
        }
    }
}