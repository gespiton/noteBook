namespace diaryBook
{
    partial class DrawForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrawForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.penB = new System.Windows.Forms.ToolStripButton();
            this.sizeB = new System.Windows.Forms.ToolStripButton();
            this.brushB = new System.Windows.Forms.ToolStripButton();
            this.colorPB = new System.Windows.Forms.ToolStripButton();
            this.saveB = new System.Windows.Forms.ToolStripButton();
            this.board = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.penB,
            this.sizeB,
            this.brushB,
            this.colorPB,
            this.saveB});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(45, 654);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // penB
            // 
            this.penB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.penB.Image = ((System.Drawing.Image)(resources.GetObject("penB.Image")));
            this.penB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.penB.Name = "penB";
            this.penB.Size = new System.Drawing.Size(42, 44);
            this.penB.Text = "toolStripButton1";
            this.penB.Click += new System.EventHandler(this.penButton);
            // 
            // sizeB
            // 
            this.sizeB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sizeB.Image = ((System.Drawing.Image)(resources.GetObject("sizeB.Image")));
            this.sizeB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sizeB.Name = "sizeB";
            this.sizeB.Size = new System.Drawing.Size(42, 44);
            this.sizeB.Text = "toolStripButton5";
            this.sizeB.Click += new System.EventHandler(this.sizeB_Click);
            // 
            // brushB
            // 
            this.brushB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.brushB.Image = ((System.Drawing.Image)(resources.GetObject("brushB.Image")));
            this.brushB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.brushB.Name = "brushB";
            this.brushB.Size = new System.Drawing.Size(42, 44);
            this.brushB.Text = "toolStripButton4";
            this.brushB.Click += new System.EventHandler(this.brushButton);
            // 
            // colorPB
            // 
            this.colorPB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.colorPB.Image = ((System.Drawing.Image)(resources.GetObject("colorPB.Image")));
            this.colorPB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.colorPB.Name = "colorPB";
            this.colorPB.Size = new System.Drawing.Size(42, 44);
            this.colorPB.Text = "toolStripButton2";
            this.colorPB.Click += new System.EventHandler(this.colorPicButton);
            // 
            // saveB
            // 
            this.saveB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveB.Image = ((System.Drawing.Image)(resources.GetObject("saveB.Image")));
            this.saveB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveB.Name = "saveB";
            this.saveB.Size = new System.Drawing.Size(42, 44);
            this.saveB.Text = "toolStripButton3";
            this.saveB.Click += new System.EventHandler(this.saveButton);
            // 
            // board
            // 
            this.board.BackColor = System.Drawing.Color.White;
            this.board.Dock = System.Windows.Forms.DockStyle.Fill;
            this.board.Location = new System.Drawing.Point(45, 0);
            this.board.Name = "board";
            this.board.Size = new System.Drawing.Size(787, 654);
            this.board.TabIndex = 1;
            this.board.Paint += new System.Windows.Forms.PaintEventHandler(this.board_Paint);
            this.board.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.board.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.board.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // DrawForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 654);
            this.Controls.Add(this.board);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DrawForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "rawForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DrawForm_FormClosing);
            this.SizeChanged += new System.EventHandler(this.DrawForm_SizeChanged);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton penB;
        private System.Windows.Forms.ToolStripButton colorPB;
        private System.Windows.Forms.Panel board;
        private System.Windows.Forms.ToolStripButton saveB;
        private System.Windows.Forms.ToolStripButton brushB;
        private System.Windows.Forms.ToolStripButton sizeB;
    }
}