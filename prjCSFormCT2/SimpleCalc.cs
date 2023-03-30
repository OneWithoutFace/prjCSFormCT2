using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjCSFormCT2
{
    public partial class SimpleCalc : Form
    {
        bool countDot=false;

        public SimpleCalc()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (calcDisplay.Text == "0")
            {
                calcDisplay.Text = "0";
            }
            else
            {
                calcDisplay.Text += "0";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (calcDisplay.Text=="0")
            {
                calcDisplay.Text = "1";
            }
            else
            {
                calcDisplay.Text += "1";
            }
            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (calcDisplay.Text == "0")
            {
                calcDisplay.Text = "2";
            }
            else
            {
                calcDisplay.Text += "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (calcDisplay.Text == "0")
            {
                calcDisplay.Text = "3";
            }
            else
            {
                calcDisplay.Text += "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (calcDisplay.Text == "0")
            {
                calcDisplay.Text = "4";
            }
            else
            {
                calcDisplay.Text += "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (calcDisplay.Text == "0")
            {
                calcDisplay.Text = "5";
            }
            else
            {
                calcDisplay.Text += "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (calcDisplay.Text == "0")
            {
                calcDisplay.Text = "6";
            }
            else
            {
                calcDisplay.Text += "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (calcDisplay.Text == "0")
            {
                calcDisplay.Text = "7";
            }
            else
            {
                calcDisplay.Text += "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (calcDisplay.Text == "0")
            {
                calcDisplay.Text = "8";
            }
            else
            {
                calcDisplay.Text += "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (calcDisplay.Text == "0")
            {
                calcDisplay.Text = "9";
            }
            else
            {
                calcDisplay.Text += "9";
            }
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            

            if (countDot==false)
            {
                calcDisplay.Text += ".";
                countDot = true;
            }
            else
            {
                return;
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            //calcFormule.Add = Convert.ToDouble(calcDisplay.Text);
            calcDisplay.Text = "0";
            countDot = false;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {

            

        }

        private void btnMulti_Click(object sender, EventArgs e)
        {

        }

        private void btnDiv_Click(object sender, EventArgs e)
        {

        }

        private void btnEqual_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            calcDisplay.Text = "0";
            countDot = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to return to the Dashboard ?", "Calculator Exit", MessageBoxButtons.YesNo).ToString() == "Yes")
            {

                this.Close();

            }
        }
    }
}
