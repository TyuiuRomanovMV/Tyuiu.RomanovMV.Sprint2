

using Tyuiu.RomanovMV.Sprint2.Task5.V5.Lib;

namespace Tyuiu.RomanovMV.Sprint2.Task5.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Романов М. В. | ИИПБ-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт №2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Романов Максим Викторович | ИИПБ-26-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет        *");
            Console.WriteLine("* требуемое значение и возвращает результат.                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Игральным картам условно присвоены следующие порядковые номера в        *");
            Console.WriteLine("* зависимости от их достоинства:«валету» — 11, «даме» — 12, «королю» — 13,*");
            Console.WriteLine("* «тузу» — 14. Порядковые номера остальных карт соответствуют их названиям*");
            Console.WriteLine("*(«шестерка», «девятка» и т. п.) По заданному номеру карты k (6 <=k <= 14)*");
            Console.WriteLine("* определить достоинство соответствующей карты.                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите значение карты ");
            int x = Convert.ToInt32(Console.ReadLine());

            string name = ds.FindCardValue(x);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Ваша карта - это " + name);

            Console.ReadLine();
        }
    }
}