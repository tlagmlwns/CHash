namespace Week2
{
    partial class Form9
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbC = new System.Windows.Forms.TextBox();
            this.tbCpp = new System.Windows.Forms.TextBox();
            this.tbChash = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbaverage = new System.Windows.Forms.TextBox();
            this.btnResult = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "C언어";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "C++언어";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "C#언어";
            // 
            // tbC
            // 
            this.tbC.Location = new System.Drawing.Point(122, 49);
            this.tbC.Name = "tbC";
            this.tbC.Size = new System.Drawing.Size(100, 21);
            this.tbC.TabIndex = 3;
            // 
            // tbCpp
            // 
            this.tbCpp.Location = new System.Drawing.Point(122, 110);
            this.tbCpp.Name = "tbCpp";
            this.tbCpp.Size = new System.Drawing.Size(100, 21);
            this.tbCpp.TabIndex = 4;
            // 
            // tbChash
            // 
            this.tbChash.Location = new System.Drawing.Point(122, 168);
            this.tbChash.Name = "tbChash";
            this.tbChash.Size = new System.Drawing.Size(100, 21);
            this.tbChash.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "평균";
            // 
            // tbaverage
            // 
            this.tbaverage.Location = new System.Drawing.Point(122, 224);
            this.tbaverage.Name = "tbaverage";
            this.tbaverage.Size = new System.Drawing.Size(100, 21);
            this.tbaverage.TabIndex = 7;
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(48, 297);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(75, 23);
            this.btnResult.TabIndex = 8;
            this.btnResult.Text = "결과보기";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(147, 297);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "지우기";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 355);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.tbaverage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbChash);
            this.Controls.Add(this.tbCpp);
            this.Controls.Add(this.tbC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form9";
            this.Text = "Form9";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbC;
        private System.Windows.Forms.TextBox tbCpp;
        private System.Windows.Forms.TextBox tbChash;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbaverage;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button btnClear;
    }
}