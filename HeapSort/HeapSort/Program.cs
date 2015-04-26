using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeapSort
{
    class HeapSort
    {
         
      public void sort(int [] dizi)
    {
      int turSayısı;
      int gecici;
	  // sıralama işlemi burda başlıyor
      for (turSayısı=((dizi.Length / 2) - 1);turSayısı>=0; turSayısı--)
      {
        yıg(turSayısı, dizi.Length,dizi);
      }
 
      for (int i = dizi.Length - 1; i >= 1; i--)
      {
        gecici = dizi[0];
        dizi[0] = dizi[i];
        dizi[i] = gecici;
        yıg(0, i - 1,dizi);
      }
    }
 
    public void yıg(int kok, int altDugum,int [] dizi)
    {
      //yığma işlemi burada başlıyor düğümlerdeki elemanlar karşılaştırılıyor
     // ve bir üst düğüme kaydırılıyor
      bool islemTamam = false;
      int dugumSayısı;
      int gecici;
 
      while ((kok * 2 <= altDugum) && (!islemTamam))
      {
        if (kok * 2 == altDugum)
          dugumSayısı = kok * 2;
        else if (dizi[kok * 2] > dizi[kok * 2 + 1])
          dugumSayısı = kok * 2;
        else
          dugumSayısı = kok * 2 + 1;
 
        if (dizi[kok] < dizi[dugumSayısı])
        {
          gecici = dizi[kok];
          dizi[kok] = dizi[dugumSayısı];
          dizi[dugumSayısı] = gecici;
          kok = dugumSayısı;
        }
        else
        {
          islemTamam = true;
        }
      }
    }
 
    public void yazdır(int [] dizi)
 {
 
	foreach (int sayılar in dizi) {
		Console.Write(sayılar+"  " );
	}
	Console.WriteLine("\n");
 }
 
    public static void Main()
    {
        HeapSort heap = new HeapSort();
        int[] dizi = { 3, 44, 11, 55, 6, 77, 9, 111, 49 };
        Console.WriteLine("\n");
        Console.Write(@" Sıralanmamış dizi elemanları : ");
        heap.yazdır(dizi);
        heap.sort(dizi);
        Console.Write(@" Sıralanmış dizi elemanları   : ");
        heap.yazdır(dizi);
        Console.ReadLine();
 
    }
 
  }//
    }

