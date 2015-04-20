using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinarySearchTree
{
    class Program
    {
       static void Main(string[] args)
        {
            BinarySearchTree newbinarytree = new BinarySearchTree();
            Random RasgeleSayi = new Random();
            for (int k = 0; k < 10; k++)
            {
                int sayi = RasgeleSayi.Next(1, 100);

                newbinarytree.Insert(sayi);

            }

            //newbinarytree.Insert(23);
            //newbinarytree.Insert(45);
            //newbinarytree.Insert(16);
            //newbinarytree.Insert(37);
            //newbinarytree.Insert(3);
            //newbinarytree.Insert(99);
            //newbinarytree.Insert(22);
            Console.WriteLine("Inorder traversal: ");
            newbinarytree.InOrder(newbinarytree.root);
            Console.Write("Aranacak sayiyi giriniz:");
            int arananSayi = Int32.Parse(Console.ReadLine());

            newbinarytree.find(newbinarytree.root, arananSayi);
            Console.WriteLine("");
            Console.ReadLine();
        }
    }
}
