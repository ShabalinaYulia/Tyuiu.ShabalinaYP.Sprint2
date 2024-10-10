using Tyuiu.ShabalinaYP.Sprint2.Task3.V1.Lib;
namespace Tyuiu.ShabalinaYP.Sprint2.Task3.V1.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidCalculateA()
        {
            DataService ds = new DataService();
            double x = 5;
            double res = ds.Calculate(x);
            double wait = 88.697;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCalculateB()
        {
            DataService ds = new DataService();
            double x = 2;
            double res = ds.Calculate(x);
            double wait = 9.5;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCalculateC()
        {
            DataService ds = new DataService();
            double x = -3;
            double res = ds.Calculate(x);
            double wait = -32.667;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCalculateD()
        {
            DataService ds = new DataService();
            double x = -6;
            double res = ds.Calculate(x);
            double wait = -65.995;
            Assert.AreEqual(wait, res);
        }
    }
}