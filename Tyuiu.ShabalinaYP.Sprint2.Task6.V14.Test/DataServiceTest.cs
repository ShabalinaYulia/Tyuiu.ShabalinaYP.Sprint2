using Tyuiu.ShabalinaYP.Sprint2.Task6.V14.Lib;
namespace Tyuiu.ShabalinaYP.Sprint2.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDayName()
        {
            DataService ds = new DataService();
            int k = 14;
            int d = 7;
            string res = ds.FindDayName(k, d);
            string wait = "суббота";
            Assert.IsTrue(res == wait);

            
        }
    }
}