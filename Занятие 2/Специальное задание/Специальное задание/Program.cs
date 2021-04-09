using System;

namespace Специальное_задание
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, result = 0;
            Console.WriteLine("Введите число: ");
            number = Convert.ToInt32(Console.ReadLine()); // запрашиваем число

            while (number > 0) // условие - пока число будет больше нуля, выполняем:
            {
                result *= 10;
                result += number % 10;
                number /= 10;
            }

            Console.WriteLine(result); // выводим результат на экран
        }
    }
}