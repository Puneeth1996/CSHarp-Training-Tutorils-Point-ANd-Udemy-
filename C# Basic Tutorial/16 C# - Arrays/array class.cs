using System;

namespace ArrayApplication {
   class MyArray {
      static void Main(string[] args) {
         int[] list = { 34, 72, 13, 44, 25, 30, 10 };
         int[] temp = list;
         Console.Write("Original Array: ");
         
         foreach (int i in list) {
            Console.Write(i + " ");
         }
         Console.WriteLine();
         
         // reverse the array
         Array.Reverse(temp);
         Console.Write("Reversed Array: ");
         
         foreach (int i in temp) {
            Console.Write(i + " ");
         }
         Console.WriteLine();
         
         //sort the array
         Array.Sort(list);
         Console.Write("Sorted Array: ");
         
         foreach (int i in list) {
            Console.Write(i + " ");
         }
         Console.WriteLine();
         Console.ReadKey();
      }
   }
}


/*
result −

Original Array: 34 72 13 44 25 30 10
Reversed Array: 10 30 25 44 13 72 34
Sorted Array: 10 13 25 30 34 44 72
*/