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
    public partial class frmCalcSquare : Form
    {
        private decimal sqrLengthA;
        private decimal sqrLengthB;
        private decimal sqrHeight;
        public frmCalcSquare()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void TxtLengthA_TextChanged(object sender, EventArgs e)
        {
            decimal newLengthA = sqrLengthA;

            if (Decimal.TryParse(txtLengthA.Text, out newLengthA) == true)
            {
                sqrLengthA = newLengthA;
            }
            else
            {
                MessageBox.Show("Please Enter a valid decimal value", "Error");
            }
        }

        private void TxtLengthB_TextChanged(object sender, EventArgs e)
        {
            decimal newLengthB = sqrLengthB;

            if (Decimal.TryParse(txtLengthB.Text, out newLengthB) == true)
            {
                sqrLengthB = newLengthB;
            }
            else
            {
                MessageBox.Show("Please Enter a valid decimal value", "Error");
            }
        }

        private void TxtHeight_TextChanged(object sender, EventArgs e)
        {
            decimal newHeight = sqrHeight;

            if (Decimal.TryParse(txtHeight.Text, out newHeight) == true)
            {
                sqrHeight = newHeight;
            }
            else
            {
                MessageBox.Show("Please Enter a valid decimal value", "Error");
            }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            RoomDimensions newDimensions = new RoomDimensions();
            newDimensions.setLengthA(sqrLengthA);
            newDimensions.setLengthB(sqrLengthB);
            newDimensions.setHeight(sqrHeight);
            frmCalcVoidSpaces form3 = new frmCalcVoidSpaces();
            form3.Visible = true;
            this.Hide();
        }
    }
}
