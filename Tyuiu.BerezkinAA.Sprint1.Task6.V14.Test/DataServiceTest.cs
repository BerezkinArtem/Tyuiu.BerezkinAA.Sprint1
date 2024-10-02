using Tyuiu.BerezkinAA.Sprint1.Task6.V14.Lib;

namespace Tyuiu.BerezkinAA.Sprint1.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string a = "??";
            bool res = ds.CheckLowerCaseRusLetters(a);
            bool wait = false;
            Assert.AreEqual(res, wait);

        }
    }
}