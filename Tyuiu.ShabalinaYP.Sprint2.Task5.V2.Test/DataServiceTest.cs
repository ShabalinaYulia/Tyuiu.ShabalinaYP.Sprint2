using Tyuiu.ShabalinaYP.Sprint2.Task5.V2.Lib;
namespace Tyuiu.ShabalinaYP.Sprint2.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindMouthSeason()
        {
            DataService ds = new DataService();
            int value = 4;
            string wait = "Весна";
            string res = ds.FindMonthSeason(value);
            Assert.AreEqual(wait, res);
        }
    }
}