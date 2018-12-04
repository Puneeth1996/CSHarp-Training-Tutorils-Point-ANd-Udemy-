using System;

namespace VariableDefinition {
   class Program {
      static void Main(string[] args) {
         short a;
         int b ;
         double c;

         /* actual initialization */
         a = 10;
         b = 20;
         c = a + b;
         Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);
         Console.ReadLine();
		 
		 
		 /*Accepting Values from User*/
		 int num;
		 num = Convert.ToInt32(Console.ReadLine());
		 /*The function Convert.ToInt32() converts the data entered by the user to int data type, because Console.ReadLine() accepts the data in string format.*/
		 
		 
      }
   }
}


//result −

//a = 10, b = 20, c = 30