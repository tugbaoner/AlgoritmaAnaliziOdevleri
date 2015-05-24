
import java.util.EmptyStackException;
import java.util.Random;
import java.util.Stack;

/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
/**
 *
 * @author acer
 */
public class StackDemo {

    static void showpush(Stack st, int a) {
        st.push(new Integer(a));
        System.out.println("push(" + a + ")");
        System.out.println("stack: " + st);
    }

    static void showpop(Stack st) {
        System.out.print("pop -> ");
        Integer a = (Integer) st.pop();
        System.out.println(a);
        System.out.println("stack: " + st);
    }

    public static void main(String[] args) {
        Random rndSayi = new Random();
        Stack st = new Stack();
        int sayi;
        System.out.println("stack: " + st);
        for (int i = 0; i < 10; i++) {
            sayi = rndSayi.nextInt(1000);
            showpush(st, sayi);

        }
        try {
            showpop(st);
        } catch (EmptyStackException e) {
            System.out.println("empty stack");
        }
    }
}
