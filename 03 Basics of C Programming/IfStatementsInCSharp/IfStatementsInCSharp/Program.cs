using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStatementsInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            int firstNumber;
            int secondNumber;

            Console.WriteLine("Please enter the first integer value : ");
            firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the second integer value : ");
            secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"the first integer number is {firstNumber} and the second integer number is {secondNumber}");


            /*SIMPLE IF STATEMENTS 
             * 
             * 
             * 
             * 
             * if (firstNumber == secondNumber )
            {

                Console.WriteLine($"{firstNumber} is same as {secondNumber}");

            }*/


            if (firstNumber == secondNumber)
            {

                Console.WriteLine($"{firstNumber} is same as {secondNumber}");

            }

            if (firstNumber > secondNumber)
            {

                Console.WriteLine($"{firstNumber} is greater than {secondNumber}");

            }

            if (firstNumber < secondNumber)
            {

                Console.WriteLine($"{firstNumber} is less than {secondNumber}");

            }

            // >=    <=    !=  


            if (firstNumber >= secondNumber)
            {

                Console.WriteLine($"{firstNumber} is greater than or equal to {secondNumber}");

            }

            if (firstNumber <= secondNumber)
            {

                Console.WriteLine($"{firstNumber} is less than or equal to {secondNumber}");

            }

            if (firstNumber != secondNumber)
            {

                Console.WriteLine($"{firstNumber} is not equal to {secondNumber}");

            }







        }
    }
}
