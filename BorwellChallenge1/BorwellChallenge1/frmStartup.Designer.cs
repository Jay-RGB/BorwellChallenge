namespace BorwellChallenge1
{
    partial class frmStartup
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
            this.btnNext = new System.Windows.Forms.Button();
            this.rdbtnCircular = new System.Windows.Forms.RadioButton();
            this.rdbtnLShape = new System.Windows.Forms.RadioButton();
            this.rdbtnSquareRectangle = new System.Windows.Forms.RadioButton();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(609, 366);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(111, 35);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // rdbtnCircular
            // 
            this.rdbtnCircular.AutoSize = true;
            this.rdbtnCircular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnCircular.Location = new System.Drawing.Point(86, 183);
            this.rdbtnCircular.Margin = new System.Windows.Forms.Padding(4);
            this.rdbtnCircular.Name = "rdbtnCircular";
            this.rdbtnCircular.Size = new System.Drawing.Size(89, 24);
            this.rdbtnCircular.TabIndex = 8;
            this.rdbtnCircular.TabStop = true;
            this.rdbtnCircular.Text = "Circular";
            this.rdbtnCircular.UseVisualStyleBackColor = true;
            // 
            // rdbtnLShape
            // 
            this.rdbtnLShape.AutoSize = true;
            this.rdbtnLShape.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnLShape.Location = new System.Drawing.Point(86, 148);
            this.rdbtnLShape.Margin = new System.Windows.Forms.Padding(4);
            this.rdbtnLShape.Name = "rdbtnLShape";
            this.rdbtnLShape.Size = new System.Drawing.Size(104, 24);
            this.rdbtnLShape.TabIndex = 7;
            this.rdbtnLShape.TabStop = true;
            this.rdbtnLShape.Text = "\"L\" Shape";
            this.rdbtnLShape.UseVisualStyleBackColor = true;
            // 
            // rdbtnSquareRectangle
            // 
            this.rdbtnSquareRectangle.AutoSize = true;
            this.rdbtnSquareRectangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnSquareRectangle.Location = new System.Drawing.Point(86, 113);
            this.rdbtnSquareRectangle.Margin = new System.Windows.Forms.Padding(4);
            this.rdbtnSquareRectangle.Name = "rdbtnSquareRectangle";
            this.rdbtnSquareRectangle.Size = new System.Drawing.Size(173, 24);
            this.rdbtnSquareRectangle.TabIndex = 6;
            this.rdbtnSquareRectangle.TabStop = true;
            this.rdbtnSquareRectangle.Text = "Square / Rectangle";
            this.rdbtnSquareRectangle.UseVisualStyleBackColor = true;
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(80, 50);
            this.lblInstructions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(433, 25);
            this.lblInstructions.TabIndex = 5;
            this.lblInstructions.Text = "Please select the room shape from the list below:";
            // 
            // frmStartup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.rdbtnCircular);
            this.Controls.Add(this.rdbtnLShape);
            this.Controls.Add(this.rdbtnSquareRectangle);
            this.Controls.Add(this.lblInstructions);
            this.Name = "frmStartup";
            this.Text = "Borwell Challenge - Paint Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnNext;
        internal System.Windows.Forms.RadioButton rdbtnCircular;
        internal System.Windows.Forms.RadioButton rdbtnLShape;
        internal System.Windows.Forms.RadioButton rdbtnSquareRectangle;
        internal System.Windows.Forms.Label lblInstructions;
    }
}

