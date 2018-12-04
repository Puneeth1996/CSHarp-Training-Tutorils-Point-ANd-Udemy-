using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhileStmt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string oldLblResultStringValue;
            int counter = 1;
            lblResult.Text = string.Empty;
            while (counter <= 10)
            {
                oldLblResultStringValue = lblResult.Text;
                lblResult.Text = oldLblResultStringValue + "this is " + counter + "\n";
                counter += 1;
            }
        }
    }
}
