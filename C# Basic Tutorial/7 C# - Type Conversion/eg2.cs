
//Explicit type conversion


//Eg2
using System;

namespace TypeConversionApplication {
   class StringConversion {
      static void Main(string[] args) {
         int i = 75;
         float f = 53.005f;
         double d = 2345.7652;
         bool b = true;

         Console.WriteLine(i.ToString());
         Console.WriteLine(f.ToString());
         Console.WriteLine(d.ToString());
         Console.WriteLine(b.ToString());
         Console.ReadKey();
            
      }
   }
}
//Result :
//75
//53.005
//2345.7652
//True