using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConstructorInCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            lblFirstName.Text = "Puneeth";
            lblLastName.Text = "P";

            Boxer myBoxer = new Boxer();
            btnResult.Text = myBoxer.FirstName;


        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            lblResult.Text = lblFirstName.Text + " " + lblLastName.Text;
        }
    }

    
}
