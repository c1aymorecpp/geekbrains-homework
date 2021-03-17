using System;

namespace Задание_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string marketName = "       ООО КАССОПТТОРГ";
            string adress = "Москва, Волгоградский проспект, ";
            int adressNumber = 26;
            decimal znKKT = 0472570020000241;
            string sistAdmin = "СИСТ. АДМИН.     ";
            double INN = 9721018628;
            decimal rnKKT = 0000000000018780;
            decimal FN = 99999078900003693;
            string site = "САЙТ ФНС        www.nalog.ru";
            string itog = "ИТОГ =      ";
            int summa = 50000;
            string nal = "НАЛИЧНЫМИ =     ";
            int nalsumm = 100000;
            string sdacha = "СДАЧА =     ";
            int sdachasumm = 50000;
            string sno = "СНО                ОСН";
            string fd = "ФД:3              ФП:4106393690";
            Console.WriteLine(marketName);
            Console.WriteLine(adress + adressNumber);
            Console.WriteLine($"ЗН ККТ        {znKKT}");
            Console.WriteLine(sistAdmin + DateTime.Now.ToShortDateString());
            Console.WriteLine($"ИНН           {INN}");
            Console.WriteLine($"РН ККТ          {rnKKT}");
            Console.WriteLine($"ФН            {FN}");
            Console.WriteLine(site);
            Console.WriteLine("        КАССОВЫЙ ЧЕК");
            Console.WriteLine($"{itog} {summa}");
            Console.WriteLine($"{nal} {nalsumm}");
            Console.WriteLine($"{sdacha} {sdachasumm}");
            Console.WriteLine(sno);
            Console.WriteLine(fd);



        }
    }
}
