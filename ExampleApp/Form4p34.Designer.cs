namespace ExampleApp
{
    partial class Form4p34
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
            this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.处理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.处理ROIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSelectROI = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemGetRegionOfROI = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemGaussianBlurROI = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCannyEdgesROI = new System.Windows.Forms.ToolStripMenuItem();
            this.模板匹配ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemMatching = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemMultiScaleMatching = new System.Windows.Forms.ToolStripMenuItem();
            this.实用ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.变换ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemResize = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemRotaions = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuItemFeatureMatching = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(19, 19);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.处理ToolStripMenuItem,
            this.实用ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1182, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemOpen,
            this.menuItemExit});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(56, 25);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // menuItemOpen
            // 
            this.menuItemOpen.Name = "menuItemOpen";
            this.menuItemOpen.Size = new System.Drawing.Size(125, 26);
            this.menuItemOpen.Text = "打开";
            this.menuItemOpen.Click += new System.EventHandler(this.menuItemOpen_Click);
            // 
            // menuItemExit
            // 
            this.menuItemExit.Name = "menuItemExit";
            this.menuItemExit.Size = new System.Drawing.Size(125, 26);
            this.menuItemExit.Text = "退出";
            this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
            // 
            // 处理ToolStripMenuItem
            // 
            this.处理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.处理ROIToolStripMenuItem,
            this.模板匹配ToolStripMenuItem,
            this.menuItemFeatureMatching});
            this.处理ToolStripMenuItem.Name = "处理ToolStripMenuItem";
            this.处理ToolStripMenuItem.Size = new System.Drawing.Size(56, 25);
            this.处理ToolStripMenuItem.Text = "处理";
            // 
            // 处理ROIToolStripMenuItem
            // 
            this.处理ROIToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemSelectROI,
            this.menuItemGetRegionOfROI,
            this.menuItemGaussianBlurROI,
            this.menuItemCannyEdgesROI});
            this.处理ROIToolStripMenuItem.Name = "处理ROIToolStripMenuItem";
            this.处理ROIToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.处理ROIToolStripMenuItem.Text = "处理ROI";
            // 
            // menuItemSelectROI
            // 
            this.menuItemSelectROI.Name = "menuItemSelectROI";
            this.menuItemSelectROI.Size = new System.Drawing.Size(217, 26);
            this.menuItemSelectROI.Text = "选择ROI";
            this.menuItemSelectROI.Click += new System.EventHandler(this.menuItemSelectROI_Click);
            // 
            // menuItemGetRegionOfROI
            // 
            this.menuItemGetRegionOfROI.Name = "menuItemGetRegionOfROI";
            this.menuItemGetRegionOfROI.Size = new System.Drawing.Size(217, 26);
            this.menuItemGetRegionOfROI.Text = "获取ROI区域";
            this.menuItemGetRegionOfROI.Click += new System.EventHandler(this.menuItemGetRegionOfROI_Click);
            // 
            // menuItemGaussianBlurROI
            // 
            this.menuItemGaussianBlurROI.Name = "menuItemGaussianBlurROI";
            this.menuItemGaussianBlurROI.Size = new System.Drawing.Size(217, 26);
            this.menuItemGaussianBlurROI.Text = "高斯模糊ROI";
            this.menuItemGaussianBlurROI.Click += new System.EventHandler(this.menuItemGaussianBlurROI_Click);
            // 
            // menuItemCannyEdgesROI
            // 
            this.menuItemCannyEdgesROI.Name = "menuItemCannyEdgesROI";
            this.menuItemCannyEdgesROI.Size = new System.Drawing.Size(217, 26);
            this.menuItemCannyEdgesROI.Text = "Canny边缘ROI";
            this.menuItemCannyEdgesROI.Click += new System.EventHandler(this.menuItemCannyEdgesROI_Click);
            // 
            // 模板匹配ToolStripMenuItem
            // 
            this.模板匹配ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemMatching,
            this.menuItemMultiScaleMatching});
            this.模板匹配ToolStripMenuItem.Name = "模板匹配ToolStripMenuItem";
            this.模板匹配ToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.模板匹配ToolStripMenuItem.Text = "模板匹配";
            // 
            // menuItemMatching
            // 
            this.menuItemMatching.Name = "menuItemMatching";
            this.menuItemMatching.Size = new System.Drawing.Size(217, 26);
            this.menuItemMatching.Text = "匹配";
            this.menuItemMatching.Click += new System.EventHandler(this.menuItemMatching_Click);
            // 
            // menuItemMultiScaleMatching
            // 
            this.menuItemMultiScaleMatching.Name = "menuItemMultiScaleMatching";
            this.menuItemMultiScaleMatching.Size = new System.Drawing.Size(217, 26);
            this.menuItemMultiScaleMatching.Text = "多尺度匹配";
            this.menuItemMultiScaleMatching.Click += new System.EventHandler(this.menuItemMultiScaleMatching_Click);
            // 
            // 实用ToolStripMenuItem
            // 
            this.实用ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.变换ToolStripMenuItem});
            this.实用ToolStripMenuItem.Name = "实用ToolStripMenuItem";
            this.实用ToolStripMenuItem.Size = new System.Drawing.Size(56, 25);
            this.实用ToolStripMenuItem.Text = "实用";
            // 
            // 变换ToolStripMenuItem
            // 
            this.变换ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemResize,
            this.menuItemRotaions});
            this.变换ToolStripMenuItem.Name = "变换ToolStripMenuItem";
            this.变换ToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.变换ToolStripMenuItem.Text = "转换";
            // 
            // menuItemResize
            // 
            this.menuItemResize.Name = "menuItemResize";
            this.menuItemResize.Size = new System.Drawing.Size(159, 26);
            this.menuItemResize.Text = "Resize";
            this.menuItemResize.Click += new System.EventHandler(this.menuItemResize_Click);
            // 
            // menuItemRotaions
            // 
            this.menuItemRotaions.Name = "menuItemRotaions";
            this.menuItemRotaions.Size = new System.Drawing.Size(159, 26);
            this.menuItemRotaions.Text = "Rotaions";
            this.menuItemRotaions.Click += new System.EventHandler(this.menuItemRotaions_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 29);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1182, 726);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 720);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.treeView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 424);
            this.panel2.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(230, 424);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(239, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(940, 720);
            this.panel3.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(940, 720);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // menuItemFeatureMatching
            // 
            this.menuItemFeatureMatching.Name = "menuItemFeatureMatching";
            this.menuItemFeatureMatching.Size = new System.Drawing.Size(217, 26);
            this.menuItemFeatureMatching.Text = "特征匹配";
            this.menuItemFeatureMatching.Click += new System.EventHandler(this.menuItemFeatureMatching_Click);
            // 
            // Form4p34
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 755);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form4p34";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4p33";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form4p34_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private TreeView treeView1;
        private PictureBox pictureBox1;
        private Panel panel3;
        private ToolStripMenuItem 文件ToolStripMenuItem;
        private ToolStripMenuItem 处理ToolStripMenuItem;
        private ToolStripMenuItem menuItemExit;
        private ToolStripMenuItem 处理ROIToolStripMenuItem;
        private ToolStripMenuItem menuItemSelectROI;
        private ToolStripMenuItem menuItemOpen;
        private ToolStripMenuItem menuItemGetRegionOfROI;
        private ToolStripMenuItem menuItemGaussianBlurROI;
        private ToolStripMenuItem menuItemCannyEdgesROI;
        private ToolStripMenuItem 模板匹配ToolStripMenuItem;
        private ToolStripMenuItem menuItemMatching;
        private ToolStripMenuItem 实用ToolStripMenuItem;
        private ToolStripMenuItem 变换ToolStripMenuItem;
        private ToolStripMenuItem menuItemResize;
        private ToolStripMenuItem menuItemRotaions;
        private ToolStripMenuItem menuItemMultiScaleMatching;
        private ToolStripMenuItem menuItemFeatureMatching;
    }
}