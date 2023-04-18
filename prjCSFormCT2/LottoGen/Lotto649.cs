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
    public partial class Lotto649 : Form
    {
        public Lotto649()
        {
            InitializeComponent();
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            Random rng = new Random();
            int rdomNum = rng.Next(1, 49);
            int[] lottoNum = new int[7];
            bool numCheck = false;


            displayL649.Clear();
            for (int i = 0; i <= 6; i++)
            {
                if (i>0)
                {
                    do
                    {
                        rdomNum = rng.Next(1, 49);
                        dupliNumCheck(i, lottoNum, rdomNum, out numCheck);

                    } while (numCheck == false);
                }

                lottoNum[i] = rdomNum;

                displayL649.AppendText(Convert.ToString(rdomNum));
                displayL649.AppendText(Environment.NewLine);
            }
            displayid.Text=idTagGen();
            ReadWriteFile.WriteLottoNum(@".\Logs\LottoNbrs.txt", 7, lottoNum, "649");
        }

        public void dupliNumCheck(int position, int[] lottoNum, int rngNum, out bool numCheck)
        {
            for (int i = 0; i < position; i++)
            {
                if (rngNum == lottoNum[i])
                {
                    numCheck = false;
                    return;

                }

            }

            numCheck = true;
        }

        public string idTagGen()
        {
            string idTag;
            int rngTag;
            int[] rgNum = new int[7];

            Random rng = new Random();

            for (int i = 0; i < 7; i++)
            {
                rngTag=rng.Next(0, 9);
                rgNum[i]=rngTag;

            }

            return idTag=String.Join("", rgNum);


        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            Textpop obj = new Textpop(ReadWriteFile.ReadWholeFile(@"./Logs\LottoNbrs.txt"), "Lotto Number Generated");
            obj.ShowDialog();

        }

        private void exitbtn_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Do you want to return to the Dashboard ?", "Lotto 649 Exit", MessageBoxButtons.YesNo).ToString()=="Yes")
            {

                this.Close();

            }
        }
    }
}
