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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(startForm));
            this.siderPanel = new System.Windows.Forms.Panel();
            this.newPanel = new System.Windows.Forms.Panel();
            this.newLabel = new System.Windows.Forms.Label();
            this.newPic = new System.Windows.Forms.PictureBox();
            this.siderHeadPanel = new System.Windows.Forms.Panel();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.siderPanel.SuspendLayout();
            this.newPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newPic)).BeginInit();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.SuspendLayout();
            // 
            // siderPanel
            // 
            this.siderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.siderPanel.Controls.Add(this.newPanel);
            this.siderPanel.Controls.Add(this.siderHeadPanel);
            this.siderPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.siderPanel.Location = new System.Drawing.Point(0, 0);
            this.siderPanel.Name = "siderPanel";
            this.siderPanel.Size = new System.Drawing.Size(255, 720);
            this.siderPanel.TabIndex = 0;
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
            this.siderHeadPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.siderHeadPanel_Paint);
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
            this.panel1.Location = new System.Drawing.Point(305, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(557, 460);
            this.panel1.TabIndex = 2;
            // 
            // startForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1084, 720);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.siderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "startForm";
            this.Text = "textForm";
            this.Load += new System.EventHandler(this.startForm_Load);
            this.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            this.siderPanel.ResumeLayout(false);
            this.newPanel.ResumeLayout(false);
            this.newPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newPic)).EndInit();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
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
    }
}