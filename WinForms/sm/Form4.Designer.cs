namespace sm
{
    partial class Form4
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
            this.lable3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_short = new System.Windows.Forms.Label();
            this.lb_int = new System.Windows.Forms.Label();
            this.lb_double = new System.Windows.Forms.Label();
            this.lb_Exception = new System.Windows.Forms.Label();
            this.Bth_short = new System.Windows.Forms.Button();
            this.Bth_int = new System.Windows.Forms.Button();
            this.Btn_double = new System.Windows.Forms.Button();
            this.txt_Number = new System.Windows.Forms.TextBox();
            this.Bth_All = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(89, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "WinFirm_DataType Test";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "short";
            // 
            // lable3
            // 
            this.lable3.AutoSize = true;
            this.lable3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lable3.Location = new System.Drawing.Point(12, 135);
            this.lable3.Name = "lable3";
            this.lable3.Size = new System.Drawing.Size(29, 21);
            this.lable3.TabIndex = 2;
            this.lable3.Text = "int";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(12, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "double";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(12, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Exception";
            // 
            // lb_short
            // 
            this.lb_short.AutoSize = true;
            this.lb_short.Location = new System.Drawing.Point(122, 90);
            this.lb_short.Name = "lb_short";
            this.lb_short.Size = new System.Drawing.Size(11, 12);
            this.lb_short.TabIndex = 1;
            this.lb_short.Text = "-";
            // 
            // lb_int
            // 
            this.lb_int.AutoSize = true;
            this.lb_int.Location = new System.Drawing.Point(122, 142);
            this.lb_int.Name = "lb_int";
            this.lb_int.Size = new System.Drawing.Size(11, 12);
            this.lb_int.TabIndex = 2;
            this.lb_int.Text = "-";
            // 
            // lb_double
            // 
            this.lb_double.AutoSize = true;
            this.lb_double.Location = new System.Drawing.Point(122, 193);
            this.lb_double.Name = "lb_double";
            this.lb_double.Size = new System.Drawing.Size(11, 12);
            this.lb_double.TabIndex = 3;
            this.lb_double.Text = "-";
            // 
            // lb_Exception
            // 
            this.lb_Exception.AutoSize = true;
            this.lb_Exception.Location = new System.Drawing.Point(122, 247);
            this.lb_Exception.Name = "lb_Exception";
            this.lb_Exception.Size = new System.Drawing.Size(11, 12);
            this.lb_Exception.TabIndex = 4;
            this.lb_Exception.Text = "-";
            // 
            // Bth_short
            // 
            this.Bth_short.Location = new System.Drawing.Point(325, 79);
            this.Bth_short.Name = "Bth_short";
            this.Bth_short.Size = new System.Drawing.Size(97, 23);
            this.Bth_short.TabIndex = 5;
            this.Bth_short.Text = "short 변환";
            this.Bth_short.UseVisualStyleBackColor = true;
            this.Bth_short.Click += new System.EventHandler(this.Bth_short_Click);
            // 
            // Bth_int
            // 
            this.Bth_int.Location = new System.Drawing.Point(325, 131);
            this.Bth_int.Name = "Bth_int";
            this.Bth_int.Size = new System.Drawing.Size(97, 23);
            this.Bth_int.TabIndex = 6;
            this.Bth_int.Text = "int 변환";
            this.Bth_int.UseVisualStyleBackColor = true;
            this.Bth_int.Click += new System.EventHandler(this.Bth_int_Click);
            // 
            // Btn_double
            // 
            this.Btn_double.Location = new System.Drawing.Point(325, 182);
            this.Btn_double.Name = "Btn_double";
            this.Btn_double.Size = new System.Drawing.Size(97, 23);
            this.Btn_double.TabIndex = 7;
            this.Btn_double.Text = "double 변환";
            this.Btn_double.UseVisualStyleBackColor = true;
            this.Btn_double.Click += new System.EventHandler(this.Btn_double_Click);
            // 
            // txt_Number
            // 
            this.txt_Number.Location = new System.Drawing.Point(16, 308);
            this.txt_Number.Name = "txt_Number";
            this.txt_Number.Size = new System.Drawing.Size(306, 21);
            this.txt_Number.TabIndex = 8;
            // 
            // Bth_All
            // 
            this.Bth_All.Location = new System.Drawing.Point(328, 308);
            this.Bth_All.Name = "Bth_All";
            this.Bth_All.Size = new System.Drawing.Size(94, 21);
            this.Bth_All.TabIndex = 9;
            this.Bth_All.Text = "전체변환";
            this.Bth_All.UseVisualStyleBackColor = true;
            this.Bth_All.Click += new System.EventHandler(this.Bth_All_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "* TextBox 콘트롤";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Bth_All);
            this.Controls.Add(this.txt_Number);
            this.Controls.Add(this.Btn_double);
            this.Controls.Add(this.Bth_int);
            this.Controls.Add(this.Bth_short);
            this.Controls.Add(this.lb_Exception);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lb_double);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_int);
            this.Controls.Add(this.lable3);
            this.Controls.Add(this.lb_short);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lable3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_short;
        private System.Windows.Forms.Label lb_int;
        private System.Windows.Forms.Label lb_double;
        private System.Windows.Forms.Label lb_Exception;
        private System.Windows.Forms.Button Bth_short;
        private System.Windows.Forms.Button Bth_int;
        private System.Windows.Forms.Button Btn_double;
        private System.Windows.Forms.TextBox txt_Number;
        private System.Windows.Forms.Button Bth_All;
        private System.Windows.Forms.Label label3;
    }
}