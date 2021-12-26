namespace ExampleApp
{
    partial class Form4p10
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemClose = new System.Windows.Forms.ToolStripMenuItem();
            this.颜色转换ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemOpenBGR2Gray = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemOpenBGR2YCrCb = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemOpenBGR2HSV = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemOpenBGR2Lab = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemOpenBGR2HLS = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuItemOpenBGR2LUV = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(19, 19);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.颜色转换ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemOpen,
            this.menuItemClose});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(56, 25);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // menuItemOpen
            // 
            this.menuItemOpen.Name = "menuItemOpen";
            this.menuItemOpen.Size = new System.Drawing.Size(217, 26);
            this.menuItemOpen.Text = "打开";
            this.menuItemOpen.Click += new System.EventHandler(this.menuItemOpen_Click);
            // 
            // menuItemClose
            // 
            this.menuItemClose.Name = "menuItemClose";
            this.menuItemClose.Size = new System.Drawing.Size(217, 26);
            this.menuItemClose.Text = "退出";
            this.menuItemClose.Click += new System.EventHandler(this.menuItemClose_Click);
            // 
            // 颜色转换ToolStripMenuItem
            // 
            this.颜色转换ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemOpenBGR2Gray,
            this.menuItemOpenBGR2YCrCb,
            this.menuItemOpenBGR2HSV,
            this.menuItemOpenBGR2LUV,
            this.menuItemOpenBGR2Lab,
            this.menuItemOpenBGR2HLS});
            this.颜色转换ToolStripMenuItem.Name = "颜色转换ToolStripMenuItem";
            this.颜色转换ToolStripMenuItem.Size = new System.Drawing.Size(88, 25);
            this.颜色转换ToolStripMenuItem.Text = "颜色转换";
            // 
            // menuItemOpenBGR2Gray
            // 
            this.menuItemOpenBGR2Gray.Name = "menuItemOpenBGR2Gray";
            this.menuItemOpenBGR2Gray.Size = new System.Drawing.Size(217, 26);
            this.menuItemOpenBGR2Gray.Text = "BGR - Gray";
            this.menuItemOpenBGR2Gray.Click += new System.EventHandler(this.menuItemOpenBGR2Gray_Click);
            // 
            // menuItemOpenBGR2YCrCb
            // 
            this.menuItemOpenBGR2YCrCb.Name = "menuItemOpenBGR2YCrCb";
            this.menuItemOpenBGR2YCrCb.Size = new System.Drawing.Size(217, 26);
            this.menuItemOpenBGR2YCrCb.Text = "BGR - YCrCb";
            this.menuItemOpenBGR2YCrCb.Click += new System.EventHandler(this.menuItemOpenBGR2YCrCb_Click);
            // 
            // menuItemOpenBGR2HSV
            // 
            this.menuItemOpenBGR2HSV.Name = "menuItemOpenBGR2HSV";
            this.menuItemOpenBGR2HSV.Size = new System.Drawing.Size(217, 26);
            this.menuItemOpenBGR2HSV.Text = "BGR - HSV";
            this.menuItemOpenBGR2HSV.Click += new System.EventHandler(this.menuItemOpenBGR2HSV_Click);
            // 
            // menuItemOpenBGR2Lab
            // 
            this.menuItemOpenBGR2Lab.Name = "menuItemOpenBGR2Lab";
            this.menuItemOpenBGR2Lab.Size = new System.Drawing.Size(217, 26);
            this.menuItemOpenBGR2Lab.Text = "BGR - Lab";
            this.menuItemOpenBGR2Lab.Click += new System.EventHandler(this.menuItemOpenBGR2Lab_Click);
            // 
            // menuItemOpenBGR2HLS
            // 
            this.menuItemOpenBGR2HLS.Name = "menuItemOpenBGR2HLS";
            this.menuItemOpenBGR2HLS.Size = new System.Drawing.Size(217, 26);
            this.menuItemOpenBGR2HLS.Text = "BGR - HLS";
            this.menuItemOpenBGR2HLS.Click += new System.EventHandler(this.menuItemOpenBGR2HLS_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(24, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(376, 376);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(408, 48);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(376, 376);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // menuItemOpenBGR2LUV
            // 
            this.menuItemOpenBGR2LUV.Name = "menuItemOpenBGR2LUV";
            this.menuItemOpenBGR2LUV.Size = new System.Drawing.Size(217, 26);
            this.menuItemOpenBGR2LUV.Text = "BGR - LUV";
            this.menuItemOpenBGR2LUV.Click += new System.EventHandler(this.menuItemOpenBGR2LUV_Click);
            // 
            // Form4p10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 442);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form4p10";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4p10";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem 文件ToolStripMenuItem;
        private ToolStripMenuItem menuItemOpen;
        private ToolStripMenuItem menuItemClose;
        private ToolStripMenuItem 颜色转换ToolStripMenuItem;
        private ToolStripMenuItem menuItemOpenBGR2Gray;
        private ToolStripMenuItem menuItemOpenBGR2YCrCb;
        private ToolStripMenuItem menuItemOpenBGR2HSV;
        private ToolStripMenuItem menuItemOpenBGR2Lab;
        private ToolStripMenuItem menuItemOpenBGR2HLS;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private ToolStripMenuItem menuItemOpenBGR2LUV;
    }
}