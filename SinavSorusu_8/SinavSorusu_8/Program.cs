using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SinavSorusu_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayi giriniz:");
            int sayi = Int32.Parse(Console.ReadLine());
            int[] dizi = new int[sayi];
            int[] dizi2 = new int[sayi];
            int k=0;  
            Random rasgele = new Random();
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rasgele.Next(1,100);
            }
            

            
            Console.WriteLine("Dizinin elemanlaının tersten dizilimi");

            for (int j = dizi.Length-1; j >= 0; j--)
            {
                Console.WriteLine(dizi[j]);
            }


            Console.ReadLine();

        }
    }
}
