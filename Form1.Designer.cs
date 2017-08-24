namespace getBiliBili {
    partial class Form1 {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.avcode = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.titleimg = new System.Windows.Forms.PictureBox();
            this.saveImages = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.mypress = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.titleimg)).BeginInit();
            this.SuspendLayout();
            // 
            // avcode
            // 
            this.avcode.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.avcode.Location = new System.Drawing.Point(49, 476);
            this.avcode.Margin = new System.Windows.Forms.Padding(3, 10, 3, 4);
            this.avcode.Multiline = true;
            this.avcode.Name = "avcode";
            this.avcode.Size = new System.Drawing.Size(580, 57);
            this.avcode.TabIndex = 0;
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.submit.ForeColor = System.Drawing.Color.OrangeRed;
            this.submit.Location = new System.Drawing.Point(635, 476);
            this.submit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(134, 59);
            this.submit.TabIndex = 1;
            this.submit.Text = "乾杯\t";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // titleimg
            // 
            this.titleimg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleimg.Location = new System.Drawing.Point(49, 13);
            this.titleimg.Name = "titleimg";
            this.titleimg.Size = new System.Drawing.Size(720, 450);
            this.titleimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.titleimg.TabIndex = 2;
            this.titleimg.TabStop = false;
            this.titleimg.Visible = false;
            this.titleimg.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // saveImages
            // 
            this.saveImages.ForeColor = System.Drawing.SystemColors.GrayText;
            this.saveImages.Location = new System.Drawing.Point(694, 440);
            this.saveImages.Name = "saveImages";
            this.saveImages.Size = new System.Drawing.Size(75, 23);
            this.saveImages.TabIndex = 3;
            this.saveImages.Text = "保存图片";
            this.saveImages.UseVisualStyleBackColor = true;
            this.saveImages.Visible = false;
            this.saveImages.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_Progress);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // mypress
            // 
            this.mypress.Location = new System.Drawing.Point(188, 233);
            this.mypress.Name = "mypress";
            this.mypress.Size = new System.Drawing.Size(441, 11);
            this.mypress.TabIndex = 4;
            this.mypress.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(817, 567);
            this.Controls.Add(this.mypress);
            this.Controls.Add(this.saveImages);
            this.Controls.Add(this.titleimg);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.avcode);
            this.Font = new System.Drawing.Font("微软雅黑", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(9, 11, 0, 0);
            this.Text = "获取B站封面图V1.0.0 - @叁闻君";
            ((System.ComponentModel.ISupportInitialize)(this.titleimg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox avcode;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.PictureBox titleimg;
        private System.Windows.Forms.Button saveImages;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar mypress;
    }
}

