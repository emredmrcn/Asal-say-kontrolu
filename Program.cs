using System;

namespace Asal_sayı_kontrolu
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayac = 0;
            Console.WriteLine("Sayıyı giriniz :");
            int sayi = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= sayi; i++) 
            {
                if (sayi % i == 0)
                { 
                    sayac ++;
            }
           }
            if (sayac ==2 )
            {
                Console.WriteLine("Girdiğiniz {0} sayısı Asal Sayıdır " , sayi);
            }
            else
            {
                Console.WriteLine("Girdiğiniz {0} sayısı Asal Sayı Değildir.", sayi);
            }

            Console.ReadKey();

        }
    }
}
