using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaxSUBsuM2
{
    class Program
    {
        static private int bas = 0;
        static private int son = -1;


        static void Main(string[] args)
        {
            int maxTop;
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

            maxTop = MaxSUBsuM(dizi);
            Console.WriteLine("maxTop = " + maxTop);
            for (int l = bas; l <= son; l++)
            {
                Console.Write("dizi[" + l + "]  ");
            }
            Console.ReadLine();
        }

        private static int MaxSUBsuM(int[] dizi)
        {
            int maxTop = 0;
            for (int i = 0; i < dizi.Length; i++)
            {
                for (int j = i; j < dizi.Length; j++)
                {
                    int thisTop = 0;
                    for (int k = i; k <= j; k++)
                    {
                        thisTop += dizi[k];
                        
                    }
                    if (thisTop > maxTop)
                    {
                        maxTop = thisTop;
                        bas = i;
                        son = j;

                    }
                }
            }
            return maxTop;
        }
    }
}
