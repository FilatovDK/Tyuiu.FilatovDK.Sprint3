using Tyuiu.FilatovDK.Sprint3.Task4.V23.Lib;
namespace Tyuiu.FilatovDK.Sprint3.Task4.V23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue, stopValue;
            Console.WriteLine("первое число = "); 
            startValue = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("второе число = "); 
            stopValue = Convert.ToInt16(Console.ReadLine());



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService DS = new DataService();
            Console.WriteLine("результат: " + ds.Calculate(startValue, stopValue));
            Console.ReadKey();
        }
    }
}
