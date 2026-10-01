using Tyuiu.KonevkaAS.Sprint1.Task0.V0.Lib;
namespace Tyuiu.KonevkaAS.Sprint1.Task0.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
               DataService  ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Коневка А. С. | ПИНб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                              *");
            Console.WriteLine("* Тема: Создание итогового решения по спринту                             *");
            Console.WriteLine("*Задание #0                                                              *");
            Console.WriteLine("*Вариант #15                                                               *");
            Console.WriteLine("*Выполнил: Коневка Алексей Станиславович | ПИНб-26-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать консольную программу на C#, которая суммирует значения двух    *");
            Console.WriteLine("* одинаковых массивов по длинне.                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* 20 - (2*2-8)                                                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate());

            Console.ReadLine();

        }
    }
}
