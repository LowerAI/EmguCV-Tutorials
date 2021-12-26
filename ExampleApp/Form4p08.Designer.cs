namespace ExampleApp
{
    partial class Form4p08
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
            this.btnMeanShiftSegmentation = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.numericSpatialWindowRadius = new System.Windows.Forms.NumericUpDown();
            this.lblSpatialWindowRadius = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericColorWindowRadius = new System.Windows.Forms.NumericUpDown();
            this.lblMax = new System.Windows.Forms.Label();
            this.numericMaxIteration = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericMinimumSegmentSize = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSpatialWindowRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericColorWindowRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMaxIteration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMinimumSegmentSize)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMeanShiftSegmentation
            // 
            this.btnMeanShiftSegmentation.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnMeanShiftSegmentation.Location = new System.Drawing.Point(344, 78);
            this.btnMeanShiftSegmentation.Name = "btnMeanShiftSegmentation";
            this.btnMeanShiftSegmentation.Size = new System.Drawing.Size(128, 40);
            this.btnMeanShiftSegmentation.TabIndex = 0;
            this.btnMeanShiftSegmentation.Text = "均值平移切割";
            this.btnMeanShiftSegmentation.UseVisualStyleBackColor = true;
            this.btnMeanShiftSegmentation.Click += new System.EventHandler(this.btnMeanShiftSegmentation_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Location = new System.Drawing.Point(16, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(384, 376);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Location = new System.Drawing.Point(408, 126);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(384, 376);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // numericSpatialWindowRadius
            // 
            this.numericSpatialWindowRadius.Location = new System.Drawing.Point(248, 12);
            this.numericSpatialWindowRadius.Name = "numericSpatialWindowRadius";
            this.numericSpatialWindowRadius.Size = new System.Drawing.Size(144, 28);
            this.numericSpatialWindowRadius.TabIndex = 3;
            // 
            // lblSpatialWindowRadius
            // 
            this.lblSpatialWindowRadius.AutoSize = true;
            this.lblSpatialWindowRadius.Location = new System.Drawing.Point(120, 16);
            this.lblSpatialWindowRadius.Name = "lblSpatialWindowRadius";
            this.lblSpatialWindowRadius.Size = new System.Drawing.Size(122, 21);
            this.lblSpatialWindowRadius.TabIndex = 4;
            this.lblSpatialWindowRadius.Text = "空间窗口半径：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "彩色窗口半径：";
            // 
            // numericColorWindowRadius
            // 
            this.numericColorWindowRadius.Location = new System.Drawing.Point(527, 12);
            this.numericColorWindowRadius.Name = "numericColorWindowRadius";
            this.numericColorWindowRadius.Size = new System.Drawing.Size(144, 28);
            this.numericColorWindowRadius.TabIndex = 5;
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(400, 48);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(122, 21);
            this.lblMax.TabIndex = 10;
            this.lblMax.Text = "最大迭代数量：";
            // 
            // numericMaxIteration
            // 
            this.numericMaxIteration.Location = new System.Drawing.Point(527, 44);
            this.numericMaxIteration.Name = "numericMaxIteration";
            this.numericMaxIteration.Size = new System.Drawing.Size(144, 28);
            this.numericMaxIteration.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "最小片段大小：";
            // 
            // numericMinimumSegmentSize
            // 
            this.numericMinimumSegmentSize.Location = new System.Drawing.Point(248, 44);
            this.numericMinimumSegmentSize.Name = "numericMinimumSegmentSize";
            this.numericMinimumSegmentSize.Size = new System.Drawing.Size(144, 28);
            this.numericMinimumSegmentSize.TabIndex = 7;
            // 
            // Form4p8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 520);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.numericMaxIteration);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericMinimumSegmentSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericColorWindowRadius);
            this.Controls.Add(this.lblSpatialWindowRadius);
            this.Controls.Add(this.numericSpatialWindowRadius);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnMeanShiftSegmentation);
            this.Name = "Form4p8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4p8";
            this.Load += new System.EventHandler(this.Form4p8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSpatialWindowRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericColorWindowRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMaxIteration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMinimumSegmentSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnMeanShiftSegmentation;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private NumericUpDown numericSpatialWindowRadius;
        private Label lblSpatialWindowRadius;
        private Label label2;
        private NumericUpDown numericColorWindowRadius;
        private Label lblMax;
        private NumericUpDown numericMaxIteration;
        private Label label4;
        private NumericUpDown numericMinimumSegmentSize;
    }
}