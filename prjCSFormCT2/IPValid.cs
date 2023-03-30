﻿using System;
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
        public IPValid()
        {
            InitializeComponent();
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

                this.Close();

            }
        }
    }
}
