namespace ExampleApp
{
    partial class Form4p13
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.形态学ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemErosion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDilation = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemOpening = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemClosing = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemGradient = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemTopHat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemBlackHat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemErosionOnBinary = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDilationOnBinary = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Location = new System.Drawing.Point(19, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(472, 632);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Location = new System.Drawing.Point(774, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(472, 632);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(19, 19);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.形态学ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1262, 29);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemOpen});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(56, 25);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // menuItemOpen
            // 
            this.menuItemOpen.Name = "menuItemOpen";
            this.menuItemOpen.Size = new System.Drawing.Size(135, 26);
            this.menuItemOpen.Text = "Open";
            this.menuItemOpen.Click += new System.EventHandler(this.menuItemOpen_Click);
            // 
            // 形态学ToolStripMenuItem
            // 
            this.形态学ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemErosion,
            this.menuItemDilation,
            this.menuItemOpening,
            this.menuItemClosing,
            this.menuItemGradient,
            this.menuItemTopHat,
            this.menuItemBlackHat,
            this.menuItemErosionOnBinary,
            this.menuItemDilationOnBinary});
            this.形态学ToolStripMenuItem.Name = "形态学ToolStripMenuItem";
            this.形态学ToolStripMenuItem.Size = new System.Drawing.Size(72, 25);
            this.形态学ToolStripMenuItem.Text = "形态学";
            // 
            // menuItemErosion
            // 
            this.menuItemErosion.Name = "menuItemErosion";
            this.menuItemErosion.Size = new System.Drawing.Size(319, 26);
            this.menuItemErosion.Text = "腐蚀/Erosion";
            this.menuItemErosion.Click += new System.EventHandler(this.menuItemErosion_Click);
            // 
            // menuItemDilation
            // 
            this.menuItemDilation.Name = "menuItemDilation";
            this.menuItemDilation.Size = new System.Drawing.Size(319, 26);
            this.menuItemDilation.Text = "膨胀/Dilation";
            this.menuItemDilation.Click += new System.EventHandler(this.menuItemDilation_Click);
            // 
            // menuItemOpening
            // 
            this.menuItemOpening.Name = "menuItemOpening";
            this.menuItemOpening.Size = new System.Drawing.Size(319, 26);
            this.menuItemOpening.Text = "开运算/Open";
            this.menuItemOpening.Click += new System.EventHandler(this.menuItemOpening_Click);
            // 
            // menuItemClosing
            // 
            this.menuItemClosing.Name = "menuItemClosing";
            this.menuItemClosing.Size = new System.Drawing.Size(319, 26);
            this.menuItemClosing.Text = "闭运算/Close";
            this.menuItemClosing.Click += new System.EventHandler(this.menuItemClosing_Click);
            // 
            // menuItemGradient
            // 
            this.menuItemGradient.Name = "menuItemGradient";
            this.menuItemGradient.Size = new System.Drawing.Size(319, 26);
            this.menuItemGradient.Text = "梯度/Gradient";
            this.menuItemGradient.Click += new System.EventHandler(this.menuItemGradient_Click);
            // 
            // menuItemTopHat
            // 
            this.menuItemTopHat.Name = "menuItemTopHat";
            this.menuItemTopHat.Size = new System.Drawing.Size(319, 26);
            this.menuItemTopHat.Text = "顶帽/Top Hat";
            this.menuItemTopHat.Click += new System.EventHandler(this.menuItemTopHat_Click);
            // 
            // menuItemBlackHat
            // 
            this.menuItemBlackHat.Name = "menuItemBlackHat";
            this.menuItemBlackHat.Size = new System.Drawing.Size(319, 26);
            this.menuItemBlackHat.Text = "黑帽/Black Hat";
            this.menuItemBlackHat.Click += new System.EventHandler(this.menuItemBlackHat_Click);
            // 
            // menuItemErosionOnBinary
            // 
            this.menuItemErosionOnBinary.Name = "menuItemErosionOnBinary";
            this.menuItemErosionOnBinary.Size = new System.Drawing.Size(319, 26);
            this.menuItemErosionOnBinary.Text = "二值化腐蚀/Erosion On Binary";
            this.menuItemErosionOnBinary.Click += new System.EventHandler(this.menuItemErosionOnBinary_Click);
            // 
            // menuItemDilationOnBinary
            // 
            this.menuItemDilationOnBinary.Name = "menuItemDilationOnBinary";
            this.menuItemDilationOnBinary.Size = new System.Drawing.Size(319, 26);
            this.menuItemDilationOnBinary.Text = "二值化膨胀/Dilation On Binary";
            this.menuItemDilationOnBinary.Click += new System.EventHandler(this.menuItemDilationOnBinary_Click);
            // 
            // Form4p13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 690);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form4p13";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4p13";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form4p13_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem 文件ToolStripMenuItem;
        private ToolStripMenuItem 形态学ToolStripMenuItem;
        private ToolStripMenuItem menuItemErosion;
        private ToolStripMenuItem menuItemDilation;
        private ToolStripMenuItem menuItemOpening;
        private ToolStripMenuItem menuItemClosing;
        private ToolStripMenuItem menuItemGradient;
        private ToolStripMenuItem menuItemTopHat;
        private ToolStripMenuItem menuItemBlackHat;
        private ToolStripMenuItem menuItemOpen;
        private ToolStripMenuItem menuItemErosionOnBinary;
        private ToolStripMenuItem menuItemDilationOnBinary;
    }
}