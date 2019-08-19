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
            decimal newLengthA = sqrLengthA;                                //Prevents users from inputting non-numerical values and displays
                                                                            //an error message for the Users attention.
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

        private bool validateDetails()              //Checks that all fields are populated and displays and error message if they aren't
        {
            if ((string.IsNullOrWhiteSpace(txtLengthA.Text)) || (string.IsNullOrWhiteSpace(txtLengthB.Text)) || (string.IsNullOrWhiteSpace(txtHeight.Text)))
            {
                MessageBox.Show("Some Fields are blank, please fill in all fields and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void BtnNext_Click(object sender, EventArgs e)      // When Next button is clicked values are saved to the variables in the
        {                                                           // RoomDimensions Class file and the Void spaces calculation form is run.
            if (!validateDetails()) { return; }
            RoomDimensions.setLengthA(sqrLengthA);
            RoomDimensions.setLengthB(sqrLengthB);
            RoomDimensions.setHeight(sqrHeight);
            frmCalcVoidSpaces form3 = new frmCalcVoidSpaces();
            form3.Visible = true;
            this.Hide();
        }
    }
}
