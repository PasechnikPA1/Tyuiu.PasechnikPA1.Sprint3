
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.PasechnikPA1.Sprint3.Task0.V24.Lib
{
    public class DataService : ISprint3Task0V24
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double sumSeries = 0;
            int i;
            for (i = startValue; i <= stopValue; i++)
            {
                sumSeries = sumSeries + Math.Pow((3 / (i + (Math.Pow(value, -i)))), 2);
            }
            return Math.Round(sumSeries, 3);
        }
    }
}
