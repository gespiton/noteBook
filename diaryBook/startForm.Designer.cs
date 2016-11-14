namespace diaryBook
{
    partial class startForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(startForm));
            this.siderPanel = new System.Windows.Forms.Panel();
            this.drawPanel = new System.Windows.Forms.Panel();
            this.drawLabel = new System.Windows.Forms.Label();
            this.drawPic = new System.Windows.Forms.PictureBox();
            this.newPanel = new System.Windows.Forms.Panel();
            this.newLabel = new System.Windows.Forms.Label();
            this.newPic = new System.Windows.Forms.PictureBox();
            this.siderHeadPanel = new System.Windows.Forms.Panel();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.fileList = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.icons = new System.Windows.Forms.ImageList(this.components);
            this.siderPanel.SuspendLayout();
            this.drawPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drawPic)).BeginInit();
            this.newPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newPic)).BeginInit();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileList)).BeginInit();
            this.SuspendLayout();
            // 
            // siderPanel
            // 
            this.siderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.siderPanel.Controls.Add(this.drawPanel);
            this.siderPanel.Controls.Add(this.newPanel);
            this.siderPanel.Controls.Add(this.siderHeadPanel);
            this.siderPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.siderPanel.Location = new System.Drawing.Point(0, 0);
            this.siderPanel.Name = "siderPanel";
            this.siderPanel.Size = new System.Drawing.Size(255, 720);
            this.siderPanel.TabIndex = 0;
            // 
            // drawPanel
            // 
            this.drawPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(51)))), ((int)(((byte)(72)))));
            this.drawPanel.Controls.Add(this.drawLabel);
            this.drawPanel.Controls.Add(this.drawPic);
            this.drawPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.drawPanel.Location = new System.Drawing.Point(0, 144);
            this.drawPanel.Name = "drawPanel";
            this.drawPanel.Size = new System.Drawing.Size(255, 87);
            this.drawPanel.TabIndex = 2;
            this.drawPanel.Click += new System.EventHandler(this.newDrawing);
            this.drawPanel.MouseEnter += new System.EventHandler(this.drawPanel_MouseEnter);
            this.drawPanel.MouseLeave += new System.EventHandler(this.drawPanel_MouseLeave);
            // 
            // drawLabel
            // 
            this.drawLabel.AutoSize = true;
            this.drawLabel.BackColor = System.Drawing.Color.Transparent;
            this.drawLabel.CausesValidation = false;
            this.drawLabel.Font = new System.Drawing.Font("Ravie", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.drawLabel.Location = new System.Drawing.Point(72, 15);
            this.drawLabel.Name = "drawLabel";
            this.drawLabel.Size = new System.Drawing.Size(166, 54);
            this.drawLabel.TabIndex = 2;
            this.drawLabel.Text = "Draw";
            this.drawLabel.Click += new System.EventHandler(this.newDrawing);
            this.drawLabel.MouseEnter += new System.EventHandler(this.drawPanel_MouseEnter);
            // 
            // drawPic
            // 
            this.drawPic.BackColor = System.Drawing.Color.Transparent;
            this.drawPic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("drawPic.BackgroundImage")));
            this.drawPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.drawPic.Location = new System.Drawing.Point(12, 15);
            this.drawPic.Name = "drawPic";
            this.drawPic.Size = new System.Drawing.Size(54, 54);
            this.drawPic.TabIndex = 2;
            this.drawPic.TabStop = false;
            this.drawPic.Click += new System.EventHandler(this.newDrawing);
            this.drawPic.MouseEnter += new System.EventHandler(this.drawPanel_MouseEnter);
            // 
            // newPanel
            // 
            this.newPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(51)))), ((int)(((byte)(72)))));
            this.newPanel.Controls.Add(this.newLabel);
            this.newPanel.Controls.Add(this.newPic);
            this.newPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.newPanel.Location = new System.Drawing.Point(0, 57);
            this.newPanel.Name = "newPanel";
            this.newPanel.Size = new System.Drawing.Size(255, 87);
            this.newPanel.TabIndex = 1;
            this.newPanel.Click += new System.EventHandler(this.newFile);
            this.newPanel.MouseEnter += new System.EventHandler(this.newPanel_MouseEnter);
            this.newPanel.MouseLeave += new System.EventHandler(this.newPanel_MouseLeave);
            // 
            // newLabel
            // 
            this.newLabel.AutoSize = true;
            this.newLabel.BackColor = System.Drawing.Color.Transparent;
            this.newLabel.CausesValidation = false;
            this.newLabel.Font = new System.Drawing.Font("Ravie", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.newLabel.Location = new System.Drawing.Point(89, 17);
            this.newLabel.Name = "newLabel";
            this.newLabel.Size = new System.Drawing.Size(130, 54);
            this.newLabel.TabIndex = 1;
            this.newLabel.Text = "New";
            this.newLabel.Click += new System.EventHandler(this.newFile);
            this.newLabel.MouseEnter += new System.EventHandler(this.newPanel_MouseEnter);
            // 
            // newPic
            // 
            this.newPic.BackColor = System.Drawing.Color.Transparent;
            this.newPic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("newPic.BackgroundImage")));
            this.newPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.newPic.Location = new System.Drawing.Point(12, 20);
            this.newPic.Name = "newPic";
            this.newPic.Size = new System.Drawing.Size(54, 46);
            this.newPic.TabIndex = 0;
            this.newPic.TabStop = false;
            this.newPic.Click += new System.EventHandler(this.newFile);
            this.newPic.MouseEnter += new System.EventHandler(this.newPanel_MouseEnter);
            // 
            // siderHeadPanel
            // 
            this.siderHeadPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.siderHeadPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.siderHeadPanel.Location = new System.Drawing.Point(0, 0);
            this.siderHeadPanel.Name = "siderHeadPanel";
            this.siderHeadPanel.Size = new System.Drawing.Size(255, 57);
            this.siderHeadPanel.TabIndex = 0;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.headerPanel.Controls.Add(this.closeButton);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(255, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(829, 57);
            this.headerPanel.TabIndex = 1;
            this.headerPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseDown);
            this.headerPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseMove);
            this.headerPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseUp);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.closeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeButton.BackgroundImage")));
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closeButton.Location = new System.Drawing.Point(773, 1);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(55, 55);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.closeButton.TabIndex = 2;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.colse_button);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(255, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(829, 41);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.fileList);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(255, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(829, 622);
            this.panel2.TabIndex = 3;
            // 
            // fileList
            // 
            this.fileList.AllColumns.Add(this.olvColumn1);
            this.fileList.AllColumns.Add(this.olvColumn2);
            this.fileList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(250)))), ((int)(((byte)(244)))));
            this.fileList.CellEditUseWholeCell = false;
            this.fileList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn2});
            this.fileList.Cursor = System.Windows.Forms.Cursors.Default;
            this.fileList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileList.Font = new System.Drawing.Font("SimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.fileList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.fileList.FullRowSelect = true;
            this.fileList.Location = new System.Drawing.Point(0, 0);
            this.fileList.MultiSelect = false;
            this.fileList.Name = "fileList";
            this.fileList.Size = new System.Drawing.Size(829, 622);
            this.fileList.SmallImageList = this.icons;
            this.fileList.TabIndex = 0;
            this.fileList.UseCompatibleStateImageBehavior = false;
            this.fileList.View = System.Windows.Forms.View.Details;
            this.fileList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.fileList_MouseDoubleClick);
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "name";
            this.olvColumn1.Text = "Name";
            this.olvColumn1.Width = 523;
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "time";
            this.olvColumn2.AspectToStringFormat = "{0:t}";
            this.olvColumn2.Text = "date";
            this.olvColumn2.Width = 156;
            // 
            // icons
            // 
            this.icons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("icons.ImageStream")));
            this.icons.TransparentColor = System.Drawing.Color.Transparent;
            this.icons.Images.SetKeyName(0, "drawing");
            this.icons.Images.SetKeyName(1, "text");
            // 
            // startForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1084, 720);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.siderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "startForm";
            this.Text = "textForm";
            this.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            this.siderPanel.ResumeLayout(false);
            this.drawPanel.ResumeLayout(false);
            this.drawPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drawPic)).EndInit();
            this.newPanel.ResumeLayout(false);
            this.newPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newPic)).EndInit();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel siderPanel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel siderHeadPanel;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.Panel newPanel;
        private System.Windows.Forms.Label newLabel;
        private System.Windows.Forms.PictureBox newPic;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private BrightIdeasSoftware.ObjectListView fileList;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        public System.Windows.Forms.ImageList icons;
        private System.Windows.Forms.Panel drawPanel;
        private System.Windows.Forms.PictureBox drawPic;
        private System.Windows.Forms.Label drawLabel;
    }
}