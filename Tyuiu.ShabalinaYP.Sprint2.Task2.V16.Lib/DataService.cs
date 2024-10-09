﻿using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ShabalinaYP.Sprint2.Task2.V16.Lib
{
    public class DataService : ISprint2Task2V16
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res = false;
            int[,] matrix = new int[15, 15]
            {
                //1,2,3,4,5,6,7,8,9,0,1,2,3,4,5
                { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},//1
                { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},//2
                { 0,0,1,1,1,0,0,0,0,0,0,0,1,1,0},//3
                { 0,0,1,1,1,0,0,0,0,0,0,0,1,1,0},//4
                { 0,0,1,1,1,1,1,0,0,0,0,0,1,1,0},//5
                { 0,0,1,1,1,1,1,1,1,0,0,0,1,1,0},//6
                { 0,0,1,1,1,1,1,1,1,1,1,1,1,1,0},//7
                { 0,0,0,0,0,1,1,1,1,0,0,0,1,1,0},//8
                { 0,0,0,0,0,1,1,0,0,0,0,0,1,1,0},//9
                { 0,0,0,0,0,1,1,0,0,0,0,0,1,1,0},//10
                { 0,0,1,1,1,1,1,0,0,0,0,0,0,0,0},//11
                { 0,0,1,0,0,0,1,1,1,1,0,0,0,0,0},//12
                { 0,0,1,0,0,0,0,0,0,1,1,1,0,0,0},//13
                { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},//14
                { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},//15


            };
            if (matrix[y - 1, x - 1] == 1)
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
