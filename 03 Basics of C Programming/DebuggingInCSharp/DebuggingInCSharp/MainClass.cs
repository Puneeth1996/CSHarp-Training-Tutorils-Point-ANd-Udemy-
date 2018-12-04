using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebuggingInCSharp
{
    class MainClass
    {
        static void Main(string[] args)
        {
            boxer myBoxer = new boxer();
            Console.WriteLine(myBoxer.getPunchPower());


            //myBoxer.setPunchPower(100);

            //we will make user enter a value for punch power
            int num = int.Parse(Console.ReadLine());
            myBoxer.setPunchPower(num);
            Console.WriteLine(myBoxer.getPunchPower());



        }
    }
}
