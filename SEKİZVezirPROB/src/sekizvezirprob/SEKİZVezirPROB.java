/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package sekizvezirprob;

/**
 *
 * @author acer
 */
public class SEKİZVezirPROB {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
       Vezir_Fonksiyonlarım nesne=new Vezir_Fonksiyonlarım();//--------------------fonksiyonların nesnesi

       
     char tahta[][];
     int yedek[][];

     int vezirsayisi=8;
     System.out.println("8 vezir üzerinde işlem yapıyoruz.");
   
    
     tahta=new char[vezirsayisi][];
     yedek=new int[vezirsayisi][];
     for(int i=0;i<vezirsayisi;i++){
     tahta[i]=new char[vezirsayisi];
     yedek[i]=new int[vezirsayisi];
     }
     nesne.randomvezir(tahta,vezirsayisi);
     System.out.println("8 vezir  rastgele olarak yerleştirildi.");
     System.out.println();
     nesne.ekranabas(tahta, vezirsayisi);
     
     nesne.kesisimsayilari(tahta,yedek,vezirsayisi);
      System.out.println();
      nesne.cakismaBul(tahta);
      
      System.out.println("Her bir vezirin gidebilecegi bütün durumların toplam çakışma sayıları bulundu.");
     nesne.ekranabaskesisim(yedek,vezirsayisi);
     
     nesne.vezirleriyerlestir(tahta,yedek,vezirsayisi);
     System.out.println();
     System.out.println("Çakışma sayılarına göre en küçüğü bulundu ve vezirler yerleştirildi");
     nesne.ekranabas(tahta, vezirsayisi);
    }
    
}
