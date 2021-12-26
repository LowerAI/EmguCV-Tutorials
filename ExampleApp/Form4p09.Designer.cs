namespace ExampleApp
{
    partial class Form4p09
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
            this.btnReadImage = new System.Windows.Forms.Button();
            this.btnHistogram = new System.Windows.Forms.Button();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
            this.imageBox3 = new Emgu.CV.UI.ImageBox();
            this.histogramBox1 = new Emgu.CV.UI.HistogramBox();
            this.histogramBox2 = new Emgu.CV.UI.HistogramBox();
            this.histogramBox3 = new Emgu.CV.UI.HistogramBox();
            this.btnDenseHistogram = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.histogramBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.histogramBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.histogramBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReadImage
            // 
            this.btnReadImage.Location = new System.Drawing.Point(8, 8);
            this.btnReadImage.Name = "btnReadImage";
            this.btnReadImage.Size = new System.Drawing.Size(90, 28);
            this.btnReadImage.TabIndex = 0;
            this.btnReadImage.Text = "读取图像";
            this.btnReadImage.UseVisualStyleBackColor = true;
            this.btnReadImage.Click += new System.EventHandler(this.btnReadImage_Click);
            // 
            // btnHistogram
            // 
            this.btnHistogram.Location = new System.Drawing.Point(120, 8);
            this.btnHistogram.Name = "btnHistogram";
            this.btnHistogram.Size = new System.Drawing.Size(90, 28);
            this.btnHistogram.TabIndex = 1;
            this.btnHistogram.Text = "直方图";
            this.btnHistogram.UseVisualStyleBackColor = true;
            this.btnHistogram.Click += new System.EventHandler(this.btnHistogram_Click);
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(8, 48);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(288, 256);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // imageBox2
            // 
            this.imageBox2.Location = new System.Drawing.Point(304, 48);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(288, 256);
            this.imageBox2.TabIndex = 3;
            this.imageBox2.TabStop = false;
            // 
            // imageBox3
            // 
            this.imageBox3.Location = new System.Drawing.Point(600, 48);
            this.imageBox3.Name = "imageBox3";
            this.imageBox3.Size = new System.Drawing.Size(288, 256);
            this.imageBox3.TabIndex = 4;
            this.imageBox3.TabStop = false;
            // 
            // histogramBox1
            // 
            this.histogramBox1.Location = new System.Drawing.Point(8, 312);
            this.histogramBox1.Name = "histogramBox1";
            this.histogramBox1.Size = new System.Drawing.Size(288, 264);
            this.histogramBox1.TabIndex = 2;
            this.histogramBox1.TabStop = false;
            // 
            // histogramBox2
            // 
            this.histogramBox2.Location = new System.Drawing.Point(304, 312);
            this.histogramBox2.Name = "histogramBox2";
            this.histogramBox2.Size = new System.Drawing.Size(288, 264);
            this.histogramBox2.TabIndex = 5;
            this.histogramBox2.TabStop = false;
            // 
            // histogramBox3
            // 
            this.histogramBox3.Location = new System.Drawing.Point(600, 312);
            this.histogramBox3.Name = "histogramBox3";
            this.histogramBox3.Size = new System.Drawing.Size(288, 264);
            this.histogramBox3.TabIndex = 6;
            this.histogramBox3.TabStop = false;
            // 
            // btnDenseHistogram
            // 
            this.btnDenseHistogram.Location = new System.Drawing.Point(232, 8);
            this.btnDenseHistogram.Name = "btnDenseHistogram";
            this.btnDenseHistogram.Size = new System.Drawing.Size(90, 28);
            this.btnDenseHistogram.TabIndex = 7;
            this.btnDenseHistogram.Text = "密集直方图";
            this.btnDenseHistogram.UseVisualStyleBackColor = true;
            this.btnDenseHistogram.Click += new System.EventHandler(this.btnDenseHistogram_Click);
            // 
            // Form4p9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 587);
            this.Controls.Add(this.btnDenseHistogram);
            this.Controls.Add(this.histogramBox3);
            this.Controls.Add(this.histogramBox2);
            this.Controls.Add(this.histogramBox1);
            this.Controls.Add(this.imageBox3);
            this.Controls.Add(this.imageBox2);
            this.Controls.Add(this.imageBox1);
            this.Controls.Add(this.btnHistogram);
            this.Controls.Add(this.btnReadImage);
            this.Name = "Form4p9";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4p9";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.histogramBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.histogramBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.histogramBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnReadImage;
        private Button btnHistogram;
        private ImageBox imageBox1;
        private ImageBox imageBox2;
        private ImageBox imageBox3;
        private HistogramBox histogramBox1;
        private HistogramBox histogramBox2;
        private HistogramBox histogramBox3;
        private Button btnDenseHistogram;
    }
}