using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MusinND.Sprint1.Task6.V15.Lib
{
    public class DataService : ISprint1Task6V15
    {
        public bool CheckLettersCount(string value)
        {
            int letterCount = 0;
            int symbolCount = 0;

            foreach (char c in value)
            {
                if (char.IsLetter(c))
                {
                    letterCount++;
                }
                else if (char.IsPunctuation(c) || char.IsSymbol(c))
                {
                    symbolCount++;
                }
            }
            return letterCount > symbolCount;
        }
    }
}
