using System.Runtime.InteropServices;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ShabalinaYP.Sprint2.Task6.V14.Lib

{

    public class DataService : ISprint2Task6V14

    {

        public string FindDayName(int k, int d)

        {

            string[] days = new string[7];

            days = ["понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье"];

            string res = d switch

            {
                1 => days[(k - 1) % 7],
                2 => days[(k) % 7],
                3 => days[(k + 1) % 7],
                4 => days[(k + 2) % 7],
                5 => days[(k + 3) % 7],
                6 => days[(k + 4) % 7],
                7 => days[(k + 5) % 7],

            };
            return res;
        }
    }
}