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
    public partial class TempConv : Form
    {
        public TempConv()
        {
            InitializeComponent();
            rbtnCtoF.Checked = true;
        }

        private void btnConv_Click(object sender, EventArgs e)
        {
            double userTemp, outTemp;
            string color,txtMsg,userTempSign,outTempsign;

            if (tempValid(tBoxInput.Text)==false)
            {
                return;
            }
            
            userTemp = Convert.ToDouble(tBoxInput.Text);

            if (rbtnCtoF.Checked==true)
            {
                outTemp = (userTemp * 1.8) + 32;
                txtMsg = tempFeel(userTemp, out color);
                userTempSign = "C";
                outTempsign = "F";
            }
            else
            {
                outTemp = (userTemp - 32) * 0.5556;
                txtMsg = tempFeel(outTemp, out color);
                userTempSign = "F";
                outTempsign = "C";
            }

            
            
            switch (color)
            {
                case "Red":
                    tBoxMsg.Text = txtMsg;
                    tBoxMsg.ForeColor = Color.Red;
                    break;
                case "Green":
                    tBoxMsg.Text = txtMsg;
                    tBoxMsg.ForeColor = Color.Green;
                    break;
                case "Blue":
                    tBoxMsg.Text = txtMsg;
                    tBoxMsg.ForeColor = Color.Blue;
                    break;
            }
            

            ReadWriteFile.WriteFileTemp(@"./Logs\TempConv.txt", userTemp,outTemp, userTempSign, outTempsign,txtMsg);
            tBoxOutput.Text = Convert.ToString(Math.Round(outTemp, 1));
        }

        private static bool tempValid(string userTemp)
        {
            System.Text.RegularExpressions.Regex checkTemp = new Regex(@"(\-?)(\d)([\.]?)");

            return checkTemp.IsMatch(userTemp);
        }

        public static string tempFeel(double tempCel,out string color)
        {
            string tempMsg="";
            color="";

            if (tempCel>=100)
            {
                tempMsg = "Water boils";
                color = "Red";
            }
            else if (tempCel>=40&&tempCel<100)
            {
                tempMsg = "Hot Bath";
                color = "Red";

            }
            else if (tempCel>=37&&tempCel<40)
            {
                tempMsg = "Body Temperature";
                color = "Green";

            }
            else if (tempCel>=30&&tempCel<37)
            {
                tempMsg = "Beach Weather";
                color = "Green";

            }
            else if (tempCel>=21&&tempCel<30)
            {
                tempMsg = "Room Temperature";
                color = "Green";

            }
            else if (tempCel >= 10 && tempCel < 21)
            {
                tempMsg = "Cool Day";
                color = "Blue";

            }
            else if (tempCel >= 0 && tempCel < 10)
            {
                tempMsg = "Freezing Point of Water";
                color = "Blue";

            }
            else if (tempCel >= -18 && tempCel < 0)
            {
                tempMsg = "Very Cold Day";
                color = "Blue";

            }
            else if (tempCel >=-40 && tempCel < -18)
            {
                tempMsg = "Extremely Cold Day";
                color = "Blue";

            }
            return tempMsg;
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            Textpop obj = new Textpop(ReadWriteFile.ReadWholeFile(@"./Logs\TempConv.txt"), "Temperature Conversion");
            obj.ShowDialog();

        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to return to the Dashboard ?", "Temp App Exit", MessageBoxButtons.YesNo).ToString()=="Yes")
            {

                this.Close();

            }
        }

        private void rbtnCtoF_CheckedChanged(object sender, EventArgs e)
        {
            
                label1.Text = "C";
                label2.Text = "F";

            
        }

        private void rbtnFtoC_CheckedChanged(object sender, EventArgs e)
        {
            
                label1.Text = "F";
                label2.Text = "C";
            
        }
    }
}
