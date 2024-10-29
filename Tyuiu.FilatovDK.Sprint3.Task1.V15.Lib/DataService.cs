using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.FilatovDK.Sprint3.Task1.V15.Lib
{
    public class DataService : ISprint3Task1V15
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double multServies = 1;
            while (startValue <= stopValue)
            {
                multServies = multServies + (Math.Pow(value, 2) * startValue) + 1;
                startValue++;
            }
            return Math.Round(multServies, 3);
        }
    }
}
