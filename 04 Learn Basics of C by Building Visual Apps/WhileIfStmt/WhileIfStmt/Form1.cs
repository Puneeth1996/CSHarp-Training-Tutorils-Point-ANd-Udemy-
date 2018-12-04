using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhileIfStmt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            int number = int.Parse(txtBoxNumber.Text);
            while(number != -50)
            {
                number += 100;
                result.Text = number.ToString();
                break;
            }
            if(number == 50)
            {
                Close();
            }
        }
    }
}
