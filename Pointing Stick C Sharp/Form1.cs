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
        int StatusLeft=0, StatusRight=0;

        public frmPSTest()
        {
            InitializeComponent();

            picTestArea.MouseMove += new System.Windows.Forms.MouseEventHandler(picTestArea_MouseMove);
            picTestArea.MouseDown += new System.Windows.Forms.MouseEventHandler(MouseDown);
            picTestArea.MouseUp += new System.Windows.Forms.MouseEventHandler(MouseUp);
        }

        private void frmPSTest_Load(object sender, EventArgs e)
        {

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

        private new void MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    Console.WriteLine("Down Left");
                    btnLeftClick.BackColor = Color.LightBlue;
                    StatusLeft = 1;  // Set Status as being down
                    break;
                case MouseButtons.Right:
                    Console.WriteLine("Down Right");
                    btnRightClick.BackColor = Color.LightBlue;
                    StatusRight = 1;  // Set Status as being down
                    break;
                default:
                    break;

            }
        }
        private new void MouseUp(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    Console.WriteLine("Up Left");
                    if (StatusLeft == 1)
                    {
                        btnLeftClick.BackColor = Color.LightGreen; ;
                        StatusLeft = 0;
                    }
                    else
                    {
                        btnRightClick.BackColor = Color.Red;
                        StatusLeft = 0;
                    }
                    break;
                case MouseButtons.Right:
                    Console.WriteLine("Up Right");
                    if (StatusRight == 1)
                    {
                        btnRightClick.BackColor = Color.LightGreen;
                        StatusRight = 0;
                    }
                    else
                    {
                        btnRightClick.BackColor = Color.Red;
                        StatusRight = 0;
                    }
                    break;
                default:
                    break;

            }
        }

        private void picTestArea_MouseMove(object sender, MouseEventArgs e)
        {
            if (picTestArea.Image == null)
            {
                Bitmap bmp = new Bitmap(picTestArea.Width, picTestArea.Height);
                picTestArea.Image = bmp;
            }

            using (Graphics g = Graphics.FromImage(picTestArea.Image))
            {
                //we need to create a Graphics object to draw on the picture box, its our main tool
                //when making a Pen object, you can just give it color only or give it color and pen size

                g.DrawLine(new Pen(Color.Black, 1), lastPoint, e.Location);
                g.SmoothingMode = SmoothingMode.AntiAlias;

                //this is to give the drawing a more smoother, less sharper look
            }

            picTestArea.Invalidate();       //refreshes the picturebox
            lastPoint = e.Location;         //keep assigning the lastPoint to the current mouse position
            txtXpos.Text = e.Location.X.ToString();
            txtYpos.Text = e.Location.Y.ToString();
        }

        private void ExitTest()
        {
            this.Close(); 
        }

        private void RememeberPosition()
        {
        }

        private void RestartTest()
        {
            picTestArea.Image = null;
            btnLeftClick.BackColor = Color.LightGray;
            btnRightClick.BackColor = Color.LightGray;
            StatusLeft = 0;
            StatusRight = 0;
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            this.RestartTest();
        }

        private void btnLeftClick_Click(object sender, EventArgs e)
        {

        }
    }


}
