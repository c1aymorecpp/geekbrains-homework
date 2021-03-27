using System;

namespace Урок_4_Задание_1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Введите имя");
                string firstName = Console.ReadLine();
                Console.WriteLine("Введите фамилию");
                string lastName = Console.ReadLine();
                Console.WriteLine("Введите отчество");
                string patronymic = Console.ReadLine();
                string fullName = GetFullName(firstName, lastName, patronymic);
                Console.WriteLine(fullName);
            }
        }

        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            return (lastName + " " + firstName + " " + patronymic);
        }
    }
}


