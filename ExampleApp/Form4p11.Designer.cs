namespace ExampleApp
{
    partial class Form4p11
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
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.相机ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemStartCamrea = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemPauseCamrea = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemStopCamrea = new System.Windows.Forms.ToolStripMenuItem();
            this.视频ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemStartVideo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemPauseVideo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemStopVideo = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(19, 19);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.相机ToolStripMenuItem,
            this.视频ToolStripMenuItem});
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(56, 25);
            this.打开ToolStripMenuItem.Text = "打开";
            // 
            // 相机ToolStripMenuItem
            // 
            this.相机ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemStartCamrea,
            this.menuItemPauseCamrea,
            this.menuItemStopCamrea});
            this.相机ToolStripMenuItem.Name = "相机ToolStripMenuItem";
            this.相机ToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.相机ToolStripMenuItem.Text = "相机";
            // 
            // menuItemStartCamrea
            // 
            this.menuItemStartCamrea.Name = "menuItemStartCamrea";
            this.menuItemStartCamrea.Size = new System.Drawing.Size(217, 26);
            this.menuItemStartCamrea.Text = "启动";
            this.menuItemStartCamrea.Click += new System.EventHandler(this.menuItemStartCamrea_Click);
            // 
            // menuItemPauseCamrea
            // 
            this.menuItemPauseCamrea.Name = "menuItemPauseCamrea";
            this.menuItemPauseCamrea.Size = new System.Drawing.Size(217, 26);
            this.menuItemPauseCamrea.Text = "暂停";
            this.menuItemPauseCamrea.Click += new System.EventHandler(this.menuItemPauseCamrea_Click);
            // 
            // menuItemStopCamrea
            // 
            this.menuItemStopCamrea.Name = "menuItemStopCamrea";
            this.menuItemStopCamrea.Size = new System.Drawing.Size(217, 26);
            this.menuItemStopCamrea.Text = "停止";
            this.menuItemStopCamrea.Click += new System.EventHandler(this.menuItemStopCamrea_Click);
            // 
            // 视频ToolStripMenuItem
            // 
            this.视频ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemStartVideo,
            this.menuItemPauseVideo,
            this.menuItemStopVideo});
            this.视频ToolStripMenuItem.Name = "视频ToolStripMenuItem";
            this.视频ToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.视频ToolStripMenuItem.Text = "视频";
            // 
            // menuItemStartVideo
            // 
            this.menuItemStartVideo.Name = "menuItemStartVideo";
            this.menuItemStartVideo.Size = new System.Drawing.Size(157, 26);
            this.menuItemStartVideo.Text = "开始播放";
            this.menuItemStartVideo.Click += new System.EventHandler(this.menuItemStartVideo_Click);
            // 
            // menuItemPauseVideo
            // 
            this.menuItemPauseVideo.Name = "menuItemPauseVideo";
            this.menuItemPauseVideo.Size = new System.Drawing.Size(157, 26);
            this.menuItemPauseVideo.Text = "暂停播放";
            this.menuItemPauseVideo.Click += new System.EventHandler(this.menuItemPauseVideo_Click);
            // 
            // menuItemStopVideo
            // 
            this.menuItemStopVideo.Name = "menuItemStopVideo";
            this.menuItemStopVideo.Size = new System.Drawing.Size(157, 26);
            this.menuItemStopVideo.Text = "停止播放";
            this.menuItemStopVideo.Click += new System.EventHandler(this.menuItemStopVideo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(16, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(768, 432);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form4p11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 481);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form4p11";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4p11";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem 打开ToolStripMenuItem;
        private ToolStripMenuItem 相机ToolStripMenuItem;
        private ToolStripMenuItem menuItemStartCamrea;
        private ToolStripMenuItem menuItemStopCamrea;
        private ToolStripMenuItem 视频ToolStripMenuItem;
        private ToolStripMenuItem menuItemStartVideo;
        private ToolStripMenuItem menuItemPauseVideo;
        private ToolStripMenuItem menuItemStopVideo;
        private PictureBox pictureBox1;
        private ToolStripMenuItem menuItemPauseCamrea;
    }
}