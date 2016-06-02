using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;


namespace Pointing_Stick_C_Sharp
{
    public partial class frmPSTest : Form
    {
        Point lastPoint = Point.Empty;//Point.Empty represents null for a Point object

        public frmPSTest()
        {
            InitializeComponent();

            picTestArea.MouseMove += new System.Windows.Forms.MouseEventHandler(picTestArea_MouseMove);
            picTestArea.MouseClick += new System.Windows.Forms.MouseEventHandler(picTestArea_MouseClick);
        }

        
        private void frmPSTest_Load(object sender, EventArgs e)
        {

        }

        

        private void frmPSTest_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            Console.WriteLine("Keypress");
        }

        private void picTestArea_Click(object sender, EventArgs e)
        {

        }
        private void picTestArea_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            this.RestartTest();
        }

        private void btnRememberPos_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.ExitTest();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F1:
                    this.RestartTest();
                    break;
                case Keys.F4:
                    this.RememeberPosition();
                    break;
                case Keys.F10:
                    this.ExitTest();
                    break;
            }
            return true;
        }

        private void RestartTest()
        {
            picTestArea.Image = null;
        }

        private void ExitTest()
        {
            this.Close();
        }

        private void RememeberPosition()
        {

        }

        private void picTestArea_MouseClick(object sender, MouseEventArgs e)
        {
            Console.WriteLine("CLick");
        }
    }
}
