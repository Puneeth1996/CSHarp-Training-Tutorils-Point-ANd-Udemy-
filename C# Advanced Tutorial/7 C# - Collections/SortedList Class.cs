using System;
using System.Collections;

namespace CollectionsApplication {
   class Program {
      static void Main(string[] args) {
         SortedList sl = new SortedList();
         
         sl.Add("001", "Zara Ali");
         sl.Add("002", "Abida Rehman");
         sl.Add("003", "Joe Holzner");
         sl.Add("004", "Mausam Benazir Nur");
         sl.Add("005", "M. Amlan");
         sl.Add("006", "M. Arif");
         sl.Add("007", "Ritesh Saikia");
         
         if (sl.ContainsValue("Nuha Ali")) {
            Console.WriteLine("This student name is already in the list");
         } else {
            sl.Add("008", "Nuha Ali");
         }

         // get a collection of the keys. 
         ICollection key = sl.Keys;

         foreach (string k in key) {
            Console.WriteLine(k + ": " + sl[k]);
         }
      }
   }
}
/*

When the above code is compiled and executed, it produces the following result −

001: Zara Ali
002: Abida Rehman
003: Joe Holzner
004: Mausam Banazir Nur
005: M. Amlan 
006: M. Arif
007: Ritesh Saikia
008: Nuha Ali

*/