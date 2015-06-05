using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SinavSorusu_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = { 0, 0, 0, 1, 1, 0, 1, 0, 0 ,0,0};
            
            int maxSifir = 0;
            int sifir = 0;
            

            for (int i = 0; i < dizi.Length; i++)
            {
                
                if (dizi[i] == 0)
                {
                    
                    sifir++;
                    if (sifir > maxSifir)
                    {
                        maxSifir = sifir;
                        
                     }
                 
                if (dizi[i] == 1)
                { 
                    sifir = 0;

                    }
               }
            }
            Console.WriteLine(maxSifir);
            Console.ReadLine();
        }
    }
}
