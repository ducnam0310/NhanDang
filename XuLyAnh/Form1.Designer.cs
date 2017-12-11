namespace XuLyAnh
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnTaoAnhXam = new System.Windows.Forms.Button();
            this.btnTaoAnhDT = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button3 = new System.Windows.Forms.Button();
            this.btnTangTP = new System.Windows.Forms.Button();
            this.btnGiamTP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(409, 392);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(649, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(409, 392);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btnTaoAnhXam
            // 
            this.btnTaoAnhXam.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoAnhXam.Location = new System.Drawing.Point(440, 12);
            this.btnTaoAnhXam.Name = "btnTaoAnhXam";
            this.btnTaoAnhXam.Size = new System.Drawing.Size(191, 42);
            this.btnTaoAnhXam.TabIndex = 2;
            this.btnTaoAnhXam.Text = "Tạo Ảnh Xám";
            this.btnTaoAnhXam.UseVisualStyleBackColor = true;
            this.btnTaoAnhXam.Click += new System.EventHandler(this.btnTaoAnhXam_Click);
            // 
            // btnTaoAnhDT
            // 
            this.btnTaoAnhDT.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoAnhDT.Location = new System.Drawing.Point(440, 58);
            this.btnTaoAnhDT.Name = "btnTaoAnhDT";
            this.btnTaoAnhDT.Size = new System.Drawing.Size(191, 42);
            this.btnTaoAnhDT.TabIndex = 3;
            this.btnTaoAnhDT.Text = "Tạo Ảnh Đen Trắng";
            this.btnTaoAnhDT.UseVisualStyleBackColor = true;
            this.btnTaoAnhDT.Click += new System.EventHandler(this.btnTaoAnhDT_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(440, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 42);
            this.button1.TabIndex = 4;
            this.button1.Text = "Tăng Độ Sáng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(440, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 42);
            this.button2.TabIndex = 5;
            this.button2.Text = "Giảm Độ Sáng";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // chart1
            // 
            this.chart1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(266, 439);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.Name = "height";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(553, 259);
            this.chart1.TabIndex = 30;
            this.chart1.Text = "chart1";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(440, 194);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(191, 42);
            this.button3.TabIndex = 31;
            this.button3.Text = "Xử lí";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnTangTP
            // 
            this.btnTangTP.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTangTP.Location = new System.Drawing.Point(440, 242);
            this.btnTangTP.Name = "btnTangTP";
            this.btnTangTP.Size = new System.Drawing.Size(191, 42);
            this.btnTangTP.TabIndex = 32;
            this.btnTangTP.Text = "Tăng Độ Tương Phản";
            this.btnTangTP.UseVisualStyleBackColor = true;
            this.btnTangTP.Click += new System.EventHandler(this.btnTangTP_Click);
            // 
            // btnGiamTP
            // 
            this.btnGiamTP.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiamTP.Location = new System.Drawing.Point(440, 290);
            this.btnGiamTP.Name = "btnGiamTP";
            this.btnGiamTP.Size = new System.Drawing.Size(191, 42);
            this.btnGiamTP.TabIndex = 33;
            this.btnGiamTP.Text = "Giảm Độ Tương Phản";
            this.btnGiamTP.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 744);
            this.Controls.Add(this.btnGiamTP);
            this.Controls.Add(this.btnTangTP);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTaoAnhDT);
            this.Controls.Add(this.btnTaoAnhXam);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnTaoAnhXam;
        private System.Windows.Forms.Button btnTaoAnhDT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnTangTP;
        private System.Windows.Forms.Button btnGiamTP;
    }
}

