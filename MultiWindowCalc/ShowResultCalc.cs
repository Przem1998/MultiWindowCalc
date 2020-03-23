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
    public partial class ShowResultCalc : Form
    {
        public ShowResultCalc()
        {
            InitializeComponent();
        
        }
        public string ResultCalc
        {
            get { return label1.Text; }
            set { label1.Text = value; }
            
        }
        private void Add_Click(object sender, EventArgs e)
        {
            DescActivity("Add");
        
        }

        private void Subtract_Click(object sender, EventArgs e)
        {
            DescActivity("Subtract");
        }

        private void Multiple_Click(object sender, EventArgs e)
        {
            DescActivity("Multiple");
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            DescActivity("Devide");
        }
        private void DescActivity(string desc)
        {
            CalcInterface calc = new CalcInterface(this, desc);
            calc.ShowDialog();
        }
    }
}
