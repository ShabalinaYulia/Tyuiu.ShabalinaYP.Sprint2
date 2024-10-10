using Tyuiu.ShabalinaYP.Sprint2.Task5.V2.Lib;
namespace Tyuiu.ShabalinaYP.Sprint2.Task5.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите номер месяца:");
            int value = Convert.ToInt32(Console.ReadLine());
            string res = ds.FindMonthSeason(value);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Значение: " + res);
            Console.ReadKey();
        }
    }
}
