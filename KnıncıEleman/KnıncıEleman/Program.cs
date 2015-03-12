using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KnıncıEleman
{
    class Program
    {
        private static void KnıncıEleman(int[] dizi, int k)
        {
            for (int i = 0; i < dizi.Length - 1; i++)  // Bubble Sort ile diziyi sıralıyoruz .
            {
                for (int j = 1; j < dizi.Length - i; j++)
                {
                    if (dizi[j] < dizi[j - 1])
                    {
                        int gecici = dizi[j - 1];
                        dizi[j - 1] = dizi[j];
                        dizi[j] = gecici;
                    }
                }
            }

            Console.WriteLine("k.eleman:" + dizi[k - 1]);  // sıralı dizinin k.elemanını ekrana yazılıyor.

        }
        static void Main(string[] args)
        {   
            int k=0;
            Console.WriteLine("Kaç elemanlı dizi olsun istersin?");
            int sayi = Convert.ToInt32(Console.ReadLine()); // dizinin eleman sayısı klavyeden okunuyor.
            int[] dizi = new int[sayi];
            Random RasgeleSayi = new Random(); // randomla sayi üretmek için rasgele nesnesi oluşturuluyor.
            for (int i = 0; i < sayi; i++)
            {
                dizi[i] = RasgeleSayi.Next(1, 100); // diziye dizinin eleman sayısı kadar 1 ile 100 arasında sayı atıyor.
                
            }
            for (int i = 0; i < sayi; i++)
            {
                Console.Write(dizi[i] + "-");
                
            }
            Console.WriteLine();
            Console.Write("k sayisini giriniz: "); // getirilecek olan k sayısı
            k=Convert.ToInt32(Console.ReadLine()); // k sayısı klavyeden okunuyor.
            KnıncıEleman(dizi,k);

            Console.ReadLine();
        }

        
    }
}
