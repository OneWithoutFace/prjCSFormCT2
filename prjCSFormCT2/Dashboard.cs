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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit ?","Exit", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                Application.Exit();
            }

        }

        private void btnLottoMax_Click(object sender, EventArgs e)
        {
            LottoMax obj = new LottoMax();
            obj.Show();


        }

        private void btnLotto649_Click(object sender, EventArgs e)
        {
            Lotto649 obj = new Lotto649();
            obj.Show();
        }

        private void btnMExhange_Click(object sender, EventArgs e)
        {
            MoneyEx obj = new MoneyEx();
            obj.Show();
        }

        private void btnTempConv_Click(object sender, EventArgs e)
        {
            TempConv obj = new TempConv();
            obj.Show();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            SimpleCalc obj = new SimpleCalc();
            obj.Show();
        }

        private void ipValidbtn_Click(object sender, EventArgs e)
        {
            IPValid obj = new IPValid();
            obj.Show();

        }
    }
}
