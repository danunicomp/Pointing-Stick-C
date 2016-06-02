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
        private Graphics paper;
        private Pen pen;
    

        public frmPSTest()
        {
            InitializeComponent();
            paper = this.CreateGraphics();
            pen = new Pen(Color.Black);
            pen.Width = 1;

            pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(pictureBox1_MouseMove);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(panel2_MouseMove);
        }

        private void frmPSTest_Load(object sender, EventArgs e)
        {

        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            //  Console.WriteLine("Move:");



        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel2_MouseEnter(object sender, System.EventArgs e)
        {
            // Update the mouse event label to indicate the MouseEnter event occurred.
            Console.WriteLine("Mouse Enter");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                pictureBox1.Image = bmp;
            }

            using (Graphics g = Graphics.FromImage(pictureBox1.Image))
            {
                //we need to create a Graphics object to draw on the picture box, its our main tool
                //when making a Pen object, you can just give it color only or give it color and pen size

                g.DrawLine(new Pen(Color.Black, 1), lastPoint, e.Location);
                g.SmoothingMode = SmoothingMode.AntiAlias;

                //this is to give the drawing a more smoother, less sharper look
            }

            pictureBox1.Invalidate();       //refreshes the picturebox
            lastPoint = e.Location;         //keep assigning the lastPoint to the current mouse position
        }
    }
}
