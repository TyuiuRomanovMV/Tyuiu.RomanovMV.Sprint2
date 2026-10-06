
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.RomanovMV.Sprint2.Task5.V5.Lib
{
    public class DataService : ISprint2Task5V5
    {
        public string FindCardValue(int value)
        {
            string name;
            switch (value)
            {
                case 6:
                    name = "Шестрёрка";
                    break;
                case 7:
                    name = "Семёрка";
                    break;
                case 8:
                    name = "Восьмёрка";
                    break;
                case 9:
                    name = "Девятка";
                    break;
                case 10:
                    name = "Десятка";
                    break;
                case 11:
                    name = "Валет";
                    break;
                case 12:
                    name = "Дама";
                    break;
                case 13:
                    name = "Король";
                    break;
                case 14:
                    name = "Туз";
                    break;
                default:
                    throw new ArgumentException($"Номер карты должен быть от 6 до 14. Значение {value} - не подходит.");
            }
            return name;
        }
    }
}
