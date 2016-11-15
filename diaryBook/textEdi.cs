using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace diaryBook
{
    public partial class TextEdi : Form
    {
        public SaveFileDialog saveFile1 { get; set; }
        public FontDialog font { get; set; } 
        public ColorDialog colorPicker { get; set; }
        public bool stared { get; set; } = true;
        private displayItem thisFile;

        #region constructor
        public TextEdi()
        {
            InitializeComponent();
            init();

        }
        public TextEdi(displayItem file)
        {
            InitializeComponent();
            this.thisFile = file;

            init();

            stared = false;
            this.Text = file.filePath;
            saveFile1.FileName = file.filePath;
            this.textIn.LoadFile(file.filePath);
        }
        #endregion


        public void init()
        {
            font = new FontDialog();
            font.Font = new Font(font.Font.Name, 15, FontStyle.Regular);

            colorPicker = new ColorDialog();

            saveFile1 = new SaveFileDialog();
            saveFile1.DefaultExt = "*.rtf";
            saveFile1.Filter = "RTF Files|*.rtf";
            saveFile1.InitialDirectory = tempData.dataPath;
            textIn.SelectionFont = font.Font;
        }




        #region event handler
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void font_cBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Drawing.FontConverter buf = new FontConverter();
            //textIn.Font = (System.Drawing.Font)(buf.ConvertFromString(comboBox1.SelectedText));
        }

        private void fontButton_Click(object sender, EventArgs e)
        {
            

            try
            {
                if (font.ShowDialog() == DialogResult.OK)
                {
                    textIn.SelectionFont = font.Font;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("not supported font");
            }
            textIn.Focus();
        }
        private void underline_Click(object sender, EventArgs e)
        {
            if((font.Font.Style & FontStyle.Underline) != 0)
            {
                font.Font = new Font(font.Font.Name, font.Font.Size,font.Font.Style-4);
                textIn.SelectionFont = font.Font;
                //comboBox1.Text = ((int)font.Font.Style).ToString();

            }
            else
            {
                font.Font = new Font(font.Font.Name, font.Font.Size,  font.Font.Style+4);
                textIn.SelectionFont = font.Font;
                //comboBox1.Text = ((int)font.Font.Style).ToString();
            }
            textIn.Focus();
        }

        private void strikeout_click(object sender, EventArgs e)
        {
            //var pos = textIn.SelectionStart;
            //textIn.LoadFile()
            if ((font.Font.Style & FontStyle.Strikeout) != 0)
            {
                font.Font = new Font(font.Font.Name, font.Font.Size, font.Font.Style - 8);
                textIn.SelectionFont = font.Font;
                //comboBox1.Text = ((int)font.Font.Style).ToString();
                
            }
            else
            {
                font.Font = new Font(font.Font.Name, font.Font.Size, font.Font.Style + 8);
                textIn.SelectionFont = font.Font;
                //comboBox1.Text = ((int)font.Font.Style).ToString();
            }
            textIn.Focus();
        }
        private void bold_click(object sender, EventArgs e)
        {
            //var pos = textIn.SelectionStart;
            if ((font.Font.Style & FontStyle.Bold) != 0)
            {
                font.Font = new Font(font.Font.Name, font.Font.Size, font.Font.Style - 1);
                textIn.SelectionFont = font.Font;
                //comboBox1.Text = ((int)font.Font.Style).ToString();

            }
            else
            {
                font.Font = new Font(font.Font.Name, font.Font.Size, font.Font.Style + 1);
                textIn.SelectionFont = font.Font;
                //comboBox1.Text = ((int)font.Font.Style).ToString();
            }
            textIn.Focus();
        }


        private void saveButton_Click(object sender, EventArgs e)
        {

            // Initialize the SaveFileDialog to specify the RTF extention for the file.
            if (saveFile1.FileName.Length == 0||ModifierKeys==Keys.Shift)
            {
                
                // Determine whether the user selected a file name from the saveFileDialog. 
                if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                   saveFile1.FileName.Length > 0)
                {
                    // Save the contents of the RichTextBox into the file.
                    textIn.SaveFile(saveFile1.FileName);

                    string fileName = saveFile1.FileName.Substring(saveFile1.FileName.LastIndexOf('/') + 1);
                    thisFile = new displayItem(fileName, DateTime.Now, "text", saveFile1.FileName);
                    tempData.store.Add(thisFile);
                    // title manange
                    this.Text = saveFile1.FileName;
                    stared = false;
                }
            }
            else
            {
                textIn.SaveFile(saveFile1.FileName);
                this.Text = saveFile1.FileName;
                stared = false;

                thisFile.time = DateTime.Now; // update edit time
            }
            //if(ModifierKeys)
            textIn.Focus();
        }

        private void textIn_TextChanged(object sender, EventArgs e)
        {
            if (!stared)
            {
                this.Text = this.Text + "*";
                stared = true;
            }
            //comboBox1.Text = textIn.SelectionStart.ToString();
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            if(colorPicker.ShowDialog()== DialogResult.OK)
            {
                textIn.SelectionColor = colorPicker.Color;
                textIn.Focus();
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }




        public bool move { get; set; }
        public Point mousePos { get; set; }

        private void headerPanel_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mousePos = new Point(e.X, e.Y);
            Console.WriteLine(mousePos.X + "---" + mousePos.Y);
        }

        private void headerPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                var p = PointToScreen(e.Location);
                Console.WriteLine(p.X + "  " + p.Y);
                this.Location = new Point(p.X - mousePos.X, p.Y - mousePos.Y);
            }
        }

        private void headerPanel_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }
        #endregion

        public bool canClose { get; set; } = true;
        private bool closing = true;               // WHAT THE FUCK!!!!!
        private void TextEdi_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (canClose)
            {
                if (closing)
                {
                    closing = false;
                    ((startForm)this.Owner).updateObjList();
                    tempData.serialize();
                    this.Hide();
                    //MessageBox.Show(Application.OpenForms.Count.ToString());
                    this.Owner.BringToFront();
                    ((startForm)this.Owner).closeForm(this,"");
                }
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
