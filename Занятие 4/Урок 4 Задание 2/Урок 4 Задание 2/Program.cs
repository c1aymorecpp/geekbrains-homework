using System;
using System.Security.Cryptography;

namespace Урок_4_Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine(); // запросили строку у пользователя
            string[] words = str.Split(' '); // разделили строку на слова
            int result = 0;
            foreach(string word in words) // цикл перебора слов 
            {
              int value = Convert.ToInt32(word); // присваиваем string значение word в числовое int
              result += value;
            }

            Console.WriteLine(result);
        }
    }
}