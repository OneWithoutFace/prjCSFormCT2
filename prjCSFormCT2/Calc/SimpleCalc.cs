using prjCSFormCT2.Calc;
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
        bool resCheck = false;
        memCalc activeMem = new memCalc();

        public SimpleCalc()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (calcDisplay.Text == "0"||resCheck==true)
            {
                calcDisplay.Text = "0";
                resCheck=false;
            }
            else
            {
                calcDisplay.Text += "0";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (calcDisplay.Text == "0"||resCheck==true)
            {
                calcDisplay.Text = "1";
                resCheck=false;
            }
            else
            {
                calcDisplay.Text += "1";
            }
            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (calcDisplay.Text == "0"||resCheck==true)
            {
                calcDisplay.Text = "2";
                resCheck=false;
            }
            else
            {
                calcDisplay.Text += "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (calcDisplay.Text == "0"||resCheck==true)
            {
                calcDisplay.Text = "3";
                resCheck=false;
            }
            else
            {
                calcDisplay.Text += "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (calcDisplay.Text == "0"||resCheck==true)
            {
                calcDisplay.Text = "4";
                resCheck=false;
            }
            else
            {
                calcDisplay.Text += "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (calcDisplay.Text == "0"||resCheck==true)
            {
                calcDisplay.Text = "5";
                resCheck=false;
            }
            else
            {
                calcDisplay.Text += "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (calcDisplay.Text == "0"||resCheck==true)
            {
                calcDisplay.Text = "6";
                resCheck=false;
            }
            else
            {
                calcDisplay.Text += "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (calcDisplay.Text == "0"||resCheck==true)
            {
                calcDisplay.Text = "7";
                resCheck=false;
            }
            else
            {
                calcDisplay.Text += "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (calcDisplay.Text == "0"||resCheck==true)
            {
                calcDisplay.Text = "8";
                resCheck=false;
            }
            else
            {
                calcDisplay.Text += "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (calcDisplay.Text == "0"||resCheck==true)
            {
                calcDisplay.Text = "9";
                resCheck=false;
            }
            else
            {
                calcDisplay.Text += "9";
            }
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            

            if (countDot==false||resCheck==false)
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

            Calculation.Add(activeMem, Convert.ToDouble(calcDisplay.Text));
            calcDisplay.Text = "0";
            countDot = false;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {

            Calculation.Sub(activeMem, Convert.ToDouble(calcDisplay.Text));
            calcDisplay.Text = "0";
            countDot = false;
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {

            Calculation.Multi(activeMem, Convert.ToDouble(calcDisplay.Text));
            calcDisplay.Text = "0";
            countDot = false;

        }

        private void btnDiv_Click(object sender, EventArgs e)
        {

            Calculation.Div(activeMem, Convert.ToDouble(calcDisplay.Text));
            calcDisplay.Text = "0";
            countDot = false;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            double result;
            string userNum1, userNum2, userOp, userResult;

            if (resCheck==false)
            {
                return;
            }

            result=Calculation.Equal(activeMem, Convert.ToDouble(calcDisplay.Text));

            userNum1 = Convert.ToString(activeMem.Num1);
            userNum2 = Convert.ToString(activeMem.Num2);
            userOp = activeMem.OpType;
            userResult = Convert.ToString(activeMem.Result);


            ReadWriteFile.writeSimpleText(@"./Logs\Calculator.txt",userNum1+userOp+userNum2+"="+userResult);

            calcDisplay.Text=Convert.ToString(result);

            resCheck=true;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Calculation.Clear(activeMem);
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
