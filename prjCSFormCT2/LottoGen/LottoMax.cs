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
    public partial class LottoMax : Form
    {
        public LottoMax()
        {
            InitializeComponent();
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            Random rng = new Random();
            int rdomNum = rng.Next(1, 50);
            int[] lottoNum = new int[8];
            bool numCheck = false;
            

            displayLMax.Clear();
            for (int i = 0; i <= 7; i++)
            {
                if (i>0)
                {
                    do
                    {
                        rdomNum = rng.Next(1, 10);
                        dupliNumCheck(i, lottoNum,rdomNum,out numCheck);

                    } while (numCheck == false);
                }

                lottoNum[i] = rdomNum;
                
                displayLMax.AppendText(Convert.ToString(rdomNum));
                displayLMax.AppendText(Environment.NewLine); 
            }
            displayid.Text=idTagGen();
            ReadWriteFile.WriteLottoNum(@"./Logs\LottoNbrs.txt", 8, lottoNum,"Max");
        }
        
        public void dupliNumCheck(int position, int[] lottoNum,int rngNum,out bool numCheck)
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
            int[] rgNum=new int[7];

            Random rng = new Random();

            for (int i = 0; i < 7; i++)
            {
                rngTag=rng.Next(0, 9);
                rgNum[i]=rngTag;

            }

            return idTag=String.Join("",rgNum);


        }
    

        private void exitbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to return to the Dashboard ?","Lotto Max Exit",MessageBoxButtons.YesNo).ToString()=="Yes")
            {

                this.Close();

            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            Textpop obj = new Textpop(ReadWriteFile.ReadWholeFile(@"./Logs\LottoNbrs.txt"), "Lotto Number Generated");
            obj.ShowDialog();
            
        }
    }
}
