using Tyuiu.BerezkinAA.Sprint1.Task3.V1.Lib;
namespace Tyuiu.BerezkinAA.Sprint1.Task3.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double r = 1;
            double h = 2;
            double wait = 6.28;
          
            var res = ds.CylinderVolume(r, h);
            Assert.AreEqual(wait, res);

        }
    }
}