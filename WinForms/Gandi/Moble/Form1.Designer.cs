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
            labelProgressBar1 = new LabelProgressBar();
            rbEasy = new System.Windows.Forms.RadioButton();
            rbHard = new System.Windows.Forms.RadioButton();
            btnUL = new System.Windows.Forms.Button();
            btnUR = new System.Windows.Forms.Button();
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
            timer1.Interval = 1000;
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
            imageList1.Images.SetKeyName(0, "Ge.png");
            imageList1.Images.SetKeyName(1, "Re.png");
            imageList1.Images.SetKeyName(2, "Ye.png");
            imageList1.Images.SetKeyName(3, "Or.png");
            // 
            // btnI1
            // 
            btnI1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnI1.ForeColor = System.Drawing.Color.RoyalBlue;
            btnI1.ImageList = imageList1;
            btnI1.Location = new System.Drawing.Point(175, 389);
            btnI1.Name = "btnI1";
            btnI1.Size = new System.Drawing.Size(133, 124);
            btnI1.TabIndex = 3;
            btnI1.UseVisualStyleBackColor = true;
            // 
            // btnR
            // 
            btnR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnR.ForeColor = System.Drawing.Color.RoyalBlue;
            btnR.ImageIndex = 1;
            btnR.ImageList = imageList1;
            btnR.Location = new System.Drawing.Point(339, 521);
            btnR.Name = "btnR";
            btnR.Size = new System.Drawing.Size(133, 128);
            btnR.TabIndex = 3;
            btnR.UseVisualStyleBackColor = true;
            btnR.Click += btnR_Click;
            // 
            // btnL
            // 
            btnL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnL.ForeColor = System.Drawing.Color.RoyalBlue;
            btnL.ImageIndex = 0;
            btnL.ImageList = imageList1;
            btnL.Location = new System.Drawing.Point(12, 521);
            btnL.Name = "btnL";
            btnL.Size = new System.Drawing.Size(133, 128);
            btnL.TabIndex = 3;
            btnL.UseVisualStyleBackColor = true;
            btnL.Click += btnL_Click;
            // 
            // btnStart
            // 
            btnStart.Location = new System.Drawing.Point(273, 119);
            btnStart.Name = "btnStart";
            btnStart.Size = new System.Drawing.Size(42, 23);
            btnStart.TabIndex = 4;
            btnStart.Text = "시작";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
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
            // rbEasy
            // 
            rbEasy.AutoSize = true;
            rbEasy.Location = new System.Drawing.Point(162, 121);
            rbEasy.Name = "rbEasy";
            rbEasy.Size = new System.Drawing.Size(48, 19);
            rbEasy.TabIndex = 8;
            rbEasy.TabStop = true;
            rbEasy.Text = "Easy";
            rbEasy.UseVisualStyleBackColor = true;
            // 
            // rbHard
            // 
            rbHard.AutoSize = true;
            rbHard.Location = new System.Drawing.Point(216, 121);
            rbHard.Name = "rbHard";
            rbHard.Size = new System.Drawing.Size(51, 19);
            rbHard.TabIndex = 9;
            rbHard.TabStop = true;
            rbHard.Text = "Hard";
            rbHard.UseVisualStyleBackColor = true;
            // 
            // btnUL
            // 
            btnUL.Enabled = false;
            btnUL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnUL.ForeColor = System.Drawing.Color.RoyalBlue;
            btnUL.ImageIndex = 2;
            btnUL.ImageList = imageList1;
            btnUL.Location = new System.Drawing.Point(12, 251);
            btnUL.Name = "btnUL";
            btnUL.Size = new System.Drawing.Size(133, 124);
            btnUL.TabIndex = 10;
            btnUL.UseVisualStyleBackColor = true;
            btnUL.Visible = false;
            btnUL.Click += btnUL_Click;
            // 
            // btnUR
            // 
            btnUR.Enabled = false;
            btnUR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnUR.ForeColor = System.Drawing.Color.RoyalBlue;
            btnUR.ImageIndex = 3;
            btnUR.ImageList = imageList1;
            btnUR.Location = new System.Drawing.Point(339, 251);
            btnUR.Name = "btnUR";
            btnUR.Size = new System.Drawing.Size(133, 124);
            btnUR.TabIndex = 11;
            btnUR.UseVisualStyleBackColor = true;
            btnUR.Visible = false;
            btnUR.Click += btnUR_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.RoyalBlue;
            ClientSize = new System.Drawing.Size(484, 661);
            Controls.Add(btnUR);
            Controls.Add(btnUL);
            Controls.Add(rbHard);
            Controls.Add(rbEasy);
            Controls.Add(labelProgressBar1);
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
        private LabelProgressBar labelProgressBar1;
        private System.Windows.Forms.RadioButton rbEasy;
        private System.Windows.Forms.RadioButton rbHard;
        private System.Windows.Forms.Button btnUL;
        private System.Windows.Forms.Button btnUR;
    }
}
