
using Tyuiu.RomanovMV.Sprint2.Task6.V15.Lib;

namespace Tyuiu.RomanovMV.Sprint2.Task6.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Романов М. В. | ИИПБ-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт №2                                                               *");
            Console.WriteLine("* Тема: Получение результата из switch                                    *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Романов Максим Викторович | ИИПБ-26-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу,которая использует сокращенную форму записи оператора*");
            Console.WriteLine("* switch вычисляет требуемое значение и возвращает результат.             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Дано целое число k(1 <= k <= 365). Определить, каким днем недели        *");
            Console.WriteLine("* (понедельником, вторником, …, субботой или воскресеньем) является       *");
            Console.WriteLine("* k-й день не високосного года, в котором 1 января понедельник.           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите номер дня ");
            int k = Convert.ToInt32(Console.ReadLine());

            if (k < 0 || k > 365)
            {
                Console.WriteLine("Введено неверное значение");
            }
            else
            {
                string name = ds.FindDayName(k);

                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
                Console.WriteLine("***************************************************************************");

                Console.WriteLine("Ваш день это - " + name);

                Console.ReadLine();
            }
        }
    }
}