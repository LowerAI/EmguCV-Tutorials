namespace ExampleApp
{
    partial class Form4p25
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
            this.menuItemLoadData = new System.Windows.Forms.ToolStripMenuItem();
            this.sVMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemTrainSVM = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemTestSVM = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbShowData = new System.Windows.Forms.CheckBox();
            this.lblTrain = new System.Windows.Forms.Label();
            this.lblTest = new System.Windows.Forms.Label();
            this.lblAccuracy = new System.Windows.Forms.Label();
            this.lblOutputLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(19, 19);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.sVMToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(599, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemLoadData});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(56, 25);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // menuItemLoadData
            // 
            this.menuItemLoadData.Name = "menuItemLoadData";
            this.menuItemLoadData.Size = new System.Drawing.Size(157, 26);
            this.menuItemLoadData.Text = "加载数据";
            this.menuItemLoadData.Click += new System.EventHandler(this.menuItemLoadData_Click);
            // 
            // sVMToolStripMenuItem
            // 
            this.sVMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemTrainSVM,
            this.menuItemTestSVM});
            this.sVMToolStripMenuItem.Name = "sVMToolStripMenuItem";
            this.sVMToolStripMenuItem.Size = new System.Drawing.Size(60, 25);
            this.sVMToolStripMenuItem.Text = "SVM";
            // 
            // menuItemTrainSVM
            // 
            this.menuItemTrainSVM.Name = "menuItemTrainSVM";
            this.menuItemTrainSVM.Size = new System.Drawing.Size(161, 26);
            this.menuItemTrainSVM.Text = "训练SVM";
            this.menuItemTrainSVM.Click += new System.EventHandler(this.menuItemTrainSVM_Click);
            // 
            // menuItemTestSVM
            // 
            this.menuItemTestSVM.Name = "menuItemTestSVM";
            this.menuItemTestSVM.Size = new System.Drawing.Size(161, 26);
            this.menuItemTestSVM.Text = "测试SVM";
            this.menuItemTestSVM.Click += new System.EventHandler(this.menuItemTestSVM_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(24, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // cbShowData
            // 
            this.cbShowData.AutoSize = true;
            this.cbShowData.Location = new System.Drawing.Point(24, 48);
            this.cbShowData.Name = "cbShowData";
            this.cbShowData.Size = new System.Drawing.Size(110, 25);
            this.cbShowData.TabIndex = 2;
            this.cbShowData.Text = "checkBox1";
            this.cbShowData.UseVisualStyleBackColor = true;
            this.cbShowData.CheckedChanged += new System.EventHandler(this.cbShowData_CheckedChanged);
            // 
            // lblTrain
            // 
            this.lblTrain.AutoSize = true;
            this.lblTrain.Location = new System.Drawing.Point(312, 88);
            this.lblTrain.Name = "lblTrain";
            this.lblTrain.Size = new System.Drawing.Size(0, 21);
            this.lblTrain.TabIndex = 3;
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(312, 165);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(0, 21);
            this.lblTest.TabIndex = 4;
            // 
            // lblAccuracy
            // 
            this.lblAccuracy.AutoSize = true;
            this.lblAccuracy.Location = new System.Drawing.Point(312, 242);
            this.lblAccuracy.Name = "lblAccuracy";
            this.lblAccuracy.Size = new System.Drawing.Size(0, 21);
            this.lblAccuracy.TabIndex = 5;
            // 
            // lblOutputLabel
            // 
            this.lblOutputLabel.AutoSize = true;
            this.lblOutputLabel.Location = new System.Drawing.Point(312, 319);
            this.lblOutputLabel.Name = "lblOutputLabel";
            this.lblOutputLabel.Size = new System.Drawing.Size(0, 21);
            this.lblOutputLabel.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::ExampleApp.Properties.Resources.sound_max;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(104, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 36);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::ExampleApp.Properties.Resources.sound_min;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(152, 360);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 36);
            this.button2.TabIndex = 8;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form4p25
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 421);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblOutputLabel);
            this.Controls.Add(this.lblAccuracy);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.lblTrain);
            this.Controls.Add(this.cbShowData);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form4p25";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4p25";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form4p25_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem 文件ToolStripMenuItem;
        private ToolStripMenuItem menuItemLoadData;
        private ToolStripMenuItem sVMToolStripMenuItem;
        private ToolStripMenuItem menuItemTrainSVM;
        private ToolStripMenuItem menuItemTestSVM;
        private PictureBox pictureBox1;
        private CheckBox cbShowData;
        private Label lblTrain;
        private Label lblTest;
        private Label lblAccuracy;
        private Label lblOutputLabel;
        private Button button1;
        private Button button2;
    }
}