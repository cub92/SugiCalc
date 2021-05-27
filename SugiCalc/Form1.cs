using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SugiCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string inputValue = "";
        string opcode = "";
        double value = 0.0;

        private void buttonCE_Click(object sender, EventArgs e)
        {
            inputValue = "0";
            textBoxCalc.Text = "0";
        }

        private void buttonOperator_Click(Object sender, EventArgs e)
        {
            double v;
            string op = (sender as Button).Text;

            v = Convert.ToDouble(inputValue);
            inputValue = "";
            switch (opcode)
            {
                case "+":
                    value += v;
                    break;
                case "-":
                    value -= v;
                    break;
                case "×":
                    value *= v;
                    break;
                case "÷":
                    value /= v;
                    break;
            }
            textBoxCalc.Text = Convert.ToString(value);
            if (op != "=")
            {
                opcode = (sender as Button).Text;
            } else
            {
                opcode = "";
            }
        }
        
        private void buttonX_Click(Object sender, EventArgs e)
        {
            string s;
            double d;

            s = inputValue + (sender as Button).Text;
            try
            {
                d = Convert.ToDouble(s);
            }
            catch
            {
                return;
            }
            inputValue += (sender as Button).Text;
            textBoxCalc.Text = Convert.ToString(d);
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {

        }
    }
}
