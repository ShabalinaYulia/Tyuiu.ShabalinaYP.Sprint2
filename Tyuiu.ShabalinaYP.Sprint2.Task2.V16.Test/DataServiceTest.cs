using Tyuiu.ShabalinaYP.Sprint2.Task2.V16.Lib;
namespace Tyuiu.ShabalinaYP.Sprint2.Task2.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            int x = 6;
            int y = 4;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = false;
            Assert.AreEqual(wait, res);
            
        }
    }
}