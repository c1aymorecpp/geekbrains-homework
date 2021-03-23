using System;
using System.Diagnostics.Tracing;

namespace Урок_3_Задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = null;
            string result = null;
                Console.WriteLine("Введите строку");
                word = Console.ReadLine();
                    for (int i = word.Length - 1; i >= 0; i--)
                    { 
                        result += word[i];
                    }
                    Console.WriteLine(result);
        }
    }
}