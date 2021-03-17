using System;

namespace Задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите любое число.");
            int number = Convert.ToInt32(Console.ReadLine());
            if ((number % 2) == 0)  // проверка , является ли остаток от деления нулем.
                Console.WriteLine("Ваше число является четным.");
            else
                Console.WriteLine("Ваше число является нечетным");
        }
    }
}
