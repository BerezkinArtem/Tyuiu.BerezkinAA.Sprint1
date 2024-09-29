using Tyuiu.BerezkinAA.Sprint1.Task1.V18.Lib;

namespace Tyuiu.BerezkinAA.Sprint1.Task1.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Березкин А. А. | ИСПб-24-1";
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* Спринт #1                                                                       *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                                *");
            Console.WriteLine("* Задание #1                                                                      *");
            Console.WriteLine("* Вариант #18                                                                     *");
            Console.WriteLine("* Выполнил: Березкин Артем Андреевич | ИСПб-24-1                                  *");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                        *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,         *");
            Console.WriteLine("* вычисляет результат по формуле (x * y) / (x + 1) - 3 и печатает его на экран    *");
            Console.WriteLine("*                                                                                 *");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                *");
            Console.WriteLine("***********************************************************************************");

            double x, y;

            Console.WriteLine("Введите значение X:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение Y:");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                      *");
            Console.WriteLine("***********************************************************************************");

            Console.WriteLine(ds.Calculate(x, y));

            Console.ReadLine();

        }
    }
}
