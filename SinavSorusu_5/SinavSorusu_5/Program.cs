using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SinavSorusu_5
{
    class Program
    {
        private static Search(Node key, Node t) { 
            if(t==null)                    
               return null;                 
            else if(key<t.key)             
                return Search(key,t.leftChild);  
           else if(key>t.key)             
                return Search(key,t.rightChild); 
           else                           
               return t;    
        }  
        static void Main(string[] args){
        }
        
        
    }
}
