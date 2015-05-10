/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package pointerbasedındex;

import java.util.Scanner;

/**
 *
 * @author acer
 */
public class PointerBasedIndex {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Bagli_Liste listem= new Bagli_Liste();
        Scanner s = new Scanner(System.in);
        listem.ekle(5);
        listem.ekle(14);
        listem.ekle(98);
        listem.ekle(123);
        listem.ekle(85);
        listem.ekle(91);
        listem.ekle(61);
        listem.ekle(78);
        listem.ekle(17);
        
        listem.Listele();
        System.out.println("****************************");
        System.out.println("Hangi indexteki sayıyı bulmak istiyorsun?");
        int sayi = s.nextInt();
        listem.IndexliErisim(sayi);
        
        



        
    }
}
