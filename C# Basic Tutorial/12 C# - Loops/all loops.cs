//all types of loops while 		do...while		for loops 


using System;

namespace Loops {
   class Program {
      static void Main(string[] args) {
	  
		 /*this below do...while loop */
				
         /* local variable definition */
         int a = 10;
         
         /* do loop execution */
         do {
            Console.WriteLine("value of a: {0}", a);
            a = a + 1;
         } 
         while (a < 20);
         
		 
		 
		 
		 /*this below while loop */
		 /* local variable definition */
         int b = 10;

         /* while loop execution */
         while (b < 20) {
            Console.WriteLine("value of a: {0}", b);
            b++;
         }
		 
		 
		 
         
		 /*this below for loop */
		 /* for loop execution */
         for (int c = 10; c < 20; c = c + 1) {
            Console.WriteLine("value of c: {0}", c);
         }
         Console.ReadLine();
		 
		 
      }
   }
} 