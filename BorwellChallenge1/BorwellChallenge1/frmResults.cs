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
    public partial class frmResults : Form
    {
        private decimal paintRequiredWastage;
        public frmResults()
        {
            InitializeComponent();
            lblAreaResult.Text = (RoomDimensions.getFloorArea()).ToString("0.00") + " m2";
            lblVolumeResult.Text = (RoomDimensions.getRoomVolume()).ToString("0.00") + " m3";
            lblPaintResult.Text = (RoomDimensions.getPaintRequired()).ToString("0.00") + " Litres";
            paintRequiredWastage = (RoomDimensions.getPaintRequired()) * (decimal)1.1;
            lblPaintWastageResult.Text = (paintRequiredWastage).ToString("0.00") + " Litres";
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmResults_Load(object sender, EventArgs e)
        {

        }
    }
}
