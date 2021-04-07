using System;
using System.IO;

namespace Урок_5_Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            currentTime();
        }

        static void currentTime() // метод по записи текущего времени в файл
        {
            string filename = "startup.txt";
            string time = DateTime.Now.ToLongTimeString();
            File.WriteAllText(filename, "Эта программа дописывает текущее время на следующей строке.");
            File.AppendAllText(filename, Environment.NewLine); // вставляем перенос строк
            File.AppendAllText(filename, time); // записываем в файл текущее время
        }
    }
}