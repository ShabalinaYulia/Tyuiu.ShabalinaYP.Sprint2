using Tyuiu.ShabalinaYP.Sprint2.Task6.V14.Lib;

namespace Tyuiu.ShabalinaYP.Sprint2.Task6.V14

{

    internal class Program

    {

        static void Main(string[] args)

        {

            DataService ds = new DataService();
            


            Console.WriteLine("***************************************************************************");

            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");

            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите номер дня:");

            int k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите день с какого начался год");

            int d = Convert.ToInt32(Console.ReadLine());

            string res = ds.FindDayName(k, d);



            Console.WriteLine("***************************************************************************");

            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");

            Console.WriteLine("***************************************************************************");

            Console.WriteLine("День недели " + res);

            Console.ReadKey();



        }

    }

}

