using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    class Animal
    {
        //Class is blueprint which can used 
        public string Name { get; set; }

        private int age;
        private decimal power;
        private decimal speed;
        
        public Animal(string nameValue,int ageValue, decimal powerValue, decimal speedValue)
        {
            Name = nameValue;
            age = ageValue;
            power = powerValue;
            speed = speedValue;

        }

        public int Age
        {
            get
            {
                return age;
            }
            private set
            {
                if(value > 0)
                {
                    age = value;
                }
            }
        }

        public decimal Power
        {
            get
            {
                return power;
            }
            private set
            {
                if(value > 0 )
                {
                    power = value;
                }
            }
        }

        public decimal Speed
        {
            get
            {
                return speed;
            }
            private set
            {
                if (value > 0)
                {
                    speed = value;
                }
            }
        }

    }
}
