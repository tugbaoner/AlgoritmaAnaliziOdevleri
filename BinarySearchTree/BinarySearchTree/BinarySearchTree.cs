using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinarySearchTree
{
   public class BinarySearchTree
   {
        public Node root;
        public void Insert(int i)
        {
            // yeni bir nesne oluşturuyoruz.
            Node newNode = new Node();
            newNode.Data = i;

            //Eğer kök düğüm boş ise
            if (root == null)
                root = newNode;
            else
            {
                // kök düğümü current düğüme ekliyoruz
                Node current = root;
                while (true)
                {
                    Node parent;
                    // Eğer i (Eklenecek  değer) kök düğüm değerinden küçük ise
                    if (i < current.Data)
                        //ve eğer kök düğümün solu null ise
                        if (current.Left != null)
                        {
                            current = current.Left;
                            continue;
                        }
                        else
                        {
                            current.Left = newNode;
                            parent = current;
                            break;
                        }
                    //Eğer i (Eklenecek değer) kök düğüm değerinden büyük ise
                    if (i > current.Data)
                        // ve eğer kök düğümün sağı  null değilse
                        if (current.Right != null)
                        {
                            current = current.Right;
                            continue;
                        }
                        else
                        {
                            current.Right = newNode;
                            parent = current;
                            break;
                        }
                }

            }

        }
        //InOrder Ağaç gezme(Traverse)
        public void InOrder(Node theRoot)
        {
            if (!(theRoot == null))
            {
                
                InOrder(theRoot.Left);
                theRoot.DisplayNode();
                InOrder(theRoot.Right);
            }
            
        }

        public Node find(Node theRoot,int aranan)
        {
            int sayac = 0;
            while (!(theRoot == null))
            {
                if (aranan.CompareTo(theRoot.Data)<0)
        
                {
                    theRoot = theRoot.Left;
                    sayac++;
                    
                }
                else if (aranan.CompareTo(theRoot.Data) > 0)
                {
                    theRoot = theRoot.Right;
                    sayac++;

                }
                else
                {
                Console.WriteLine("bulundu"+ theRoot.Data);
                Console.WriteLine(sayac+"adimda bulundu");
                return theRoot;
                }
                
            }
            Console.WriteLine("Aranilan eleman agacta yok");
            return null;
        }
    }
}
