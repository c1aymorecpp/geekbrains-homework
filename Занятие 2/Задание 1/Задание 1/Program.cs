using System;

namespace Задание_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите пожалуйста мнимальную температуру за сутки"); 
            int minTemp = Convert.ToInt32(Console.ReadLine()); // пользователь вводит минимальную температуру
            Console.WriteLine("Введите пожалуйста максимальную температуру за сутки");
            int maxTemp = Convert.ToInt32(Console.ReadLine()); // пользователь вводит максимальную температуру
            int avgTemp = (maxTemp + minTemp) / 2; // получаем среднюю температуру
            Console.WriteLine($"Среднесуточная температура: = {avgTemp}");
        }
    }
}
