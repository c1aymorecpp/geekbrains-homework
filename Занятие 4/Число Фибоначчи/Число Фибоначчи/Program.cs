using System;

namespace Число_Фибоначчи
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Фибоначчи под номером #{0} это {1}", n, Fibonachi(n)); // вывод результата
        }
        
        static int Fibonachi(int n, int x1 = 0, int x2 = 1) // вычисление числа фибоначчи
        {
            {
                if (n <= 1) return x1;
                int x;
                for (int i = 2; i < n; i++)
                {
                    x = x1;
                    x1 = x2;
                    x2 = x2 + x;
                }
                return x2;
            }
        }
    }
}
