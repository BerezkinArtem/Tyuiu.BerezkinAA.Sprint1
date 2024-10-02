using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.BerezkinAA.Sprint1.Task7.V2.Lib
{
    public class DataService : ISprint1Task7V2
    {
        public double Calculate(double x, double y)
        {
            double res = Math.Round((Math.Sin(x) + Math.Sin(y)) / (Math.Cos(x) - Math.Cos(y)) * Math.Tan(x * y), 3);
            return res;
        }
    }
}
