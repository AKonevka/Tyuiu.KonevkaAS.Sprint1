using Tyuiu.KonevkaAS.Sprint1.Task2.V16.Lib;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Tyuiu.KonevkaAS.Sprint1.Task2.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Коневка А. С. | ПИНб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                              *");
            Console.WriteLine("* Тема: Создание итогового решения по спринту                             *");
            Console.WriteLine("*Задание #2                                                               *");
            Console.WriteLine("*Вариант #16                                                              *");
            Console.WriteLine("*Выполнил: Коневка Алексей Станиславович | ПИНб-26-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данныe  *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x;
            Console.WriteLine("Введите радиус круга: ");
            x = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.CalculatePerimetrCircle(x);
            double result = Math.Round(res, 3);
            Console.WriteLine("Периметр круга -  " + result);

            Console.ReadLine();
        }
    }
}
