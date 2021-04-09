using System;
using System.Diagnostics;

namespace Task_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            processList();
            Console.WriteLine("Введите имя или ID процесса который вы хотите закрыть");
            string userAnswer = Console.ReadLine();
            processClose(userAnswer);
        }
        
        //метод закрывающий процесс
        static void processClose(string userAnswer)
        {
            Process[] processes = Process.GetProcesses();

            foreach (Process process in Process.GetProcesses())
            {
                if (userAnswer == process.ProcessName)
                {
                    process.Kill();
                }
                
                else if (userAnswer == process.Id.ToString())
                {
                    process.Kill();
                }
            }
        }
        // метод по получению списка процессов
        static void processList()
        {
            foreach (Process process in Process.GetProcesses())
            {
                // выводим id и имя процесса
                Console.WriteLine($"Name: {process.ProcessName} ID: {process.Id}");
            }
        }
    }
}