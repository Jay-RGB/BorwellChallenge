namespace BorwellChallenge1
{
    partial class frmCalcVoidSpaces
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
            this.lblInstructions = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.lblInstructionsHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(116, 85);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(421, 60);
            this.lblInstructions.TabIndex = 19;
            this.lblInstructions.Text = "Enter the Height and Width of one of the door/windows \r\nand then click \"Submit\" t" +
    "o save the dimensions. \r\nRepeat for each Door/Window and then click Next.";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(295, 258);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(111, 35);
            this.btnSubmit.TabIndex = 18;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(609, 366);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(111, 35);
            this.btnNext.TabIndex = 16;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidth.Location = new System.Drawing.Point(116, 195);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(52, 20);
            this.lblWidth.TabIndex = 15;
            this.lblWidth.Text = "Width";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeight.Location = new System.Drawing.Point(116, 167);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(58, 20);
            this.lblHeight.TabIndex = 14;
            this.lblHeight.Text = "Height";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(255, 192);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(192, 22);
            this.txtWidth.TabIndex = 13;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(255, 164);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(192, 22);
            this.txtHeight.TabIndex = 12;
            // 
            // lblInstructionsHeader
            // 
            this.lblInstructionsHeader.AutoSize = true;
            this.lblInstructionsHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructionsHeader.Location = new System.Drawing.Point(80, 50);
            this.lblInstructionsHeader.Name = "lblInstructionsHeader";
            this.lblInstructionsHeader.Size = new System.Drawing.Size(491, 25);
            this.lblInstructionsHeader.TabIndex = 11;
            this.lblInstructionsHeader.Text = "Please input the dimensions of each Door and Window:";
            // 
            // frmCalcVoidSpaces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.lblInstructionsHeader);
            this.Name = "frmCalcVoidSpaces";
            this.Text = "Borwell Challenge - Paint Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblInstructions;
        internal System.Windows.Forms.Button btnSubmit;
        internal System.Windows.Forms.Button btnNext;
        internal System.Windows.Forms.Label lblWidth;
        internal System.Windows.Forms.Label lblHeight;
        internal System.Windows.Forms.TextBox txtWidth;
        internal System.Windows.Forms.TextBox txtHeight;
        internal System.Windows.Forms.Label lblInstructionsHeader;
    }
}