using System;

namespace Урок_3_Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует программа - Телефонный справочник");
            // объявление массива
            string[,] phoneGuide = new string[5, 2]
            {
                {"Богомолов Никита", "bogomolovn@gmail.com"},
                {"Горшков Тимофей", "timofey31reg@mail.ru"},
                {"Назаров Никита", "naznik777@yandex.ru"},
                {"Гончаров Олег", "olegolegovich@yahoo.com"},
                {"Павлова Кира", "kiramaks291@outlook.com"}
            };

            // условный оператор
            Console.WriteLine("Что-бы увидеть список контактов напишите go, если хотите выйти из программы - q.");
            string userAnswer = Console.ReadLine();
                if (userAnswer == "q")
                    return;
                else if (userAnswer == "go")
                {
                    for (int i = 0; i < phoneGuide.Length; i++)
                    {
                        for (int j = 0; j < phoneGuide.GetLength(1); j++)
                        {
                            Console.WriteLine("{0,5}", phoneGuide[i, j]);
                        }
                        Console.WriteLine();
                    }
            }
        }
    }
}