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
    
        ShowResultCalc showResult = null;
        public CalcInterface(Form callingform, string mark)
        {
            showResult = callingform as ShowResultCalc;
            InitializeComponent();
            this.Text = mark;
            if (mark == "Add") Mark.Text = "+";
            else if (mark == "Subtract") Mark.Text = "-";
           
            else if (mark == "Multiple") Mark.Text = "*";
             
            else  Mark.Text = "/";
             
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double? a = null, b = null,result=0;
         
                try
                {
                    a = double.Parse(FirstNumber.Text);
                    b = double.Parse(SecondNumber.Text);
                }
                catch (FormatException) { MessageBox.Show("Niewłaściwy format liczby"); }
     
                if (Mark.Text == "+") {
                result = a + b;
                this.showResult.ResultCalc = a + "+" + b + "=" + result;
            }
            else if (Mark.Text == "-")
            {
                result = a - b;
                this.showResult.ResultCalc = a + "-" + b + "=" + result;
            }
            else if (Mark.Text == "*")
            {
                result = a * b;
                this.showResult.ResultCalc = a + "+" + b + "=" + result;
            }
            else
            {
                result = a/b;
                this.showResult.ResultCalc = a + "/" + b + "=" + result;
            }
            this.Close();
         
        }


    }
}

