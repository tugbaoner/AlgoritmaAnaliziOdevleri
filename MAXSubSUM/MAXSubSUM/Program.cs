using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MAXSubSUM
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;

            Console.WriteLine("Dizinizin eleman sayisini giriniz");
            int indis = Int32.Parse(Console.ReadLine());
            int[] dizi = new int[indis];
            Random rasgele = new Random();
            for (int k = 0; k < dizi.Length; k++)
            {
                int sayi = rasgele.Next(-50, 50);
                dizi[k] = sayi;
            }

            Console.WriteLine("Dizinin elemanları");
            for (int j = 0; j < dizi.Length; j++)
            {
                Console.WriteLine("dizinin " + (j + 1) + ". elemani :" + dizi[j]);
            }

            for (int i = 0; i < dizi.Length; i++)
            {
                toplam = toplam + dizi[i];
            }
            Console.WriteLine("dizinin elemanlari toplami =" + toplam);
            Console.ReadLine();
            
        }
    }
}
