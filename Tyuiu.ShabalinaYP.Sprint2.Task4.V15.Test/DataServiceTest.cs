
using Tyuiu.ShabalinaYP.Sprint2.Task4.V15.Lib;

namespace Tyuiu.ShabalinaYP.Sprint2.Task4.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double z = ds.Calculate(x, y);
            double wait = 3.5;
            Assert.AreEqual(wait, z);
        }
    }
}