namespace ExampleApp
{
    partial class Form4p03
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
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.panAndZoomPictureBox1 = new Emgu.CV.UI.PanAndZoomPictureBox();
            this.btnGetGrayIMage = new System.Windows.Forms.Button();
            this.histogramBox1 = new Emgu.CV.UI.HistogramBox();
            this.histogramBox2 = new Emgu.CV.UI.HistogramBox();
            this.btnGrayHist = new System.Windows.Forms.Button();
            this.btnColorHist = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panAndZoomPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.histogramBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.histogramBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Location = new System.Drawing.Point(12, 12);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(96, 28);
            this.btnLoadImage.TabIndex = 0;
            this.btnLoadImage.Text = "加载图像";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // imageBox1
            // 
            this.imageBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.imageBox1.Location = new System.Drawing.Point(13, 48);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(437, 296);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // panAndZoomPictureBox1
            // 
            this.panAndZoomPictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panAndZoomPictureBox1.Location = new System.Drawing.Point(456, 50);
            this.panAndZoomPictureBox1.Name = "panAndZoomPictureBox1";
            this.panAndZoomPictureBox1.Size = new System.Drawing.Size(402, 294);
            this.panAndZoomPictureBox1.TabIndex = 3;
            this.panAndZoomPictureBox1.TabStop = false;
            // 
            // btnGetGrayIMage
            // 
            this.btnGetGrayIMage.Location = new System.Drawing.Point(114, 14);
            this.btnGetGrayIMage.Name = "btnGetGrayIMage";
            this.btnGetGrayIMage.Size = new System.Drawing.Size(96, 28);
            this.btnGetGrayIMage.TabIndex = 4;
            this.btnGetGrayIMage.Text = "获取灰度图";
            this.btnGetGrayIMage.UseVisualStyleBackColor = true;
            this.btnGetGrayIMage.Click += new System.EventHandler(this.btnGetGrayIMage_Click);
            // 
            // histogramBox1
            // 
            this.histogramBox1.Location = new System.Drawing.Point(12, 350);
            this.histogramBox1.Name = "histogramBox1";
            this.histogramBox1.Size = new System.Drawing.Size(438, 275);
            this.histogramBox1.TabIndex = 2;
            this.histogramBox1.TabStop = false;
            // 
            // histogramBox2
            // 
            this.histogramBox2.Location = new System.Drawing.Point(456, 350);
            this.histogramBox2.Name = "histogramBox2";
            this.histogramBox2.Size = new System.Drawing.Size(402, 275);
            this.histogramBox2.TabIndex = 5;
            this.histogramBox2.TabStop = false;
            // 
            // btnGrayHist
            // 
            this.btnGrayHist.Location = new System.Drawing.Point(318, 14);
            this.btnGrayHist.Name = "btnGrayHist";
            this.btnGrayHist.Size = new System.Drawing.Size(96, 28);
            this.btnGrayHist.TabIndex = 7;
            this.btnGrayHist.Text = "灰度直方图";
            this.btnGrayHist.UseVisualStyleBackColor = true;
            this.btnGrayHist.Click += new System.EventHandler(this.btnGrayHist_Click);
            // 
            // btnColorHist
            // 
            this.btnColorHist.Location = new System.Drawing.Point(216, 12);
            this.btnColorHist.Name = "btnColorHist";
            this.btnColorHist.Size = new System.Drawing.Size(96, 28);
            this.btnColorHist.TabIndex = 6;
            this.btnColorHist.Text = "彩色直方图";
            this.btnColorHist.UseVisualStyleBackColor = true;
            this.btnColorHist.Click += new System.EventHandler(this.btnColorHist_Click);
            // 
            // Form4p3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 637);
            this.Controls.Add(this.btnGrayHist);
            this.Controls.Add(this.btnColorHist);
            this.Controls.Add(this.histogramBox2);
            this.Controls.Add(this.histogramBox1);
            this.Controls.Add(this.btnGetGrayIMage);
            this.Controls.Add(this.panAndZoomPictureBox1);
            this.Controls.Add(this.imageBox1);
            this.Controls.Add(this.btnLoadImage);
            this.Name = "Form4p3";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panAndZoomPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.histogramBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.histogramBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnLoadImage;
        private Emgu.CV.UI.ImageBox imageBox1;
        private Emgu.CV.UI.PanAndZoomPictureBox panAndZoomPictureBox1;
        private Button btnGetGrayIMage;
        private Emgu.CV.UI.HistogramBox histogramBox1;
        private Emgu.CV.UI.HistogramBox histogramBox2;
        private Button btnGrayHist;
        private Button btnColorHist;
    }
}