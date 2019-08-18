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
    public partial class frmCalcLShape : Form
    {
        public frmCalcLShape()
        {
            InitializeComponent();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            frmCalcVoidSpaces form3 = new frmCalcVoidSpaces();
            form3.Visible = true;
            this.Hide();
        }
    }
}
