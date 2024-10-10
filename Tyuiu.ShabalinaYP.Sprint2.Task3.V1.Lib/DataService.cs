using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ShabalinaYP.Sprint2.Task3.V1.Lib
{
    public class DataService : ISprint2Task3V1
    {
        public double Calculate(double x)
        {
            double res;
            if (x == 2)
            {
                res = x + (15 / x);
            }
            else
            {
                if ((x > -5) && (x < 3))
                {
                    res = x + 10*x - (1/x);
                }
                else
                {
                    if (x < -5)
                    {
                        res = x + 10 * x - (1 / (Math.Pow(x, 3) + 3));
                    }
                    else
                    {
                        res = Math.Pow(Math.E, x) - 12*x + Math.Cos(x);
                    }
                }
            }
            return Math.Round(res, 3);
        }
    }
}
