using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MusinND.Sprint1.Task3.V10.Lib
{
    public class DataService : ISprint1Task3V10
    {
        public double NumberToMoney(double number)
        {
            int rub = Convert.ToInt32(number);
            int kop = Convert.ToInt32((number - rub) * 100);

            return (double)(rub + kop);

        }
    }
}
