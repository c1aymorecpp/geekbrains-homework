using System;
using System.IO;

namespace Урок_5_Задание_1
{
    class Program
    {
        static void Main()
        {
            writeInFile();
        }

        static void writeInFile() // метод записывающий информацию в файл
        {
            string filename = "homework.txt"; 
            string str = Console.ReadLine(); // ввод информации в переменную str
            File.WriteAllText(filename, str); // запись переменной str в файл
        }
    }

}
