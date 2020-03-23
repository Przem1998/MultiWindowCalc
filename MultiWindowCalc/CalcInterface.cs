using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiWindowCalc
{
    public partial class CalcInterface : Form
    {
        public CalcInterface(string way)
        {
            InitializeComponent();
            if (way == "Add")
            {
                Mark.Text = "+";
                this.Text = "Dodawanie";
            }
            else if (way == "Subtract")
            {
                Mark.Text = "-";
                this.Text = "Odejmowanie";
            }
            else if (way == "Multiple")
            {
                Mark.Text = "*";
                this.Text = "Mnożenie";
            }
            else
            {
                Mark.Text = "/";
                this.Text = "Dzielenie";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
