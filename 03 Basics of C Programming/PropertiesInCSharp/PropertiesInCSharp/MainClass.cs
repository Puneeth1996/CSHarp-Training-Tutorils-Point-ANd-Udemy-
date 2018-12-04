using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesInCSharp
{
    class MainClass
    {
        static void Main(string[] args)
        {

            //Console.WriteLine(new Computer().GetComputerName());
            //Or you create as instance varible 

            Computer comp = new Computer();
            //Console.WriteLine(comp.getComputerName());
            comp.ComputerName = "my new phone to be noted";
            Console.WriteLine(comp.ComputerName);


            comp.ComputerPower = 130;
            Console.WriteLine($"here the computer power is currently : {comp.ComputerPower} mW");
        }
    }
}
