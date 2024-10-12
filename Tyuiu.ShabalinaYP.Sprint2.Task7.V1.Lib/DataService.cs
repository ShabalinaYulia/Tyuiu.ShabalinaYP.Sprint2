using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ShabalinaYP.Sprint2.Task7.V1.Lib
{
    public class DataService : ISprint2Task7V1
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if ((Math.Sin(x) >= Math.Sin(45 * (180 / Math.PI))) && (Math.Sin(x)>= Math.Sin(-45*(180/Math.PI))))
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
