using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diaryBook
{
    public partial class DrawForm : Form
    {
        public DrawForm()
        {
            InitializeComponent();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics myGraphics = panel1.CreateGraphics();
            panel1.BringToFront();
            //myGraphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            //var myPen = new Brushes();
            Bitmap my = new Bitmap(@"D:\我的文档\Pictures\carina-nebula-3840x2400-wide-wallpapers.net.jpg");
            myGraphics.DrawRectangle(Pens.Red, 0, 0, 600, 40);
            //this.CreateGraphics().DrawRectangle(Pens.Red, 0, 0, 500, 500);
            //myGraphics.DrawImage(my, new PointF(0, 0));
            //panel1.CreateGraphics().DrawRectangle(myPen, 0, 0, 300, 300);
        }
    }
}
