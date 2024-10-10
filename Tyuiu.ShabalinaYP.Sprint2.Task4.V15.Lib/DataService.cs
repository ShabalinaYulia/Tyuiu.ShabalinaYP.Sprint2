using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ShabalinaYP.Sprint2.Task4.V15.Lib
{
    public class DataService : ISprint2Task4V15
    {
        public double Calculate(double x, double y)
        {
            double z = ((Math.Pow(x, 0.5) / 2) > (Math.Pow(y, 0.5) - 20)) ? Math.Pow((3 + 2 / (Math.Pow(y, 2))), x) : Math.Cos(x) + (12 /Math.Pow(x, 2));
            return Math.Round(z, 3);
        }
    }
}
