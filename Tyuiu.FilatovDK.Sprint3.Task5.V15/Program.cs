using Tyuiu.FilatovDK.Sprint3.Task5.V15.Lib;
namespace Tyuiu.FilatovDK.Sprint3.Task5.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 5;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 10;
            Console.WriteLine("переменная Х = " + x);
            Console.WriteLine("Старт шага 1 = " + startValue1);
            Console.WriteLine("Старт шага 1 = " + stopValue1);
            Console.WriteLine("Старт шага 1 = " + startValue2);
            Console.WriteLine("Старт шага 1 = " + stopValue2);



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService DS = new DataService();
            Console.WriteLine("Сумма = " + ds.GetSumSumSeries(x, startValue1, stopValue1, startValue2, stopValue2));
            Console.ReadKey();
        }
    }
}
