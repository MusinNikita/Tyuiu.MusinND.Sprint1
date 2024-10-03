using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MusinND.Sprint1.Task4.V13.Lib
{
    public class DataService : ISprint1Task4V13
    {
        public double Calculate(double x, double y)
        {
            double pi = Math.PI;
            double eToTheXSummY = Math.Exp(x+y);
            double cosinePart = Math.Cos(pi / x);
            double result = cosinePart / (3 * eToTheXSummY);
           
            return result;
        }
    }
}
