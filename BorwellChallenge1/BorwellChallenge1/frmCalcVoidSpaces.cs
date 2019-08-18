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
        private decimal voidSpaceArea;
        private decimal sqrLengthB;
        private decimal sqrHeight;

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

        private void FrmCalcVoidSpaces_Load(object sender, EventArgs e)
        {

        }
    }
}
