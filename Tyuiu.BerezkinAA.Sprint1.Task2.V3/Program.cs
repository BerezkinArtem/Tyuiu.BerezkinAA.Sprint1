using Tyuiu.BerezkinAA.Sprint1.Task2.V3.Lib;

namespace Tyuiu.BerezkinAA.Sprint1.Task2.V3
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
            Console.WriteLine("* Задание #2                                                                      *");
            Console.WriteLine("* Вариант #3                                                                     *");
            Console.WriteLine("* Выполнил: Березкин Артем Андреевич | ИСПб-24-1                                  *");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                        *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,         *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.                     *");
            Console.WriteLine("*                                                                                 *");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                *");
            Console.WriteLine("***********************************************************************************");

            int x;

            Console.WriteLine("Время в часах:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                      *");
            Console.WriteLine("***********************************************************************************");

            Console.WriteLine("Время в минутах:" + ds.ConvertHourToMin(x));
            Console.ReadKey();

        }
    }
}
