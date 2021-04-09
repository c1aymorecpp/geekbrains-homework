using System;

namespace Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите пожалуйста минимальную температуру за сутки");
            int minTemp = Convert.ToInt32(Console.ReadLine()); // пользователь вводит минимальную температуру
            Console.WriteLine("Введите пожалуйста максимальную температуру за сутки");
            int maxTemp = Convert.ToInt32(Console.ReadLine()); // пользователь вводит максимальную температуру
            int avgTemp = (maxTemp + minTemp) / 2; // получаем среднюю температуру

                Console.WriteLine("Напишите пожалуйста порядковый номер текущего месяца.");
                double numberOfMonth = Convert.ToDouble(Console.ReadLine());
                string monthTitle = null;
            
                switch (numberOfMonth)
                {
                    case 1:
                        monthTitle = "Январь";
                        break;
                    case 2:
                        monthTitle = "Февраль";
                        break;
                    case 3:
                        monthTitle = "Март";
                        break;
                    case 4:
                        monthTitle = "Апрель";
                        break;
                    case 5:
                        monthTitle = "Май";
                        break;
                    case 6:
                        monthTitle = "Июнь";
                        break;
                    case 7:
                        monthTitle = "Июль";
                        break;
                    case 8:
                        monthTitle = "Август";
                        break;
                    case 9:
                        monthTitle = "Сентябрь";
                        break;
                    case 10:
                        monthTitle = "Октябрь";
                        break;
                    case 11:
                        monthTitle = "Ноябрь";
                        break;
                    case 12:
                        monthTitle = "Декабрь";
                        break;
            }
            if (numberOfMonth == 1 || numberOfMonth == 2 || numberOfMonth == 12 && avgTemp > 0)
                Console.WriteLine("Дождливая зима");
            else
                Console.WriteLine($"Ваш месяц {monthTitle} , и средняя температура {avgTemp}");

            {

            }
        }
    }
}
