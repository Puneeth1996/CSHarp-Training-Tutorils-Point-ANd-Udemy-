

/*
A return statement can be used for returning only one value from a function. However, using output parameters, you can return two values from a function. 
*/


using System;

namespace CalculatorApplication {
   class NumberManipulator {
      public void getValues(out int x, out int y ) {
          Console.WriteLine("Enter the first value: ");
          x = Convert.ToInt32(Console.ReadLine());
          
          Console.WriteLine("Enter the second value: ");
          y = Convert.ToInt32(Console.ReadLine());
      }
      static void Main(string[] args) {
         NumberManipulator n = new NumberManipulator();
         
         /* local variable definition */
         int a , b;
         
         /* calling a function to get the values */
         n.getValues(out a, out b);
         
         Console.WriteLine("After method call, value of a : {0}", a);
         Console.WriteLine("After method call, value of b : {0}", b);
         Console.ReadLine();
      }
   }
}


/*
Result 

Enter the first value:
7
Enter the second value:
8
After method call, value of a : 7
After method call, value of b : 8
*/