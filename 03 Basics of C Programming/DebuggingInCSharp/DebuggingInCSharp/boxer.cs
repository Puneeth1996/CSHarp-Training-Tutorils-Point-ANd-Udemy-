using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class boxer
    {

        private int punchPower;
        //here we using the private instead of public keyboard as to achieve encapsultaiton and this ensure security
        public void setPunchPower(int boxerPunchPower)
        {

        punchPower = boxerPunchPower;
            
        }
        public int getPunchPower()
        {

            return punchPower;

        }
}

