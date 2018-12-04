using System;

namespace Loops {
   class Program {
      static void Main(string[] args) {
         for (; ; ) {
            Console.WriteLine("Hey! I am Trapped");
         }
      }
   }
} 


//A loop becomes infinite loop if a condition never becomes false. The for loop is traditionally used for this purpose.
//When the conditional expression is absent, it is assumed to be true. 