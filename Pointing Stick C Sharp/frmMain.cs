using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Diagnostics;

namespace Pointing_Stick_C_Sharp
{
    public partial class frmPSTest : Form
    {
        Point lastPoint = Point.Empty;//Point.Empty represents null for a Point object
        int StatusLeft=0, StatusRight=0;
        string strVersion = "Version 1.0 Modified June 14, 2016";
        bool DebugMode = false;
        int iRememberedX, iRememberedY;
        bool bolRememberedMode = false, bolDrift = false;
        int iCurrentPosX, iCurrentPosY;

        public frmPSTest()
        {
            InitializeComponent();
            Debug.Assert(DebugMode = true);

            picTestArea.MouseMove += new System.Windows.Forms.MouseEventHandler(picTestArea_MouseMove);
            picTestArea.MouseDown += new System.Windows.Forms.MouseEventHandler(MouseDown);
            picTestArea.MouseUp += new System.Windows.Forms.MouseEventHandler(MouseUp);
        }

        private void frmPSTest_Load(object sender, EventArgs e)
        {
            lblInfo.Text = strVersion;
            this.ResetText();
            // frmPSTest.ActiveForm.Text = "Unicomp Pointing Stick Test. C#";
            this.Text = "Unicomp PS C# " + strVersion;
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
                   
                    if (DebugMode) Console.WriteLine("Down Left");
                    btnLeftClick.BackColor = Color.LightBlue;
                    StatusLeft = 1;  // Set Status as being down
                    break;
                case MouseButtons.Right:
                    if (DebugMode) Console.WriteLine("Down Right");
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
                    if (DebugMode) Console.WriteLine("Up Left");
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
                    if (DebugMode) Console.WriteLine("Up Right");
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
            iCurrentPosX = e.Location.X;
            iCurrentPosY = e.Location.Y;
            txtXpos.Text = iCurrentPosX.ToString();
            txtYpos.Text = iCurrentPosY.ToString();

            // REMEMBER MODE
            if (bolRememberedMode == true)
            {
                if (iRememberedX != iCurrentPosX || iRememberedY != iCurrentPosY)
                {
                 //   Console.WriteLine("DRIFT");
                }
            }
            else
            {
                txtRememberedX.Text = iCurrentPosX.ToString();
                txtRememberedY.Text = iCurrentPosY.ToString();
            }

            if (bolRememberedMode && bolDrift != true)
            {

                //Console.WriteLine("Remembered Mode");
                if (iRememberedX != iCurrentPosX || iRememberedY != iCurrentPosY)
                {
                    // Console.WriteLine("DRIFT");
                    bolDrift = true;
                }
            }

            if (bolDrift)
            {
                DoFail();
            }

        }

        //
        // EXIT TEST PROGRAM
        //
        private void ExitTest()
        {
            this.Close(); 
        }

        //
        // REMEMBER POSITION COORDINATES
        //
        private void RememeberPosition()
        {
            bolRememberedMode = true;
            iRememberedX = iCurrentPosX;
            iRememberedY = iCurrentPosY;
            txtRememberedX.Text = iCurrentPosX.ToString();
            txtRememberedY.Text = iCurrentPosY.ToString();
            btnDriftResult.BackColor = Color.LightBlue;
            btnDriftResult.Text = "NO DRIFT";
        }

        private void DoFail()
        {
            btnDriftResult.BackColor = Color.Red;
            btnDriftResult.Text = "DRIFT";
        }

        //
        // CLEAR EVERYTHING AND RESTART TEST
        //
        private void RestartTest()
        {
            picTestArea.Image = null;
            btnLeftClick.BackColor = Color.LightGray;
            btnRightClick.BackColor = Color.LightGray;
            StatusLeft = 0;
            StatusRight = 0;
            bolRememberedMode = false;
            iRememberedX = iCurrentPosX;
            iRememberedY = iCurrentPosY;
            txtRememberedX.Text = iCurrentPosX.ToString();
            txtRememberedY.Text = iCurrentPosY.ToString();
            bolDrift = false;
            btnDriftResult.BackColor = Color.LightGray;
            btnDriftResult.Text = "";
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            this.RestartTest();
        }

        private void btnRememberPos_Click(object sender, EventArgs e)
        {
            RememeberPosition();
        }
    }
}
