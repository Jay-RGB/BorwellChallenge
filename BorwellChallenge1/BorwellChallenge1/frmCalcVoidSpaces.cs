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
        private decimal totalVoidSpaceArea;
        private decimal voidSpaceArea;
        private decimal voidHeight;
        private decimal voidWidth;
        private decimal floorArea;
        private decimal roomVolume;
        private decimal roomPerimeter;
        private decimal wallSurfaceArea;
        private decimal paintQuantity;

        public frmCalcVoidSpaces()
        {
            InitializeComponent();
            totalVoidSpaceArea = 0;
        }

        private void FrmCalcVoidSpaces_Load(object sender, EventArgs e)
        {

        }

        private void TxtHeight_TextChanged(object sender, EventArgs e)
        {
            decimal newVoidHeight = voidHeight;                         //Detects users inputting non-numerical values and displays
                                                                        //an error message for the Users attention.
            if (Decimal.TryParse(txtHeight.Text, out newVoidHeight) == true)
            {
                voidHeight = newVoidHeight;
            }
            else
            {
                MessageBox.Show("Please Enter a valid decimal value", "Error");
            }
        }

        private void TxtWidth_TextChanged(object sender, EventArgs e)
        {
            decimal newVoidWidth = voidWidth;                           //Detects users inputting non-numerical values and displays
                                                                        //an error message for the Users attention.
            if (Decimal.TryParse(txtWidth.Text, out newVoidWidth) == true)
            {
                voidWidth = newVoidWidth;
            }
            else
            {
                MessageBox.Show("Please Enter a valid decimal value", "Error");
            }
        }

        private bool validateDetails()              //Checks that all fields are populated and valid and displays an error message if they aren't
        {
            decimal newVoidWidth = voidWidth;
            decimal newVoidHeight = voidHeight;

            if ((string.IsNullOrWhiteSpace(txtHeight.Text)) || (string.IsNullOrWhiteSpace(txtWidth.Text)) || (Decimal.TryParse(txtWidth.Text, out newVoidWidth) == false) || (Decimal.TryParse(txtHeight.Text, out newVoidHeight) == false))
            {
                MessageBox.Show("Some Fields are blank or do not contain a valid decimal value, please fill in all fields and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
        

        private void BtnSubmit_Click(object sender, EventArgs e)        //Submits Void space dimensions to varaiables
        {
            if(!validateDetails()) {return;}
            decimal newVoidSpaceArea = 0;
            voidSpaceArea = (voidWidth * voidHeight);
            newVoidSpaceArea = (totalVoidSpaceArea + voidSpaceArea);
            totalVoidSpaceArea = (newVoidSpaceArea);
            txtHeight.Text = "0";
            txtWidth.Text = "0";
        }

        private void BtnNext_Click(object sender, EventArgs e) //All the calculations for area, volume and surface area are found below.
        {                                                      //These final values are stored in the variables in the RoomDimensions Class file.
            if ((RoomDimensions.getLengthA()) > 0)
            {
                floorArea = (RoomDimensions.getLengthA() * RoomDimensions.getLengthB()) - (RoomDimensions.getLengthC() * RoomDimensions.getLengthD());
            }
            else
            {
                double pi = Math.PI;
                double radius = decimal.ToDouble(RoomDimensions.getDiameter() / 2);
                double area = pi * radius * radius;
                floorArea = (decimal)area;
            }

            RoomDimensions.setFloorArea(floorArea);
            roomVolume = (RoomDimensions.getHeight() * floorArea);
            RoomDimensions.setRoomVolume(roomVolume);

            if ((RoomDimensions.getLengthA()) > 0)
            {
                roomPerimeter = (RoomDimensions.getLengthA() * 2) + (RoomDimensions.getLengthB() * 2);
                wallSurfaceArea = (RoomDimensions.getHeight() * roomPerimeter);
            }
            else
            {
                double pi = Math.PI;
                double diameter = decimal.ToDouble(RoomDimensions.getDiameter());
                double perimeter = pi * diameter;
                wallSurfaceArea = (decimal)perimeter;
            }

            paintQuantity = ((wallSurfaceArea - totalVoidSpaceArea) / 10);
            RoomDimensions.setPaintRequired(paintQuantity);

            frmResults form4 = new frmResults();
            form4.Visible = true;
            this.Hide();
        }
    }
}
