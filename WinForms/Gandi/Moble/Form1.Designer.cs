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
            timer1 = new System.Windows.Forms.Timer(components);
            lable2 = new System.Windows.Forms.Label();
            imageList1 = new System.Windows.Forms.ImageList(components);
            btnI1 = new System.Windows.Forms.Button();
            btnR = new System.Windows.Forms.Button();
            btnL = new System.Windows.Forms.Button();
            btnStart = new System.Windows.Forms.Button();
            textBox1 = new System.Windows.Forms.TextBox();
            btnI2 = new System.Windows.Forms.Button();
            btnI3 = new System.Windows.Forms.Button();
            btnI4 = new System.Windows.Forms.Button();
            labelProgressBar1 = new LabelProgressBar();
            timer2 = new System.Windows.Forms.Timer(components);
            lbStart = new System.Windows.Forms.Label();
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
            lable2.Location = new System.Drawing.Point(216, 100);
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
            // btnI1
            // 
            btnI1.ImageList = imageList1;
            btnI1.Location = new System.Drawing.Point(175, 495);
            btnI1.Name = "btnI1";
            btnI1.Size = new System.Drawing.Size(133, 97);
            btnI1.TabIndex = 3;
            btnI1.Text = "1";
            btnI1.UseVisualStyleBackColor = true;
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
            // btnI2
            // 
            btnI2.Location = new System.Drawing.Point(187, 413);
            btnI2.Name = "btnI2";
            btnI2.Size = new System.Drawing.Size(108, 76);
            btnI2.TabIndex = 6;
            btnI2.Text = "2";
            btnI2.UseVisualStyleBackColor = true;
            // 
            // btnI3
            // 
            btnI3.Location = new System.Drawing.Point(205, 348);
            btnI3.Name = "btnI3";
            btnI3.Size = new System.Drawing.Size(72, 59);
            btnI3.TabIndex = 6;
            btnI3.Text = "3";
            btnI3.UseVisualStyleBackColor = true;
            // 
            // btnI4
            // 
            btnI4.Location = new System.Drawing.Point(216, 297);
            btnI4.Name = "btnI4";
            btnI4.Size = new System.Drawing.Size(48, 45);
            btnI4.TabIndex = 6;
            btnI4.Text = "4";
            btnI4.UseVisualStyleBackColor = true;
            // 
            // labelProgressBar1
            // 
            labelProgressBar1.CustomText = "";
            labelProgressBar1.Location = new System.Drawing.Point(12, 9);
            labelProgressBar1.Maximum = 20;
            labelProgressBar1.Name = "labelProgressBar1";
            labelProgressBar1.ProgressColor = System.Drawing.Color.LightGreen;
            labelProgressBar1.Size = new System.Drawing.Size(460, 23);
            labelProgressBar1.TabIndex = 7;
            labelProgressBar1.TextColor = System.Drawing.Color.Black;
            labelProgressBar1.TextFont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelProgressBar1.VisualMode = ProgressBarDisplayMode.CurrProgress;
            // 
            // timer2
            // 
            
            // 
            // lbStart
            // 
            lbStart.AutoSize = true;
            lbStart.Font = new System.Drawing.Font("맑은 고딕", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbStart.Location = new System.Drawing.Point(185, 297);
            lbStart.Name = "lbStart";
            lbStart.Size = new System.Drawing.Size(110, 128);
            lbStart.TabIndex = 8;
            lbStart.Text = "3";
            lbStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.RoyalBlue;
            ClientSize = new System.Drawing.Size(484, 661);
            Controls.Add(lbStart);
            Controls.Add(labelProgressBar1);
            Controls.Add(btnI4);
            Controls.Add(btnI3);
            Controls.Add(btnI2);
            Controls.Add(textBox1);
            Controls.Add(btnStart);
            Controls.Add(btnR);
            Controls.Add(btnL);
            Controls.Add(btnI1);
            Controls.Add(lable2);
            Controls.Add(lbScore);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lable2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnI1;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button btnL;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnI2;
        private System.Windows.Forms.Button btnI3;
        private System.Windows.Forms.Button btnI4;
        private LabelProgressBar labelProgressBar1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lbStart;
    }
}
