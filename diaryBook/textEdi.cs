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
    public partial class textEdi : Form
    {
        public SaveFileDialog saveFile1 { get; set; }
        public FontDialog font { get; set; }
        public ColorDialog colorPicker { get; set; }
        public bool stared { get; set; } = true;
        public textEdi()
        {
            InitializeComponent();
            // add font to fontCombox
            //List<string> fonts = new List<string>();
            var fonts = comboBox1.Items;
            font = new FontDialog();
            colorPicker = new ColorDialog();
            saveFile1 = new SaveFileDialog();
            foreach (FontFamily font in System.Drawing.FontFamily.Families)
            {
                fonts.Add(font.Name);
            }
            comboBox1.SelectedIndex = 0;
            //textIn.Font = new Font(textIn.Font.Name, 15, FontStyle.Regular);
            textIn.SelectionFont = font.Font;
            //FontDialog myFontDialog = new FontDialog();
            //if (myFontDialog.ShowDialog() == DialogResult.OK)
            //{
            //    // Set the control's font.
            //    //myDateTimePicker.Font = myFontDialog.Font;
            //}


        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void font_cBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Drawing.FontConverter buf = new FontConverter();
            textIn.Font = (System.Drawing.Font)(buf.ConvertFromString(comboBox1.SelectedText));
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //System.Drawing.FontConverter buf = new FontConverter();
            //textIn.Font = (System.Drawing.Font)(buf.ConvertFromString(comboBox1.SelectedText));
            //Console.WriteLine(comboBox1.SelectedItem.ToString());
            //try {
            //    var buf = new Font(comboBox1.SelectedItem.ToString(), textIn.Font.Size, textIn.Font.Style);

            //    textIn.SelectionFont = buf;

            //}
            //catch (Exception)
            //{

            //}
            //textIn.Refresh();
        }

        private void underlineButton_Click(object sender, EventArgs e)
        {
            if((font.Font.Style & FontStyle.Underline) != 0)
            {
                font.Font = new Font(font.Font.Name, font.Font.Size,font.Font.Style-4);
                textIn.SelectionFont = font.Font;
                comboBox1.Text = ((int)font.Font.Style).ToString();

            }
            else
            {
                font.Font = new Font(font.Font.Name, font.Font.Size,  font.Font.Style+4);
                textIn.SelectionFont = font.Font;
                comboBox1.Text = ((int)font.Font.Style).ToString();
            }
            textIn.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var pos = textIn.SelectionStart;
            if ((font.Font.Style & FontStyle.Strikeout) != 0)
            {
                font.Font = new Font(font.Font.Name, font.Font.Size, font.Font.Style - 8);
                textIn.SelectionFont = font.Font;
                comboBox1.Text = ((int)font.Font.Style).ToString();
                
            }
            else
            {
                font.Font = new Font(font.Font.Name, font.Font.Size, font.Font.Style + 8);
                textIn.SelectionFont = font.Font;
                comboBox1.Text = ((int)font.Font.Style).ToString();
            }
            textIn.Focus();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            // Initialize the SaveFileDialog to specify the RTF extention for the file.
            if (saveFile1.FileName.Length == 0||ModifierKeys==Keys.Shift)
            {
                saveFile1.DefaultExt = "*.rtf";
                saveFile1.Filter = "RTF Files|*.rtf";

                // Determine whether the user selected a file name from the saveFileDialog. 
                if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                   saveFile1.FileName.Length > 0)
                {
                    // Save the contents of the RichTextBox into the file.
                    textIn.SaveFile(saveFile1.FileName);
                    this.Text = saveFile1.FileName;
                    stared = false;
                }
            }
            else
            {
                textIn.SaveFile(saveFile1.FileName);
                this.Text = saveFile1.FileName;
                stared = false;

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
            comboBox1.Text = textIn.SelectionStart.ToString();
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            if(colorPicker.ShowDialog()== DialogResult.OK)
            {
                textIn.SelectionColor = colorPicker.Color;
                textIn.Focus();
            }
        }
    }
}
