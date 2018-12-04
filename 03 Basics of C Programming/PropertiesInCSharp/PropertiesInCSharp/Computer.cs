using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesInCSharp
{
    class Computer
    {
        /*
         * 
        private string computerName = "Dummy ComputerName";
        public void SetComputerName(string name)
        {
            computerName = name;
        }

        public string GetComputerName()
        {
            return computerName;
        }

        */


        private string computerName;
        private int computerPower;


        public int ComputerPower
        {
            get
            {
                return computerPower;
            
            }

            set
            {
                computerPower = value;
            }


        }

        public string ComputerName
        {
            get{
                return computerName;
            }

            set{
                computerName = value;
            }
        }

    }
}
