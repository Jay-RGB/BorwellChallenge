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
    public partial class frmStartup : Form
    {
        public frmStartup()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (rdbtnSquareRectangle.Checked == true)
            {
                frmCalcSquare form2 = new frmCalcSquare();
                form2.Visible = true;
                this.Hide();
            }
            else if (rdbtnLShape.Checked == true)
            {
                frmCalcLShape form2 = new frmCalcLShape();
                form2.Visible = true;
                this.Hide();
            }
            else if (rdbtnCircular.Checked == true)
            {
                frmCalcCircular form2 = new frmCalcCircular();
                form2.Visible = true;
                this.Hide();
            }
        }
    }
}
