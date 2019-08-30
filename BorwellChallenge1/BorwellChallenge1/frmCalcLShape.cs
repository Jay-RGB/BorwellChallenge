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
        private decimal lLengthA;
        private decimal lLengthB;
        private decimal lLengthC;
        private decimal lLengthD;
        private decimal lHeight;
        public frmCalcLShape()
        {
            InitializeComponent();
        }

        private void FrmCalcLShape_Load(object sender, EventArgs e)
        {

        }

        private void TxtLengthA_TextChanged(object sender, EventArgs e)
        {
            decimal newLengthA = lLengthA;                              //Detects users inputting non-numerical values and displays
                                                                        //an error message for the Users attention.
            if (Decimal.TryParse(txtLengthA.Text, out newLengthA) == true)
            {
                lLengthA = newLengthA;
            }
            else
            {
                MessageBox.Show("Please Enter a valid decimal value", "Error");
            }
        }

        private void TxtLengthB_TextChanged(object sender, EventArgs e)
        {
            decimal newLengthB = lLengthB;                              //Detects users inputting non-numerical values and displays
                                                                        //an error message for the Users attention.
            if (Decimal.TryParse(txtLengthB.Text, out newLengthB) == true)
            {
                lLengthB = newLengthB;
            }
            else
            {
                MessageBox.Show("Please Enter a valid decimal value", "Error");
            }
        }

        private void TxtLengthC_TextChanged(object sender, EventArgs e)
        {
            decimal newLengthC = lLengthC;                              //Detects users inputting non-numerical values and displays
                                                                        //an error message for the Users attention.
            if (Decimal.TryParse(txtLengthC.Text, out newLengthC) == true)
            {
                lLengthC = newLengthC;
            }
            else
            {
                MessageBox.Show("Please Enter a valid decimal value", "Error");
            }
        }

        private void TxtLengthD_TextChanged(object sender, EventArgs e)
        {
            decimal newLengthD = lLengthD;                              //Detects users inputting non-numerical values and displays
                                                                        //an error message for the Users attention.
            if (Decimal.TryParse(txtLengthD.Text, out newLengthD) == true)
            {
                lLengthD = newLengthD;
            }
            else
            {
                MessageBox.Show("Please Enter a valid decimal value", "Error");
            }
        }

        private void TxtHeight_TextChanged(object sender, EventArgs e)
        {
            decimal newHeight = lHeight;                                //Detects users inputting non-numerical values and displays
                                                                        //an error message for the Users attention.
            if (Decimal.TryParse(txtHeight.Text, out newHeight) == true)
            {
                lHeight = newHeight;
            }
            else
            {
                MessageBox.Show("Please Enter a valid decimal value", "Error");
            }
        }

        private bool validateDetails()          //Checks that all fields are populated with valid values and displays an error message if they aren't
        {
            decimal newLengthA = lLengthA;
            decimal newLengthB = lLengthB;
            decimal newLengthC = lLengthC;
            decimal newLengthD = lLengthD;
            decimal newHeight = lHeight;

            if ((string.IsNullOrWhiteSpace(txtLengthA.Text)) || (string.IsNullOrWhiteSpace(txtLengthB.Text)) || (string.IsNullOrWhiteSpace(txtLengthC.Text)) || 
                (string.IsNullOrWhiteSpace(txtLengthD.Text)) || (string.IsNullOrWhiteSpace(txtHeight.Text)) || (Decimal.TryParse(txtLengthA.Text, out newLengthA) == false) ||
                (Decimal.TryParse(txtLengthB.Text, out newLengthB) == false) || (Decimal.TryParse(txtLengthC.Text, out newLengthC) == false) || (Decimal.TryParse(txtLengthD.Text, out newLengthD) == false) ||
                (Decimal.TryParse(txtHeight.Text, out newHeight) == false))
            {
                MessageBox.Show("Some Fields are blank or do not contain valid values, please fill in all fields and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void BtnNext_Click(object sender, EventArgs e)              // When Next button is clicked values are saved to the variables in the
        {                                                                   // RoomDimensions Class file and the Void spaces calculation form is run.
            if (!validateDetails()) { return; }
            RoomDimensions.setLengthA(lLengthA);
            RoomDimensions.setLengthB(lLengthB);
            RoomDimensions.setLengthC(lLengthC);
            RoomDimensions.setLengthD(lLengthD);
            RoomDimensions.setHeight(lHeight);
            frmCalcVoidSpaces form3 = new frmCalcVoidSpaces();
            form3.Visible = true;
            this.Hide();
        }
    }
}
