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
            drawing = new Bitmap(board.Width, board.Height);
            this.Text = "Untiled*";

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //Graphics myGraphics = panel1.CreateGraphics();
            //panel1.BringToFront();
            ////myGraphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            ////var myPen = new Brushes();
            //Bitmap my = new Bitmap(@"D:\我的文档\Pictures\carina-nebula-3840x2400-wide-wallpapers.net.jpg");
            //myGraphics.DrawRectangle(Pens.Red, 0, 0, 600, 40);
            ////this.CreateGraphics().DrawRectangle(Pens.Red, 0, 0, 500, 500);
            ////myGraphics.DrawImage(my, new PointF(0, 0));
            ////panel1.CreateGraphics().DrawRectangle(myPen, 0, 0, 300, 300);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics myGraphics = board.CreateGraphics();
            board.BringToFront();
            //myGraphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            //var myPen = new Brushes();
            Bitmap my = new Bitmap(@"D:\我的文档\Pictures\carina-nebula-3840x2400-wide-wallpapers.net.jpg");
            myGraphics.DrawRectangle(Pens.Red, 0, 0, 40, 40);
            //this.CreateGraphics().DrawRectangle(Pens.Red, 0, 0, 500, 500);
            myGraphics.DrawImage(my, new PointF(0, 0));
            //panel1.CreateGraphics().DrawRectangle(myPen, 0, 0, 300, 300);
        }

        public bool canDraw { get; set; } = false;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if(!stared)
            {
                this.Text = this.Text + "*";
                stared = true;
            }
            canDraw = true;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            path.Clear();
            canDraw = false;
        }

        public Bitmap drawing { get; set; } = null;
        public Brush brush { get; set; } = Brushes.Blue;
        public Pen myPen { get; set; } = Pens.Blue;
        public List<Point> path { get; set; } = new List<Point>();

        public bool penMode { get; set; } = true;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            //Graphics g = board.CreateGraphics();
            if (canDraw)
            {

                Graphics g = Graphics.FromImage(drawing);
                //Console.WriteLine(path.Count);
                path.Add(new Point(e.X, e.Y));
                if (penMode)
                {

                    if (path.Count < 2)
                        return;
                    
                    g.DrawLines(myPen, path.ToArray());

                }
                else
                {
                    if (path.Count < 2)
                        return;
                    fillGap(path);
                    foreach (var p in path)
                    {
                        g.FillEllipse(brush, p.X - 2, p.Y - 2, 4, 4);
                    }
                    //g.FillEllipse(brush, e.X - 2, e.Y - 2, 4, 4);
                }

                // keep the path small
                path.RemoveRange(0, path.Count - 2);
                //var buf = path[path.Count - 1];
                //path.Clear();
                //path.Add(buf);

                board.CreateGraphics().DrawImage(drawing, new Point(0, 0));
            }
        }
        public void fillGap(List<Point> path)
        {


            List<Tuple<int, int>> target = new List<Tuple<int, int>>();
            List<Point> final = path.ConvertAll(p => new Point(p.X,p.Y));

            int total = path.Count - 2;
            int offset = 0;
            for (int i = 0; i < total; i++)
            {
                target.Clear();
                var cur = final[i];
                var vec = new Tuple<int ,int>(final[i + 1].X - cur.X, final[i + 1].Y - cur.Y);
                //var distance = next.
                divide(new Tuple<int, int>(cur.X, cur.Y), vec.Item1, vec.Item2, target);
                target.Sort((IComparer<Tuple<int, int>>)new sorter());
                foreach (var p in target)
                {
                    path.Insert(i+offset++, new Point(p.Item1, p.Item2));
                }
            }
            //foreach (var item in target)
            //{
            //    Console.WriteLine(item.Item1 + "  " + item.Item2);
            //}

        }

        // sorting method
        public class sorter : IComparer<Tuple<int, int>>
        {
            public int Compare(Tuple<int, int> x, Tuple<int, int> y)
            {
                return x.Item1.CompareTo(y.Item1);
            }
        }
        public void divide(Tuple<int,int> ori, int midX, int midY,List<Tuple<int,int>> target)
        {

            if (Math.Abs( midX) < 1 && Math.Abs( midY) < 1)
                return;

            int X = midX / 2;
            int Y = midY / 2;
            target.Add(new Tuple<int, int>(ori.Item1 + X, ori.Item2 + Y));
            divide(ori, X, Y,target);
            divide(new Tuple<int, int>(ori.Item1 + X, ori.Item2 + Y), X, Y, target);

        }

        public ColorDialog colorPic { get; set; } = new ColorDialog();
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            
            if (colorPic.ShowDialog() == DialogResult.OK)
            {
                myPen = new Pen(colorPic.Color);
            }
        }
        public SaveFileDialog saver { get; set; } = new SaveFileDialog();
        public bool stared { get; set; } = true;

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (saver.FileName.Length == 0 || ModifierKeys == Keys.Shift)
            {
                saver.DefaultExt = "*.jpg";
                saver.Filter = "image |*.jpg";

                // Determine whether the user selected a file name from the saveFileDialog. 
                if (saver.ShowDialog() == DialogResult.OK &&
                   saver.FileName.Length > 0)
                {
                    // Save the contents of the RichTextBox into the file.
                    drawing.Save(saver.FileName);
                    this.Text = saver.FileName;
                    stared = false;
                }
            }
            else
            {
                drawing.Save(saver.FileName);
                this.Text = saver.FileName;
                stared = false;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            penMode = true;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            penMode = false;
        }

        private void board_Paint(object sender, PaintEventArgs e)
        {
            //if (canDraw)
            //{
            //    var p = board.PointToClient(board.Location);
            //    var cur = (new Point(MousePosition.X-p.X,MousePosition.Y-p.Y));
            //    label1.Text = cur.X + "" + cur.Y;
            //    path.Add(cur);

            //    if (path.Count < 2)
            //        return;
            //    Console.WriteLine(path.Count);
            //    Graphics g = Graphics.FromImage(drawing);
            //    if (penMode)
            //    {
            //        g.DrawLines(myPen, path.ToArray());

            //    }
            //    else
            //    {
            //        g.FillEllipse(brush, cur.X-2,cur.Y-2, 4, 4);
            //    }



            //    board.CreateGraphics().DrawImage(drawing, new Point(0, 0));
            //}
        }
    }
}
