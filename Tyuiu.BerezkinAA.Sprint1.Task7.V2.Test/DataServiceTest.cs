using Tyuiu.BerezkinAA.Sprint1.Task7.V2.Lib;


namespace Tyuiu.BerezkinAA.Sprint1.Task7.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 3; 
            double y = 2;
            double wait = 0.533;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}