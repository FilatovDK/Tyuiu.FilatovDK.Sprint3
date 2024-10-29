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
            Console.WriteLine("переменная Х = " + ds.Calcu);
            Console.WriteLine("результат: " + ds.Calculate(startValue, stopValue));
            Console.WriteLine("результат: " + ds.Calculate(startValue, stopValue));
            Console.WriteLine("результат: " + ds.Calculate(startValue, stopValue));
            Console.WriteLine("результат: " + ds.Calculate(startValue, stopValue));



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService DS = new DataService();
            Console.WriteLine("результат: " + ds.Calculate(startValue, stopValue));
            Console.ReadKey();
        }
    }
}
