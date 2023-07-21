namespace sm
{
    partial class Form3
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
            this.lb_Test = new System.Windows.Forms.Label();
            this.lb_Contain = new System.Windows.Forms.Label();
            this.lb_Equals = new System.Windows.Forms.Label();
            this.lb_Length = new System.Windows.Forms.Label();
            this.lb_Replace = new System.Windows.Forms.Label();
            this.lb_Substring = new System.Windows.Forms.Label();
            this.lb_ToLower = new System.Windows.Forms.Label();
            this.lb_ToUpper = new System.Windows.Forms.Label();
            this.lb_Trim = new System.Windows.Forms.Label();
            this.lb_Split1 = new System.Windows.Forms.Label();
            this.lb_Split2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Test
            // 
            this.lb_Test.AutoSize = true;
            this.lb_Test.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_Test.Location = new System.Drawing.Point(42, 32);
            this.lb_Test.Name = "lb_Test";
            this.lb_Test.Size = new System.Drawing.Size(254, 30);
            this.lb_Test.TabIndex = 0;
            this.lb_Test.Text = "(label)Winform_StringTest";
            // 
            // lb_Contain
            // 
            this.lb_Contain.AutoSize = true;
            this.lb_Contain.Location = new System.Drawing.Point(47, 110);
            this.lb_Contain.Name = "lb_Contain";
            this.lb_Contain.Size = new System.Drawing.Size(11, 12);
            this.lb_Contain.TabIndex = 1;
            this.lb_Contain.Text = "-";
            // 
            // lb_Equals
            // 
            this.lb_Equals.AutoSize = true;
            this.lb_Equals.Location = new System.Drawing.Point(47, 152);
            this.lb_Equals.Name = "lb_Equals";
            this.lb_Equals.Size = new System.Drawing.Size(11, 12);
            this.lb_Equals.TabIndex = 2;
            this.lb_Equals.Text = "-";
            // 
            // lb_Length
            // 
            this.lb_Length.AutoSize = true;
            this.lb_Length.Location = new System.Drawing.Point(47, 193);
            this.lb_Length.Name = "lb_Length";
            this.lb_Length.Size = new System.Drawing.Size(11, 12);
            this.lb_Length.TabIndex = 3;
            this.lb_Length.Text = "-";
            // 
            // lb_Replace
            // 
            this.lb_Replace.AutoSize = true;
            this.lb_Replace.Location = new System.Drawing.Point(47, 231);
            this.lb_Replace.Name = "lb_Replace";
            this.lb_Replace.Size = new System.Drawing.Size(11, 12);
            this.lb_Replace.TabIndex = 4;
            this.lb_Replace.Text = "-";
            // 
            // lb_Substring
            // 
            this.lb_Substring.AutoSize = true;
            this.lb_Substring.Location = new System.Drawing.Point(260, 110);
            this.lb_Substring.Name = "lb_Substring";
            this.lb_Substring.Size = new System.Drawing.Size(11, 12);
            this.lb_Substring.TabIndex = 1;
            this.lb_Substring.Text = "-";
            // 
            // lb_ToLower
            // 
            this.lb_ToLower.AutoSize = true;
            this.lb_ToLower.Location = new System.Drawing.Point(260, 152);
            this.lb_ToLower.Name = "lb_ToLower";
            this.lb_ToLower.Size = new System.Drawing.Size(11, 12);
            this.lb_ToLower.TabIndex = 2;
            this.lb_ToLower.Text = "-";
            this.lb_ToLower.Click += new System.EventHandler(this.label6_Click);
            // 
            // lb_ToUpper
            // 
            this.lb_ToUpper.AutoSize = true;
            this.lb_ToUpper.Location = new System.Drawing.Point(260, 193);
            this.lb_ToUpper.Name = "lb_ToUpper";
            this.lb_ToUpper.Size = new System.Drawing.Size(11, 12);
            this.lb_ToUpper.TabIndex = 3;
            this.lb_ToUpper.Text = "-";
            // 
            // lb_Trim
            // 
            this.lb_Trim.AutoSize = true;
            this.lb_Trim.Location = new System.Drawing.Point(260, 231);
            this.lb_Trim.Name = "lb_Trim";
            this.lb_Trim.Size = new System.Drawing.Size(11, 12);
            this.lb_Trim.TabIndex = 4;
            this.lb_Trim.Text = "-";
            // 
            // lb_Split1
            // 
            this.lb_Split1.AutoSize = true;
            this.lb_Split1.Location = new System.Drawing.Point(47, 269);
            this.lb_Split1.Name = "lb_Split1";
            this.lb_Split1.Size = new System.Drawing.Size(11, 12);
            this.lb_Split1.TabIndex = 1;
            this.lb_Split1.Text = "-";
            // 
            // lb_Split2
            // 
            this.lb_Split2.AutoSize = true;
            this.lb_Split2.Location = new System.Drawing.Point(47, 307);
            this.lb_Split2.Name = "lb_Split2";
            this.lb_Split2.Size = new System.Drawing.Size(11, 12);
            this.lb_Split2.TabIndex = 2;
            this.lb_Split2.Text = "-";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(339, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "실행하기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(339, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "초기화";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_Trim);
            this.Controls.Add(this.lb_Replace);
            this.Controls.Add(this.lb_ToUpper);
            this.Controls.Add(this.lb_Length);
            this.Controls.Add(this.lb_ToLower);
            this.Controls.Add(this.lb_Substring);
            this.Controls.Add(this.lb_Split2);
            this.Controls.Add(this.lb_Split1);
            this.Controls.Add(this.lb_Equals);
            this.Controls.Add(this.lb_Contain);
            this.Controls.Add(this.lb_Test);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Test;
        private System.Windows.Forms.Label lb_Contain;
        private System.Windows.Forms.Label lb_Equals;
        private System.Windows.Forms.Label lb_Length;
        private System.Windows.Forms.Label lb_Replace;
        private System.Windows.Forms.Label lb_Substring;
        private System.Windows.Forms.Label lb_ToLower;
        private System.Windows.Forms.Label lb_ToUpper;
        private System.Windows.Forms.Label lb_Trim;
        private System.Windows.Forms.Label lb_Split1;
        private System.Windows.Forms.Label lb_Split2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}