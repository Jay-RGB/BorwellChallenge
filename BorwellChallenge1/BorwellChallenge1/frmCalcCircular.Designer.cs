﻿namespace BorwellChallenge1
{
    partial class frmCalcCircular
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalcCircular));
            this.imgExample = new System.Windows.Forms.PictureBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblLengthA = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtLengthA = new System.Windows.Forms.TextBox();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblWarning = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgExample)).BeginInit();
            this.SuspendLayout();
            // 
            // imgExample
            // 
            this.imgExample.Image = ((System.Drawing.Image)(resources.GetObject("imgExample.Image")));
            this.imgExample.Location = new System.Drawing.Point(492, 119);
            this.imgExample.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgExample.Name = "imgExample";
            this.imgExample.Size = new System.Drawing.Size(267, 148);
            this.imgExample.TabIndex = 17;
            this.imgExample.TabStop = false;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(609, 366);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(111, 34);
            this.btnNext.TabIndex = 15;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeight.Location = new System.Drawing.Point(83, 150);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(58, 20);
            this.lblHeight.TabIndex = 14;
            this.lblHeight.Text = "Height";
            // 
            // lblLengthA
            // 
            this.lblLengthA.AutoSize = true;
            this.lblLengthA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLengthA.Location = new System.Drawing.Point(83, 122);
            this.lblLengthA.Name = "lblLengthA";
            this.lblLengthA.Size = new System.Drawing.Size(162, 20);
            this.lblLengthA.TabIndex = 13;
            this.lblLengthA.Text = "Length A (Diameter)";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(269, 149);
            this.txtHeight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(192, 22);
            this.txtHeight.TabIndex = 12;
            this.txtHeight.TextChanged += new System.EventHandler(this.TxtHeight_TextChanged);
            // 
            // txtLengthA
            // 
            this.txtLengthA.Location = new System.Drawing.Point(269, 122);
            this.txtLengthA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLengthA.Name = "txtLengthA";
            this.txtLengthA.Size = new System.Drawing.Size(192, 22);
            this.txtLengthA.TabIndex = 11;
            this.txtLengthA.TextChanged += new System.EventHandler(this.TxtLengthA_TextChanged);
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(80, 50);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(366, 25);
            this.lblInstructions.TabIndex = 10;
            this.lblInstructions.Text = "Please input the room dimensions below:";
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.Location = new System.Drawing.Point(83, 85);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(323, 20);
            this.lblWarning.TabIndex = 21;
            this.lblWarning.Text = "(Dimensions should be entered in metres)";
            // 
            // frmCalcCircular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.imgExample);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblLengthA);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtLengthA);
            this.Controls.Add(this.lblInstructions);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmCalcCircular";
            this.Text = "Borwell Challenge - Paint Calculator";
            this.Load += new System.EventHandler(this.FrmCalcCircular_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgExample)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox imgExample;
        internal System.Windows.Forms.Button btnNext;
        internal System.Windows.Forms.Label lblHeight;
        internal System.Windows.Forms.Label lblLengthA;
        internal System.Windows.Forms.TextBox txtHeight;
        internal System.Windows.Forms.TextBox txtLengthA;
        internal System.Windows.Forms.Label lblInstructions;
        internal System.Windows.Forms.Label lblWarning;
    }
}