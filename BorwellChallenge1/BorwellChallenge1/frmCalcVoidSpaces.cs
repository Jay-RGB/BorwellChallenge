using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BorwellChallenge1
{
    public partial class frmCalcVoidSpaces : Form
    {
        public frmCalcVoidSpaces()
        {
            InitializeComponent();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            frmResults form4 = new frmResults();
            form4.Visible = true;
            this.Hide();
        }
    }
}
