/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package amortizedcost;

/**
 *
 * @author acer
 */
public class AmortizedCost {

   static int newSize = 1000;
    static int[] dizi = new int[newSize];
    static int i = 0;

    public static void main(String[] args) {
       for (i = 0; i < 1001; i++) {

            if (i >= dizi.length) {
                System.out.println("dizi resize edilmeden önceki boyutu :"+i);
                int newSize = i * 2;
                int yeniDizi[] = new int[newSize];

                for (int i = 0; i < dizi.length; i++) {
                    yeniDizi[i] = dizi[i];

                }

                dizi = new int[newSize];
                for (int i = 0; i < yeniDizi.length; i++) {
                    dizi[i] = yeniDizi[i];

                }
               
            }

            dizi[i] = i;
            System.out.println("dizinin"+(i+1)+". elmani:"+dizi[i]);
        }
       
        System.out.println("dizinin yeni boyutu : "+dizi.length);

    }

    
}
