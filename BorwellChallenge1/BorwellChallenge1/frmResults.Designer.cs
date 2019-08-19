namespace BorwellChallenge1
{
    partial class frmResults
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPaintWastageResult = new System.Windows.Forms.Label();
            this.lblPaintResult = new System.Windows.Forms.Label();
            this.lblVolumeResult = new System.Windows.Forms.Label();
            this.lblAreaResult = new System.Windows.Forms.Label();
            this.lblWallPaint = new System.Windows.Forms.Label();
            this.lblRoomVolume = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblWallPaintWastage = new System.Windows.Forms.Label();
            this.lblFloorArea = new System.Windows.Forms.Label();
            this.lblResultsHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPaintWastageResult
            // 
            this.lblPaintWastageResult.AutoSize = true;
            this.lblPaintWastageResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaintWastageResult.Location = new System.Drawing.Point(567, 203);
            this.lblPaintWastageResult.Name = "lblPaintWastageResult";
            this.lblPaintWastageResult.Size = new System.Drawing.Size(0, 20);
            this.lblPaintWastageResult.TabIndex = 25;
            // 
            // lblPaintResult
            // 
            this.lblPaintResult.AutoSize = true;
            this.lblPaintResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaintResult.Location = new System.Drawing.Point(599, 154);
            this.lblPaintResult.Name = "lblPaintResult";
            this.lblPaintResult.Size = new System.Drawing.Size(0, 20);
            this.lblPaintResult.TabIndex = 24;
            // 
            // lblVolumeResult
            // 
            this.lblVolumeResult.AutoSize = true;
            this.lblVolumeResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolumeResult.Location = new System.Drawing.Point(459, 124);
            this.lblVolumeResult.Name = "lblVolumeResult";
            this.lblVolumeResult.Size = new System.Drawing.Size(0, 20);
            this.lblVolumeResult.TabIndex = 23;
            // 
            // lblAreaResult
            // 
            this.lblAreaResult.AutoSize = true;
            this.lblAreaResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreaResult.Location = new System.Drawing.Point(431, 95);
            this.lblAreaResult.Name = "lblAreaResult";
            this.lblAreaResult.Size = new System.Drawing.Size(0, 20);
            this.lblAreaResult.TabIndex = 22;
            // 
            // lblWallPaint
            // 
            this.lblWallPaint.AutoSize = true;
            this.lblWallPaint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWallPaint.Location = new System.Drawing.Point(116, 153);
            this.lblWallPaint.Name = "lblWallPaint";
            this.lblWallPaint.Size = new System.Drawing.Size(381, 20);
            this.lblWallPaint.TabIndex = 21;
            this.lblWallPaint.Text = "The Amount of Paint required to paint the walls is:";
            // 
            // lblRoomVolume
            // 
            this.lblRoomVolume.AutoSize = true;
            this.lblRoomVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomVolume.Location = new System.Drawing.Point(116, 123);
            this.lblRoomVolume.Name = "lblRoomVolume";
            this.lblRoomVolume.Size = new System.Drawing.Size(217, 20);
            this.lblRoomVolume.TabIndex = 20;
            this.lblRoomVolume.Text = "The Volume of the Room is:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(609, 366);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(111, 34);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // lblWallPaintWastage
            // 
            this.lblWallPaintWastage.AutoSize = true;
            this.lblWallPaintWastage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWallPaintWastage.Location = new System.Drawing.Point(116, 182);
            this.lblWallPaintWastage.Name = "lblWallPaintWastage";
            this.lblWallPaintWastage.Size = new System.Drawing.Size(363, 40);
            this.lblWallPaintWastage.TabIndex = 17;
            this.lblWallPaintWastage.Text = "The Amount of Paint required to paint the walls \r\nwith a 10% allowance for wastag" +
    "e is:";
            // 
            // lblFloorArea
            // 
            this.lblFloorArea.AutoSize = true;
            this.lblFloorArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFloorArea.Location = new System.Drawing.Point(116, 94);
            this.lblFloorArea.Name = "lblFloorArea";
            this.lblFloorArea.Size = new System.Drawing.Size(190, 20);
            this.lblFloorArea.TabIndex = 16;
            this.lblFloorArea.Text = "The Area of the Floor is:";
            // 
            // lblResultsHeader
            // 
            this.lblResultsHeader.AutoSize = true;
            this.lblResultsHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultsHeader.Location = new System.Drawing.Point(80, 50);
            this.lblResultsHeader.Name = "lblResultsHeader";
            this.lblResultsHeader.Size = new System.Drawing.Size(82, 25);
            this.lblResultsHeader.TabIndex = 15;
            this.lblResultsHeader.Text = "Results:";
            // 
            // frmResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPaintWastageResult);
            this.Controls.Add(this.lblPaintResult);
            this.Controls.Add(this.lblVolumeResult);
            this.Controls.Add(this.lblAreaResult);
            this.Controls.Add(this.lblWallPaint);
            this.Controls.Add(this.lblRoomVolume);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblWallPaintWastage);
            this.Controls.Add(this.lblFloorArea);
            this.Controls.Add(this.lblResultsHeader);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmResults";
            this.Text = "Borwell Challenge - Paint Calculator";
            this.Load += new System.EventHandler(this.FrmResults_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblPaintWastageResult;
        internal System.Windows.Forms.Label lblPaintResult;
        internal System.Windows.Forms.Label lblVolumeResult;
        internal System.Windows.Forms.Label lblAreaResult;
        internal System.Windows.Forms.Label lblWallPaint;
        internal System.Windows.Forms.Label lblRoomVolume;
        internal System.Windows.Forms.Button btnExit;
        internal System.Windows.Forms.Label lblWallPaintWastage;
        internal System.Windows.Forms.Label lblFloorArea;
        internal System.Windows.Forms.Label lblResultsHeader;
    }
}