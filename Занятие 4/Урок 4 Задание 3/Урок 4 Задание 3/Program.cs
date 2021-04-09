using System;
using System.Threading;
using System.Xml;
using Microsoft.VisualBasic;

namespace Урок_4_Задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число от 1 до 12 для определения времени года");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            seasonOfTheYear(userNumber);
        }

        enum Season // перечисление
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }
        static void seasonOfTheYear(int userNumber) // метод по определению времени года
        {
            Season spring = Season.Spring;
            Season summer = Season.Summer;
            Season autumn = Season.Autumn;
            Season winter = Season.Winter;
        
               if (userNumber == 3 || userNumber == 4 || userNumber == 5)
                   Console.WriteLine(spring);
               
               else if (userNumber == 6 || userNumber == 7 || userNumber == 8)
                   Console.WriteLine(summer);

               else if (userNumber == 9 || userNumber == 10 || userNumber == 11)
                   Console.WriteLine(autumn);
               
               else if (userNumber == 12 || userNumber == 1 || userNumber == 2)
                   Console.WriteLine(winter);

               else
                   Console.WriteLine("Ошибка: введите число от 1 до 12");
            
        }
    }
}