using Tyuiu.FilatovDK.Sprint3.Task3.V20.Lib;
namespace Tyuiu.FilatovDK.Sprint3.Task3.V20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string value = "gfft ntf f opf";
            char chr = 'f';
            Console.WriteLine("Исходная строка = " + value);
            Console.WriteLine("Искодная строка = " + chr);



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Количество символов = " + ds.GetCharCount(value, chr));
            Console.ReadKey();
        }
    }
}
