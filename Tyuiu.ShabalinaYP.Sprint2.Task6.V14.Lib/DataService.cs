using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ShabalinaYP.Sprint2.Task6.V14.Lib

{

    public class DataService : ISprint2Task6V14

    {

        public string FindDayName(int k, int d)

        {

            string[] days = new string[7];

            days = ["понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье"];

            string res;

            switch (d)

            {

                case 1:

                    res = days[(k - 1) % 7];

                    break;

                case 2:

                    res = days[(k) % 7];

                    break;

                case 3:

                    res = days[(k + 1) % 7];

                    break;

                case 4:

                    res = days[(k + 2) % 7];

                    break;

                case 5:

                    res = days[(k + 3) % 7];



                    break;

                case 6:

                    res = days[(k + 4) % 7];

                    break;

                case 7:

                    res = days[(k + 5) % 7];

                    break;

                default:

                    throw new NotImplementedException();

            };

            return res;



        }

    }

}

