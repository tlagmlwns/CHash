namespace Moble
{
    partial class Bubibubi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bubibubi));
            lbScore = new System.Windows.Forms.Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label2 = new System.Windows.Forms.Label();
            labelProgressBar1 = new LabelProgressBar();
            trackBar1 = new System.Windows.Forms.TrackBar();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            imageList1 = new System.Windows.Forms.ImageList(components);
            button1 = new System.Windows.Forms.Button();
            btnStart = new System.Windows.Forms.Button();
            lb_Sec = new System.Windows.Forms.Label();
            timer2 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
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
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(216, 100);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(52, 19);
            label2.TabIndex = 2;
            label2.Text = "score";
            // 
            // labelProgressBar1
            // 
            labelProgressBar1.CustomText = "";
            labelProgressBar1.Location = new System.Drawing.Point(12, 9);
            labelProgressBar1.Maximum = 200;
            labelProgressBar1.Name = "labelProgressBar1";
            labelProgressBar1.ProgressColor = System.Drawing.Color.LightGreen;
            labelProgressBar1.Size = new System.Drawing.Size(460, 23);
            labelProgressBar1.TabIndex = 3;
            labelProgressBar1.TextColor = System.Drawing.Color.Black;
            labelProgressBar1.TextFont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelProgressBar1.Value = 200;
            labelProgressBar1.VisualMode = ProgressBarDisplayMode.CustomText;
            // 
            // trackBar1
            // 
            trackBar1.BackColor = System.Drawing.Color.RoyalBlue;
            trackBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            trackBar1.Location = new System.Drawing.Point(12, 435);
            trackBar1.Maximum = 50;
            trackBar1.Name = "trackBar1";
            trackBar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            trackBar1.Size = new System.Drawing.Size(460, 45);
            trackBar1.TabIndex = 4;
            trackBar1.TickStyle = System.Windows.Forms.TickStyle.Both;
            trackBar1.Value = 25;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.Yellow;
            label3.Location = new System.Drawing.Point(41, 314);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(411, 32);
            label3.TabIndex = 5;
            label3.Text = "아래 버튼을 잡고 좌우로 문지르세요.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = System.Drawing.Color.Yellow;
            label4.Location = new System.Drawing.Point(125, 354);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(234, 15);
            label4.TabIndex = 6;
            label4.Text = "너무 작게 문지르면 점수가 오르지 않아요.";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            imageList1.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = System.Drawing.Color.Transparent;
            imageList1.Images.SetKeyName(0, "dd.png");
            // 
            // button1
            // 
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.ForeColor = System.Drawing.Color.RoyalBlue;
            button1.ImageIndex = 0;
            button1.ImageList = imageList1;
            button1.Location = new System.Drawing.Point(202, 309);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(89, 120);
            button1.TabIndex = 7;
            button1.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            btnStart.Location = new System.Drawing.Point(222, 122);
            btnStart.Name = "btnStart";
            btnStart.Size = new System.Drawing.Size(41, 23);
            btnStart.TabIndex = 8;
            btnStart.Text = "시작";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // lb_Sec
            // 
            lb_Sec.AutoSize = true;
            lb_Sec.Font = new System.Drawing.Font("맑은 고딕", 63F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lb_Sec.Location = new System.Drawing.Point(195, 197);
            lb_Sec.Name = "lb_Sec";
            lb_Sec.Size = new System.Drawing.Size(96, 112);
            lb_Sec.TabIndex = 13;
            lb_Sec.Text = "3";
            // 
            // timer2
            // 
            timer2.Interval = 1000;
            timer2.Tick += timer2_Tick;
            // 
            // Bubibubi
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.RoyalBlue;
            ClientSize = new System.Drawing.Size(484, 661);
            Controls.Add(lb_Sec);
            Controls.Add(btnStart);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(trackBar1);
            Controls.Add(labelProgressBar1);
            Controls.Add(label2);
            Controls.Add(lbScore);
            Controls.Add(button1);
            Name = "Bubibubi";
            Text = "Bubibubi";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private LabelProgressBar labelProgressBar1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lb_Sec;
        private System.Windows.Forms.Timer timer2;
    }
}