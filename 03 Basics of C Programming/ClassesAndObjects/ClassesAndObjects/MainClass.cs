using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class MainCLass
    {
        static void Main(string[] args)
        {
        Animal lion = new Animal();



        Console.WriteLine(lion.GetAnimalName());



        lion.SetAnimalName("My Lion");

        Console.WriteLine(lion.GetAnimalName());




        Animal tiger = new Animal();

        Console.WriteLine(tiger.GetAnimalName());

        tiger.SetAnimalName("My Tiger");

        Console.WriteLine(tiger.GetAnimalName());





        Animal dog = new Animal();

        Console.WriteLine(dog.GetAnimalName());

        dog.SetAnimalName("My dog");

        Console.WriteLine(dog.GetAnimalName());



    }
}

