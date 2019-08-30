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
            decimal newLengthA = crclLengthA;                           //Detects users inputting non-numerical values and displays
                                                                        //an error message for the Users attention.
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
            decimal newHeight = crclHeight;                             //Detects users inputting non-numerical values and displays
                                                                        //an error message for the Users attention.
            if (Decimal.TryParse(txtHeight.Text, out newHeight) == true)
            {
                crclHeight = newHeight;
            }
            else
            {
                MessageBox.Show("Please Enter a valid decimal value", "Error");
            }
        }

        private bool validateDetails()             //Checks that all fields are populated with valid values and displays and error message if they aren't
        {
            decimal newLengthA = crclLengthA;
            decimal newHeight = crclHeight;

            if ((string.IsNullOrWhiteSpace(txtLengthA.Text)) || (string.IsNullOrWhiteSpace(txtHeight.Text)) || 
                (Decimal.TryParse(txtLengthA.Text, out newLengthA) == false) || (Decimal.TryParse(txtHeight.Text, out newHeight) == false))
            {
                MessageBox.Show("Some Fields are blank or do not contain a valid decimal value, please fill in all fields and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void BtnNext_Click(object sender, EventArgs e)       // When Next button is clicked values are saved to the variables in the
        {                                                            // RoomDimensions Class file and the Void spaces calculation form is run.
            if (!validateDetails()) { return; }
            RoomDimensions.setDiameter(crclLengthA);
            RoomDimensions.setHeight(crclHeight);
            frmCalcVoidSpaces form3 = new frmCalcVoidSpaces();
            form3.Visible = true;
            this.Hide();
        }

        private void FrmCalcCircular_Load(object sender, EventArgs e)
        {

        }
    }
}
