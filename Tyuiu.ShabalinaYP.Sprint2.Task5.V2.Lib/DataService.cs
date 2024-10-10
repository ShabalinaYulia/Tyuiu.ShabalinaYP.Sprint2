﻿using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ShabalinaYP.Sprint2.Task5.V2.Lib
{
    public class DataService : ISprint2Task5V2
    {
        public string FindMonthSeason(int value)
        {
            string res;
            switch (value)
            {
                case 1:
                case 2:
                    res = "зима";
                    break;
                case 3:
                case 4:
                case 5:
                    res = "весна";
                    break;
                case 6:
                case 7:
                case 8:
                    res = "лето";
                    break;
                case 9:
                case 10:
                case 11:
                    res = "осень";
                    break;
                case 12:
                    res = "зима";
                    break;
                default:
                    throw new ArgumentException($"Месяц должен быть от 1 до 12. Значение {value}");
                    
            }
            return res;
            

        }
    }
}
