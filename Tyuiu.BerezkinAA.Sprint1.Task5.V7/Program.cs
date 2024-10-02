using Tyuiu.BerezkinAA.Sprint1.Task5.V7.Lib;

namespace Tyuiu.BerezkinAA.Sprint1.Task5.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Березкин А. А. | ИСПб-24-1";
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* Спринт #1                                                                         *");
            Console.WriteLine("* Тема: Преобразование типов и класс Convert                                        *");
            Console.WriteLine("* Задание #5                                                                        *");
            Console.WriteLine("* Вариант #7                                                                        *");
            Console.WriteLine("* Выполнил: Березкин Артем Андреевич | ИСПб-24-1                                    *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                          *");
            Console.WriteLine("* Определить h – полное количество часов прошедших от начала суток до того момента, *");
            Console.WriteLine("* когда часовая стрелка повернулась на f градусов.                                  *");
            Console.WriteLine("*                                                                                   *");
            Console.WriteLine("*************************************************************************************");   
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                  *");
            Console.WriteLine("*************************************************************************************");

            double f;

            Console.WriteLine("Введите значение F:");
            f = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                        *");
            Console.WriteLine("*************************************************************************************");

            Console.WriteLine(ds.AngleToHoursMinutes(f));
            Console.ReadKey();

        }
    }
}
