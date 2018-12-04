using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Boxer
    {
    public string Name { get; set; }

    private int punchSpeed;

    public Boxer(string name ,int punchSpeedValue)
    {
        Name = name;
        PunchSpeed = punchSpeedValue;
    }

    public int PunchSpeed
    {
        get
        {
            return punchSpeed;
        }

        set
        {
            if(value > 0)
            {
                if(value < 500)
                {
                    punchSpeed = value;
                }
            }
                

        }
    }

    public string PunchSpeedEvalutation
    {
        get
        {
            string EvalurtionString = string.Empty;
            if(PunchSpeed >= 450)
            {
                EvalurtionString = "Great Speed";
            }
            else if (PunchSpeed >= 400)
            {
                EvalurtionString = "Good Speed";
            }
            else if (PunchSpeed >= 300)
            {
                EvalurtionString = "Not Speed";
            }
            else
            {
                EvalurtionString = "Bad!";
            }
            return EvalurtionString;


        }
    }


    }

