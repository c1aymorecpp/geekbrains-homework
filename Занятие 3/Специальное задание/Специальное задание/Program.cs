using System;
using System.ComponentModel.DataAnnotations;

namespace Специальное_задание
{
    class Program
    {
        static void Main(string[] args)
        {
            //ввод чисел в массив
            int[] numbers = new int[10];
                
            Console.WriteLine("Введите 10 чисел");
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                }
                
                //сортировка массива 
                int sort;
                for (int i = 0; i < numbers.Length-1; i++)
                {
                    for (int k = i + 1; k < numbers.Length; k++)
                    {
                        if (numbers[i] > numbers[k])
                        {
                            sort = numbers[i];
                            numbers[i] = numbers[k];
                            numbers[k] = sort;
                        }
                    }
                }
             
                // вывод чисел
                Console.WriteLine("Вывод чисел в порядке возрастания");
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        Console.WriteLine(numbers[i]);
                    }
                Console.ReadLine();
        }
    }
}