namespace Moble
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lbScore = new System.Windows.Forms.Label();
            progressBar1 = new System.Windows.Forms.ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            lable2 = new System.Windows.Forms.Label();
            imageList1 = new System.Windows.Forms.ImageList(components);
            btnImage = new System.Windows.Forms.Button();
            btnR = new System.Windows.Forms.Button();
            btnL = new System.Windows.Forms.Button();
            btnStart = new System.Windows.Forms.Button();
            textBox1 = new System.Windows.Forms.TextBox();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lbScore
            // 
            lbScore.AutoSize = true;
            lbScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbScore.ForeColor = System.Drawing.Color.White;
            lbScore.Location = new System.Drawing.Point(175, 35);
            lbScore.Name = "lbScore";
            lbScore.Size = new System.Drawing.Size(140, 73);
            lbScore.TabIndex = 0;
            lbScore.Text = "200";
            lbScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            progressBar1.Location = new System.Drawing.Point(12, 12);
            progressBar1.Maximum = 20;
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new System.Drawing.Size(460, 30);
            progressBar1.TabIndex = 1;
            // 
            // timer1
            // 
            timer1.Interval = 2000;
            timer1.Tick += timer1_Tick;
            // 
            // lable2
            // 
            lable2.AutoSize = true;
            lable2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lable2.ForeColor = System.Drawing.Color.White;
            lable2.Location = new System.Drawing.Point(225, 100);
            lable2.Name = "lable2";
            lable2.Size = new System.Drawing.Size(52, 19);
            lable2.TabIndex = 2;
            lable2.Text = "score";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            imageList1.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = System.Drawing.Color.Transparent;
            imageList1.Images.SetKeyName(0, "cat.jpg");
            imageList1.Images.SetKeyName(1, "dog.jpg");
            // 
            // btnImage
            // 
            btnImage.ImageList = imageList1;
            btnImage.Location = new System.Drawing.Point(175, 495);
            btnImage.Name = "btnImage";
            btnImage.Size = new System.Drawing.Size(133, 97);
            btnImage.TabIndex = 3;
            btnImage.Text = "1";
            btnImage.UseVisualStyleBackColor = true;
            // 
            // btnR
            // 
            btnR.ImageIndex = 1;
            btnR.ImageList = imageList1;
            btnR.Location = new System.Drawing.Point(339, 552);
            btnR.Name = "btnR";
            btnR.Size = new System.Drawing.Size(133, 97);
            btnR.TabIndex = 3;
            btnR.Text = "Right";
            btnR.UseVisualStyleBackColor = true;
            btnR.Click += btnR_Click;
            // 
            // btnL
            // 
            btnL.ImageIndex = 0;
            btnL.ImageList = imageList1;
            btnL.Location = new System.Drawing.Point(12, 552);
            btnL.Name = "btnL";
            btnL.Size = new System.Drawing.Size(133, 97);
            btnL.TabIndex = 3;
            btnL.Text = "Left";
            btnL.UseVisualStyleBackColor = true;
            btnL.Click += btnL_Click;
            // 
            // btnStart
            // 
            btnStart.Location = new System.Drawing.Point(430, 48);
            btnStart.Name = "btnStart";
            btnStart.Size = new System.Drawing.Size(42, 23);
            btnStart.TabIndex = 4;
            btnStart.Text = "시작";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(387, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(37, 23);
            textBox1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(187, 413);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(108, 76);
            button1.TabIndex = 6;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(205, 348);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(72, 59);
            button2.TabIndex = 6;
            button2.Text = "button1";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(216, 297);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(48, 45);
            button3.TabIndex = 6;
            button3.Text = "button1";
            button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.RoyalBlue;
            ClientSize = new System.Drawing.Size(484, 661);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(btnStart);
            Controls.Add(btnR);
            Controls.Add(btnL);
            Controls.Add(btnImage);
            Controls.Add(lable2);
            Controls.Add(progressBar1);
            Controls.Add(lbScore);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lable2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button btnL;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
