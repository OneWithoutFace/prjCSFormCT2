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
    public partial class IPValid : Form
    {
        DateTime dateNow = DateTime.Today;
        int timerSecs;

        public IPValid()
        {
            InitializeComponent();
            timerDurrWin.Start();
            labelCurrentDate.Text =string.Format("{0:yy/MM/dd}",dateNow);
        }

        private void btnConv_Click(object sender, EventArgs e)
        {
            string userInput;
            bool checkIp;

            userInput = tBoxIp.Text;

            checkIp=IpValid(userInput);

            if (checkIp==true)
            {
                MessageBox.Show(userInput + "\nThis Ip is Correct", "Valid Ip", MessageBoxButtons.OK);

                DateTime timeStamp = DateTime.Now;
                ReadWriteFile.binaryWrite(@"./Logs\IpLogs.txt", userInput+"   "+timeStamp);

            }
            else
            {
                MessageBox.Show(userInput + "\nThe IP must have 4 bytes\ninterger number between 0 to 255\nseparated by a dot(255.255.255.255)", "Error", MessageBoxButtons.OK);

            }

        }

        private bool IpValid(string userIp)
        {
            System.Text.RegularExpressions.Regex checkIp = new Regex(@"^(25[0-5]|2[0-4]\d|[0-1]?\d?\d)(\.(25[0-5]|2[0-4]\d|[0-1]?\d?\d)){3}$");

            return checkIp.IsMatch(userIp);

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            tBoxIp.Text = "";
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to return to the Dashboard ?", "Ip-validator Exit", MessageBoxButtons.YesNo).ToString()=="Yes")
            {
                timerDurrWin.Stop();
                TimeSpan timeOnWin = TimeSpan.FromSeconds(timerSecs);
                string timeId;
                string timerFormated = timeOnWin.ToString(@"mm\:ss");

                if (timerSecs < 60)
                {
                    timeId = "seconds";
                }
                else
                {
                    timeId = "minutes";
                }

                MessageBox.Show("You were on the IP-Validator for: " + timerFormated + " " + timeId, "", MessageBoxButtons.OK);
                this.Close();

            }
        }

        private void timerDurrWin_Tick(object sender, EventArgs e)
        {
            timerSecs += 1;
        }
    }
}
