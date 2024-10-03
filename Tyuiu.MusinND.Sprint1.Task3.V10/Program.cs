using Tyuiu.MusinND.Sprint1.Task3.V10.Lib;

namespace Tyuiu.MusinND.Sprint1.Task1.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Мусин Никита Денисович | ИИПб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Операторы основного присваивания                                        *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Мусин Никита Денисович | ИИПб-24-1                            *");
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
            
            double x;
            Console.WriteLine("Введите десятичное число:");
            x = Convert.ToDouble(Console.ReadLine());
            double amount = ds.NumberToMoney(x);
            int rub = Convert.ToInt32(amount);
            int kop = Convert.ToInt32((amount-rub)*100);
            Console.WriteLine($"{rub} руб. {kop} коп.");
            Console.ReadKey();
        }
    }
}