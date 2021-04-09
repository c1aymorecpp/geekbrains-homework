using System;
using System.IO;

namespace Урок_5_Задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] array = new byte[5]; // создание массива
            for (int i = 0; i < array.Length; i++) // заполнение массива с клавиатуры
            {
                array[i] = Convert.ToByte(Console.ReadLine());
            }
            
            File.WriteAllBytes("bytes.bin", array); // запись массива в бинарный файл
        }
    }
}