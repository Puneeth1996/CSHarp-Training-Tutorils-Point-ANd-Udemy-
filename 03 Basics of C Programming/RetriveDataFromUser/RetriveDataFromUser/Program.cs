using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetriveDataFromUser
{
    class Program
    {
        static void Main(string[] args)
        {
            /* this is the multi line commenting 
            string firstName;
            string lastName;

            Console.WriteLine("Enter your first name: ");
            firstName = Console.ReadLine();

            Console.WriteLine("Enter your last name: ");
            lastName = Console.ReadLine();

            Console.WriteLine($"{firstName} {lastName}");

            this is the end of multi line commenting */

            // this puts up for single line commnenting

            int firstNumber;
            int secondNumber;
            int multiplicationResult;

            Console.WriteLine("enter the first number here: ");
            firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the second number here: ");
            secondNumber = int.Parse(Console.ReadLine());

            multiplicationResult = firstNumber * secondNumber;

            Console.WriteLine($"This is the multiplication result: {multiplicationResult}");




        }
    }
}
