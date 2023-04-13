using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjCSFormCT2
{
    public partial class MoneyEx : Form
    {
        int timerSecs;

        public MoneyEx()
        {
            InitializeComponent();
            TimerDurrWindow.Start();
            rbtnCADIN.Checked=true;
            rbtnUSDOUT.Checked=true;
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string currIn="CAD", currOut="USD";
            double currAmountIn, currAmountOut;

            if (tBoxUser.Text=="0"||currRegexCheck(tBoxUser.Text)==false||Convert.ToDouble(tBoxUser.Text)<0)
            {
                MessageBox.Show("Enter a valid number to convert", "MoneyEx", MessageBoxButtons.OK);
                return;
            }

            currAmountIn =Convert.ToDouble( tBoxUser.Text);
            
            if (rbtnCADIN.Checked==true)
            {
                currIn = "CAD";
            }
            else if (rbtnUSDIN.Checked==true)
            {
                currIn = "USD";
            }
            else if (rbtnEURIN.Checked==true)
            {
                currIn = "EUR";
            }
            else if (rbtnGBPIN.Checked==true)
            {
                currIn = "GBP";
            }
            else if (rbtnIN.Checked==true)
            {
                currIn = "CNY";
            }

            if (rbtnCADOut.Checked==true)
            {
                currOut = "CAD";
            }
            else if (rbtnUSDOUT.Checked == true)
            {
                currOut = "USD";
            }
            else if (rbtnEUROUT.Checked == true)
            {
                currOut = "EUR";
            }
            else if (rbtnGBPOUT.Checked == true)
            {
                currOut = "GBP";
            }
            else if (rbtnOUT.Checked == true)
            {
                currOut = "CNY";
            }

            currAmountOut= currConvToUS(currAmountIn, currIn, currOut);

            ReadWriteFile.WriteFileTimeME(@"./Logs\Moneyconv.txt", currIn, currOut, currAmountIn, currAmountOut);
            tBoxConvert.Text = Convert.ToString(currAmountOut);


        }

        private bool currRegexCheck(string amountIn)
        {
            Regex amountReg = new Regex(@"(\d{1,3})(\.(\d{0,2}))?");
            return amountReg.IsMatch(amountIn);

        }

        public static double currConvToUS(double currAmountIn,string currIn,string currOut)
        {
            double currAmountOut,convUSAm=0;
            

            switch (currIn)
            {
                case "CAD":
                    convUSAm = currAmountIn * 0.73;
                    break;

                case "USD":
                    convUSAm = currAmountIn;
                    break;

                case "EUR":
                    convUSAm = currAmountIn * 1.09;
                    break;

                case "GBP":
                    convUSAm = currAmountIn * 1.23;
                    break;

                case "CNY":
                    convUSAm = currAmountIn * 0.15;
                    break;
            }

            currAmountOut=currConvToOut(convUSAm, currOut);

            return  currAmountOut;
        }

        public static double currConvToOut(double convUSAm,string currOut)
        {
            double currAmountOut=0;

            switch (currOut)
            {
                case "CAD":
                    currAmountOut = convUSAm * 1.37;
                    break;

                case "USD":
                    currAmountOut = convUSAm;
                    break;

                case "EUR":
                    currAmountOut = convUSAm * 0.92;
                    break;

                case "GBP":
                    currAmountOut = convUSAm * 0.81;
                    break;

                case "CNY":
                    currAmountOut = convUSAm * 6.82;
                    break;
            }
            return Math.Round( currAmountOut,2);
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            Textpop obj = new Textpop(ReadWriteFile.ReadWholeFile(@"./Logs\MoneyConv.txt"),"MoneyEx");
            obj.ShowDialog();

        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            TimerDurrWindow.Stop();
            TimeSpan timeOnWin = TimeSpan.FromSeconds(timerSecs);
            string timeId;
            string timerFormated = timeOnWin.ToString(@"mm\:ss");

            if (timerSecs<60)
            {
                timeId = "seconds";
            }
            else
            {
                timeId = "minutes";
            }

            if (MessageBox.Show("Do you want to return to the Dashboard ?", "MoneyEx Exit", MessageBoxButtons.YesNo).ToString()=="Yes")
            {
                this.Close();
                MessageBox.Show("You were on the currency exchange for: " +timerFormated+" "+timeId, "", MessageBoxButtons.OK);
            }
        }

        private void TimerDurrWindow_Tick(object sender, EventArgs e)
        {
            timerSecs += 1;
        }
    }
}
