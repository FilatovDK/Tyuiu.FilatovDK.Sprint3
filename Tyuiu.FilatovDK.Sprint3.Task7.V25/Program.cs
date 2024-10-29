using Tyuiu.FilatovDK.Sprint3.Task7.V25.Lib;
namespace Tyuiu.FilatovDK.Sprint3.Task7.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                      *");
            Console.WriteLine("*************************************************************************");
            int startValue = -5;
            int stopValue = 5;
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага =  " + stopValue);
            int len = ds.GetMassFunction(startValue, stopValue).Length;

            double[] valueArray;
            valueArray = new double[len];

            valueArray = ds.GetMassFunction(startValue, stopValue);


            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine("*************************************************************************");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine("| {0,6:d}      |   {1,6:f2}    |", startValue, valueArray[i]);
                startValue++;
            }
            Console.ReadKey();
        }
    }
}
