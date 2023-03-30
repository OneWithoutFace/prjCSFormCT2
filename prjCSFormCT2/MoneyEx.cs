﻿using System;
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
    public partial class MoneyEx : Form
    {
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

            ReadWriteFile.WriteFileTimeME("Moneyconv.txt", currIn, currOut, currAmountIn, currAmountOut);
            tBoxConvert.Text = Convert.ToString(currAmountOut);


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

            return currAmountOut;
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
            return currAmountOut;
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            Textpop obj = new Textpop(ReadWriteFile.ReadWholeFile("MoneyConv.txt"),"MoneyEx");
            obj.ShowDialog();

        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            TimerDurrWindow.Stop();
            if (MessageBox.Show("Do you want to return to the Dashboard ?", "MoneyEx Exit", MessageBoxButtons.YesNo).ToString()=="Yes")
            {
                this.Close();
                MessageBox.Show("You were on the currency exchange for: " + TimerDurrWindow, "", MessageBoxButtons.OK);
            }
        }
    }
}
