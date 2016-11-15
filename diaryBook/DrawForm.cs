using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace diaryBook
{
    public partial class DrawForm : Form
    {
        private displayItem thisFile;

        public DrawForm()
        {
            InitializeComponent();
            init();
        }
        public DrawForm(displayItem file)
        {

            // bug: load big picture
            InitializeComponent();
            init();
            thisFile = file;
            saver.FileName = file.filePath;

            
        }


        private void init()
        {
            drawing = new Bitmap(board.Width, board.Height);
            this.Text = "Untiled*";
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



        #region drawing
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
        public List<PointF> path { get; set; } = new List<PointF>();

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
                        Console.WriteLine(p.X+"   "+p.Y);
                        g.FillEllipse(brush, p.X, p.Y, 4, 4);
                    }
                    Console.WriteLine("=========================");
                }

                path.RemoveRange(0, path.Count - 2);

                board.CreateGraphics().DrawImage(drawing, new Point(0, 0));
                g.Dispose();
            }
        }
        public void fillGap(List<PointF> path)
        {
            List<Tuple<float, float>> target = new List<Tuple<float, float>>();
            List<PointF> final = path.ConvertAll(p => new PointF(p.X,p.Y));

            int total = path.Count - 2;
            int offset = 0;
            for (int i = 0; i < total; i++)
            {
                target.Clear();
                var cur = final[i];
                var vec = new Tuple<float ,float>(final[i + 1].X - cur.X, final[i + 1].Y - cur.Y);
                //var distance = next.
                divide(new Tuple<float, float>(cur.X, cur.Y), vec.Item1, vec.Item2, target);
                target.Sort((IComparer<Tuple<float, float>>)new sorter());
                foreach (var p in target)
                {
                    //Console.WriteLine(p.Item1+"  "+p.Item2);
                    path.Insert(i+offset++, new PointF(p.Item1, p.Item2));
                }
            }
        }

        // sorting method
        private class sorter : IComparer<Tuple<float, float>>
        {
            public int Compare(Tuple<float,float> x, Tuple<float, float> y)
            {
                return x.Item1.CompareTo(y.Item1);
            }
        }
        public void divide(Tuple<float,float> ori, float midX, float midY,List<Tuple<float,float>> target)
        {
            if (Math.Abs( midX) < 2 && Math.Abs( midY) < 2)
                return;

            float X = midX / 2;
            float Y = midY / 2;
            target.Add(new Tuple<float, float>(ori.Item1 + X, ori.Item2 + Y));
            divide(ori, X, Y,target);
            divide(new Tuple<float, float>(ori.Item1 + X, ori.Item2 + Y), X, Y, target);
        }
        #endregion


        public ColorDialog colorPic { get; set; } = new ColorDialog();
        private void colorPicButton(object sender, EventArgs e)
        {
            if (colorPic.ShowDialog() == DialogResult.OK)
            {
                myPen = new Pen(colorPic.Color);
                brush = new SolidBrush(colorPic.Color);
            }
        }
        public SaveFileDialog saver { get; set; } = new SaveFileDialog();
        public bool stared { get; set; } = true;

        private void saveButton(object sender, EventArgs e)
        {
            if (saver.FileName.Length == 0 || ModifierKeys == Keys.Shift)
            {
                saver.DefaultExt = "*.jpg";
                saver.Filter = "image |*.jpg";

                // Determine whether the user selected a file name from the saveFileDialog. 
                if (saver.ShowDialog() == DialogResult.OK &&
                   saver.FileName.Length > 0)
                {
                    string fileName = saver.FileName.Substring(saver.FileName.LastIndexOf('/') + 1);
                    thisFile = new displayItem(fileName, DateTime.Now, "drawing", saver.FileName);
                    tempData.store.Add(thisFile);
                    // Save the contents of the RichTextBox into the file.
                    if (File.Exists(saver.FileName))
                    {
                        File.Delete(saver.FileName);
                    }
                    drawing.Save(saver.FileName);
                    this.Text = saver.FileName;
                    stared = false;
                }
            }
            else
            {
                
                if (File.Exists(saver.FileName))
                {
                    File.Delete(saver.FileName);
                }
                drawing.Save(saver.FileName);
                this.Text = saver.FileName;
                stared = false;

            }
        }

        private void penButton(object sender, EventArgs e)
        {
            penMode = true;
            sizeB.Enabled = true;
        }

        private void brushButton(object sender, EventArgs e)
        {
            penMode = false;
            sizeB.Enabled = false;
        }


        bool small = true;
        private void DrawForm_SizeChanged(object sender, EventArgs e)
        {
            if (small)
            {
                Bitmap buf = new Bitmap(board.Size.Width, board.Size.Height);
                Graphics g = Graphics.FromImage(buf);
                g.DrawImage(drawing, new Point(0, 0));
                board.CreateGraphics().DrawImage(buf, new Point(0, 0));
                drawing = buf;
                small = false;
            }
            else
            {
                small = true;
            }
        }

        private void sizeB_Click(object sender, EventArgs e)
        {

        }

        private bool canClose = true;
        private bool closing = true;               // WHAT THE FUCK!!!!!
        private void DrawForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (canClose)
            {
                if (closing)
                {
                    closing = false;
                    ((startForm)this.Owner).updateObjList();
                    tempData.serialize();
                    this.Hide();
                    this.Owner.BringToFront();
                    //MessageBox.Show(Application.OpenForms.Count.ToString());
                    drawing.Dispose();
                    File.Delete(this.thisFile.filePath + '_');
                    ((startForm)this.Owner).closeForm(this,"");
                }
            }
            else
            {
                e.Cancel = true;
            }
        }


        private bool firsTime = true;
        private void board_Paint(object sender, PaintEventArgs e)
        {
            if (firsTime)
            {
                firsTime = false;
                if (thisFile != null)
                {
                    if (thisFile.filePath!="")
                    {
                        File.Copy(thisFile.filePath, thisFile.filePath + '_');
                        var bufDrawing = new Bitmap(thisFile.filePath+'_');
                        board.CreateGraphics().DrawImage(bufDrawing, new Point(0, 0));

                        Graphics g = Graphics.FromImage(drawing);
                        g.DrawImage(bufDrawing,new Point(0,0));

                        g.Dispose();
                        bufDrawing.Dispose();
                    }
                }

            }
        }
    }
}
