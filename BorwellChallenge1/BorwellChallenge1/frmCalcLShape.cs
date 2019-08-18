﻿using System;
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
            decimal newLengthA = lLengthA;

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
            decimal newLengthB = lLengthB;

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
            decimal newLengthC = lLengthC;

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
            decimal newLengthD = lLengthD;

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
            decimal newHeight = lHeight;

            if (Decimal.TryParse(txtHeight.Text, out newHeight) == true)
            {
                lHeight = newHeight;
            }
            else
            {
                MessageBox.Show("Please Enter a valid decimal value", "Error");
            }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            RoomDimensions newDimensions = new RoomDimensions();
            newDimensions.setLengthA(lLengthA);
            newDimensions.setLengthB(lLengthB);
            newDimensions.setLengthC(lLengthC);
            newDimensions.setLengthD(lLengthD);
            newDimensions.setHeight(lHeight);
            frmCalcVoidSpaces form3 = new frmCalcVoidSpaces();
            form3.Visible = true;
            this.Hide();
        }
    }
}
