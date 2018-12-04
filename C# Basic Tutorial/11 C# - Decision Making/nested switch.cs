using System;

namespace DecisionMaking {
   class Program {
      static void Main(string[] args) {
         int a = 100;
         int b = 200;
         
         switch (a) {
            case 100: 
            Console.WriteLine("This is part of outer switch ");
            
            switch (b) {
               case 200:
               Console.WriteLine("This is part of inner switch ");
               break;
            }
            break;
         }
         Console.WriteLine("Exact value of a is : {0}", a);
         Console.WriteLine("Exact value of b is : {0}", b);
         Console.ReadLine();
      }
   }
} 
/*
result 

This is part of outer switch
This is part of inner switch
Exact value of a is : 100
Exact value of b is : 200

*/