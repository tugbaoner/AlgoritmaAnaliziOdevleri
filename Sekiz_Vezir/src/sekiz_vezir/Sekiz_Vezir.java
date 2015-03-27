/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package sekiz_vezir;

import java.util.Random;
import java.util.Scanner;

/**
 *
 * @author BM
 */
public class Sekiz_Vezir {

    
    public static void main(String[] args) {
     Vezir_fonk nesne =new Vezir_fonk();//--------------------fonksiyonların nesnesi
     
     Scanner cin=new Scanner(System.in);
     char tahta[][];
     int yedek[][];

     int vezirsayisi=8;
     
   
    
     tahta=new char[vezirsayisi][];
     yedek=new int[vezirsayisi][];
     for(int i=0;i<vezirsayisi;i++){
     tahta[i]=new char[vezirsayisi];
     yedek[i]=new int[vezirsayisi];
     }
     nesne.randumvezir(tahta,vezirsayisi);
     System.out.println("8 vezir  rastgele olarak yerleştirildi.");
     System.out.println();
     nesne.ekranabas(tahta, vezirsayisi);
     
     nesne.kesisimsayilari(tahta,yedek,vezirsayisi);
      System.out.println();
     
      nesne.cakismaBul(tahta);
      System.out.println("Her bir vezirin çakışma sayıları bulundu.");
      System.out.println();
     nesne.ekranabaskesisim(yedek,vezirsayisi);
     
     nesne.vezirleriyerlestir(tahta,yedek,vezirsayisi);
     System.out.println();
     System.out.println("Çakışma sayılarına göre en küçüğü bulundu ve vezirler yerleştirildi");
     nesne.ekranabas(tahta, vezirsayisi);
    }
}
    

