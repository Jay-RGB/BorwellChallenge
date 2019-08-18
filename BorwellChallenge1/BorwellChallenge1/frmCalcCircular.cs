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
    public partial class frmCalcCircular : Form
    {
        private decimal crclLengthA;
        private decimal crclHeight;
        public frmCalcCircular()
        {
            InitializeComponent();
        }

        private void TxtLengthA_TextChanged(object sender, EventArgs e)
        {
            decimal newLengthA = crclLengthA;

            if (Decimal.TryParse(txtLengthA.Text, out newLengthA) == true)
            {
                crclLengthA = newLengthA;
            }
            else
            {
                MessageBox.Show("Please Enter a valid decimal value", "Error");
            }
        }

        private void TxtHeight_TextChanged(object sender, EventArgs e)
        {
            decimal newHeight = crclHeight;

            if (Decimal.TryParse(txtHeight.Text, out newHeight) == true)
            {
                crclHeight = newHeight;
            }
            else
            {
                MessageBox.Show("Please Enter a valid decimal value", "Error");
            }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            RoomDimensions newDimensions = new RoomDimensions();
            newDimensions.setDiameter(crclLengthA);
            newDimensions.setHeight(crclHeight);
            frmCalcVoidSpaces form3 = new frmCalcVoidSpaces();
            form3.Visible = true;
            this.Hide();
        }
    }
}
