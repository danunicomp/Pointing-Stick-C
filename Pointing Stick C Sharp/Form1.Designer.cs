namespace Pointing_Stick_C_Sharp
{
    partial class frmPSTest
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
            this.btnDriftResult = new System.Windows.Forms.Button();
            this.btnRightClick = new System.Windows.Forms.Button();
            this.btnLeftClick = new System.Windows.Forms.Button();
            this.btnRememberPos = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.lblMouseCoord = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtXpos = new System.Windows.Forms.TextBox();
            this.txtYpos = new System.Windows.Forms.TextBox();
            this.picTestArea = new System.Windows.Forms.PictureBox();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTestArea)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDriftResult
            // 
            this.btnDriftResult.Location = new System.Drawing.Point(13, 356);
            this.btnDriftResult.Name = "btnDriftResult";
            this.btnDriftResult.Size = new System.Drawing.Size(171, 45);
            this.btnDriftResult.TabIndex = 18;
            this.btnDriftResult.UseVisualStyleBackColor = true;
            // 
            // btnRightClick
            // 
            this.btnRightClick.Location = new System.Drawing.Point(109, 309);
            this.btnRightClick.Name = "btnRightClick";
            this.btnRightClick.Size = new System.Drawing.Size(75, 40);
            this.btnRightClick.TabIndex = 17;
            this.btnRightClick.Text = "RIGHT CLICK";
            // 
            // btnLeftClick
            // 
            this.btnLeftClick.Location = new System.Drawing.Point(13, 309);
            this.btnLeftClick.Name = "btnLeftClick";
            this.btnLeftClick.Size = new System.Drawing.Size(75, 40);
            this.btnLeftClick.TabIndex = 16;
            this.btnLeftClick.Text = "LEFT CLICK";
            this.btnLeftClick.Click += new System.EventHandler(this.btnLeftClick_Click);
            // 
            // btnRememberPos
            // 
            this.btnRememberPos.Location = new System.Drawing.Point(425, 343);
            this.btnRememberPos.Name = "btnRememberPos";
            this.btnRememberPos.Size = new System.Drawing.Size(75, 23);
            this.btnRememberPos.TabIndex = 21;
            this.btnRememberPos.Text = "F4 - Lock";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(425, 378);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "F10 - Exit";
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(425, 309);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(75, 23);
            this.btnRestart.TabIndex = 19;
            this.btnRestart.Text = "F1 - Restart";
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // Panel1
            // 
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel1.Controls.Add(this.lblMouseCoord);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Controls.Add(this.txtXpos);
            this.Panel1.Controls.Add(this.txtYpos);
            this.Panel1.Location = new System.Drawing.Point(217, 309);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(144, 64);
            this.Panel1.TabIndex = 22;
            // 
            // lblMouseCoord
            // 
            this.lblMouseCoord.AutoSize = true;
            this.lblMouseCoord.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMouseCoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMouseCoord.Location = new System.Drawing.Point(8, 8);
            this.lblMouseCoord.Name = "lblMouseCoord";
            this.lblMouseCoord.Size = new System.Drawing.Size(127, 18);
            this.lblMouseCoord.TabIndex = 7;
            this.lblMouseCoord.Text = "Mouse Coordinates";
            this.lblMouseCoord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(16, 32);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(19, 16);
            this.Label2.TabIndex = 11;
            this.Label2.Text = "X:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(80, 32);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(20, 16);
            this.Label1.TabIndex = 10;
            this.Label1.Text = "Y:";
            // 
            // txtXpos
            // 
            this.txtXpos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtXpos.Location = new System.Drawing.Point(32, 32);
            this.txtXpos.Name = "txtXpos";
            this.txtXpos.Size = new System.Drawing.Size(32, 20);
            this.txtXpos.TabIndex = 8;
            this.txtXpos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtYpos
            // 
            this.txtYpos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtYpos.Location = new System.Drawing.Point(96, 32);
            this.txtYpos.Name = "txtYpos";
            this.txtYpos.Size = new System.Drawing.Size(32, 20);
            this.txtYpos.TabIndex = 9;
            this.txtYpos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // picTestArea
            // 
            this.picTestArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picTestArea.Location = new System.Drawing.Point(12, 12);
            this.picTestArea.Name = "picTestArea";
            this.picTestArea.Size = new System.Drawing.Size(488, 280);
            this.picTestArea.TabIndex = 24;
            this.picTestArea.TabStop = false;
            // 
            // frmPSTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 416);
            this.Controls.Add(this.picTestArea);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.btnRememberPos);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnDriftResult);
            this.Controls.Add(this.btnRightClick);
            this.Controls.Add(this.btnLeftClick);
            this.Name = "frmPSTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unicomp Pointing Stick Test. C#";
            this.Load += new System.EventHandler(this.frmPSTest_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTestArea)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.Button btnDriftResult;
        internal System.Windows.Forms.Button btnRightClick;
        internal System.Windows.Forms.Button btnLeftClick;
        internal System.Windows.Forms.Button btnRememberPos;
        internal System.Windows.Forms.Button btnExit;
        internal System.Windows.Forms.Button btnRestart;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label lblMouseCoord;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtXpos;
        internal System.Windows.Forms.TextBox txtYpos;
        private System.Windows.Forms.PictureBox picTestArea;
    }
}

