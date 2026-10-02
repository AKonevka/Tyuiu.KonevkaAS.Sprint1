using Tyuiu.KonevkaAS.Sprint1.Task3.V19.Lib;
namespace Tyuiu.KonevkaAS.Sprint1.Task3.V19
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
            Console.WriteLine("*Задание #3                                                              *");
            Console.WriteLine("*Вариант #19                                                               *");
            Console.WriteLine("*Выполнил: Коневка Алексей Станиславович | ПИНб-26-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая печатает true или false в зависимости от    *");
            Console.WriteLine("* того, может ли шахматная фигура «Слон» с одного заданного поля          *");
            Console.WriteLine("* шахматной доски перейти за один ход на другое. Пользователь задаёт      *");
            Console.WriteLine("* координаты двух ячеек шахматной доски (x1 и y1, x2 и y2 каждое в        *");
            Console.WriteLine("* диапазоне от 1 до 8).                                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x1;
            Console.WriteLine("Введите x1: ");
            x1 = Convert.ToInt32(Console.ReadLine());
            int y1;
            Console.WriteLine("Введите y1: ");
            y1 = Convert.ToInt32(Console.ReadLine());
            int x2;
            Console.WriteLine("Введите x2: ");
            x2 = Convert.ToInt32(Console.ReadLine());
            int y2;
            Console.WriteLine("Введите y2: ");
            y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            if (ds.ElephCanMove(x1, x2, y1, y2))
            {
                Console.WriteLine("true");
            }
            else {
                Console.WriteLine("false");
            }

        }
    }
}
