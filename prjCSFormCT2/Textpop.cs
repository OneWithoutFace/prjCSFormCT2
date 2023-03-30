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
    public partial class Textpop : Form
    {
        public Textpop(string textDisplay,string title)
        {
            InitializeComponent();
            textPopName.Text = title;
            displayRead.Text = textDisplay;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
