/*
any member with internal access specifier can be accessed from any class or method defined within the application in which the member is defined.
*/


using System;

namespace RectangleApplication {
   class Rectangle {
      //member variables
      internal double length;
      internal double width;
      
      double GetArea() {
         return length * width;
      }
      public void Display() {
         Console.WriteLine("Length: {0}", length);
         Console.WriteLine("Width: {0}", width);
         Console.WriteLine("Area: {0}", GetArea());
      }
   }//end class Rectangle
   
   class ExecuteRectangle {
      static void Main(string[] args) {
         Rectangle r = new Rectangle();
         r.length = 4.5;
         r.width = 3.5;
         r.Display();
         Console.ReadLine();
      }
   }
}
/*
Result 

Length: 4.5
Width: 3.5
Area: 15.75
*/