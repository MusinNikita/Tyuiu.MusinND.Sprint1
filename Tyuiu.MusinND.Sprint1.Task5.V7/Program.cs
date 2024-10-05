using Tyuiu.MusinND.Sprint1.Task5.V7.Lib;

namespace Tyuiu.MusinND.Sprint1.Task5.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Мусин Никита Денисович | ИИПб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Class Math                                                              *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #7                                                               *");
            Console.WriteLine("* Выполнил: Мусин Никита Денисович | ИИПб-24-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Определить h – полное количество часов прошедших от начала суток до     *");
            Console.WriteLine("* того момента (в первой половине дня), когда часовая стрелка повернулась *");
            Console.WriteLine("* на f градусов (0<f<360, f – вещественное число).                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("* Известно расстояние в метрах. Вычислить расстояние в дюймах.            *");
            Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double x;
            Console.WriteLine("Введите число X:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"{ds.AngleToHoursMinutes(x)}");
            Console.ReadKey();
        }
    }
}