namespace ExampleApp
{
    partial class Form4p04
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemClose = new System.Windows.Forms.ToolStripMenuItem();
            this.边缘ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCanny = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSobel = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemLaplacian = new System.Windows.Forms.ToolStripMenuItem();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.menuItemCannyParameters = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(19, 19);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.边缘ToolStripMenuItem});
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
            this.menuItemOpen.Size = new System.Drawing.Size(125, 26);
            this.menuItemOpen.Text = "打开";
            this.menuItemOpen.Click += new System.EventHandler(this.menuItemOpen_Click);
            // 
            // menuItemClose
            // 
            this.menuItemClose.Name = "menuItemClose";
            this.menuItemClose.Size = new System.Drawing.Size(125, 26);
            this.menuItemClose.Text = "退出";
            this.menuItemClose.Click += new System.EventHandler(this.menuItemClose_Click);
            // 
            // 边缘ToolStripMenuItem
            // 
            this.边缘ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemCanny,
            this.menuItemSobel,
            this.menuItemLaplacian,
            this.menuItemCannyParameters});
            this.边缘ToolStripMenuItem.Name = "边缘ToolStripMenuItem";
            this.边缘ToolStripMenuItem.Size = new System.Drawing.Size(56, 25);
            this.边缘ToolStripMenuItem.Text = "边缘";
            // 
            // menuItemCanny
            // 
            this.menuItemCanny.Name = "menuItemCanny";
            this.menuItemCanny.Size = new System.Drawing.Size(217, 26);
            this.menuItemCanny.Text = "Canny";
            this.menuItemCanny.Click += new System.EventHandler(this.menuItemCanny_Click);
            // 
            // menuItemSobel
            // 
            this.menuItemSobel.Name = "menuItemSobel";
            this.menuItemSobel.Size = new System.Drawing.Size(217, 26);
            this.menuItemSobel.Text = "Sobel";
            this.menuItemSobel.Click += new System.EventHandler(this.menuItemSobel_Click);
            // 
            // menuItemLaplacian
            // 
            this.menuItemLaplacian.Name = "menuItemLaplacian";
            this.menuItemLaplacian.Size = new System.Drawing.Size(217, 26);
            this.menuItemLaplacian.Text = "Laplacian";
            this.menuItemLaplacian.Click += new System.EventHandler(this.menuItemLaplacian_Click);
            // 
            // imageBox1
            // 
            this.imageBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageBox1.Location = new System.Drawing.Point(12, 32);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(776, 461);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // menuItemCannyParameters
            // 
            this.menuItemCannyParameters.Name = "menuItemCannyParameters";
            this.menuItemCannyParameters.Size = new System.Drawing.Size(217, 26);
            this.menuItemCannyParameters.Text = "Canny参数设定";
            this.menuItemCannyParameters.Click += new System.EventHandler(this.menuItemCannyParameters_Click);
            // 
            // Form4p4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 505);
            this.Controls.Add(this.imageBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form4p4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4p4";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem 文件ToolStripMenuItem;
        private ToolStripMenuItem 边缘ToolStripMenuItem;
        private ToolStripMenuItem menuItemOpen;
        private ToolStripMenuItem menuItemClose;
        private ToolStripMenuItem menuItemCanny;
        private ToolStripMenuItem menuItemSobel;
        private ToolStripMenuItem menuItemLaplacian;
        private Emgu.CV.UI.ImageBox imageBox1;
        private ToolStripMenuItem menuItemCannyParameters;
    }
}