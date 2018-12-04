using System;

namespace CalculatorApplication {

   class NumberManipulator {
   
      public void swap(int x, int y) {
         int temp;
         
         temp = x; /* save the value of x */
         x = y;    /* put y into x */
         y = temp; /* put temp into y */
         
         
         Console.WriteLine("After swap, value of a : {0}", x);
         Console.WriteLine("After swap, value of b : {0}", y);
         
      }
      
      static void Main(string[] args) {
         NumberManipulator n = new NumberManipulator();
         
         /* local variable definition */
         int a = 100;
         int b = 200;
         
         Console.WriteLine("Before swap, value of a : {0}", a);
         Console.WriteLine("Before swap, value of b : {0}", b);
         
         /* calling a function to swap the values */
         n.swap(a, b);
         Console.ReadLine();
      }
   }
}

/*
result −

Before swap, value of a :100
Before swap, value of b :200
After swap, value of a :100
After swap, value of b :200
*/