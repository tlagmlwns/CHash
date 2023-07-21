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
            this.lb_test = new System.Windows.Forms.Label();
            this.lb_Contain = new System.Windows.Forms.Label();
            this.lb_Equals = new System.Windows.Forms.Label();
            this.lb_Length = new System.Windows.Forms.Label();
            this.lb_Replace = new System.Windows.Forms.Label();
            this.lb_Substring = new System.Windows.Forms.Label();
            this.lb_ToLower = new System.Windows.Forms.Label();
            this.lb_ToUpper = new System.Windows.Forms.Label();
            this.lb_Trim = new System.Windows.Forms.Label();
            this.lb_Split = new System.Windows.Forms.Label();
            this.lb_Split2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_test
            // 
            this.lb_test.AutoSize = true;
            this.lb_test.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_test.Location = new System.Drawing.Point(42, 32);
            this.lb_test.Name = "lb_test";
            this.lb_test.Size = new System.Drawing.Size(254, 30);
            this.lb_test.TabIndex = 0;
            this.lb_test.Text = "(label)Winform_StringTest";
            // 
            // lb_Contain
            // 
            this.lb_Contain.AutoSize = true;
            this.lb_Contain.Location = new System.Drawing.Point(47, 87);
            this.lb_Contain.Name = "lb_Contain";
            this.lb_Contain.Size = new System.Drawing.Size(11, 12);
            this.lb_Contain.TabIndex = 1;
            this.lb_Contain.Text = "-";
            // 
            // lb_Equals
            // 
            this.lb_Equals.AutoSize = true;
            this.lb_Equals.Location = new System.Drawing.Point(47, 129);
            this.lb_Equals.Name = "lb_Equals";
            this.lb_Equals.Size = new System.Drawing.Size(11, 12);
            this.lb_Equals.TabIndex = 2;
            this.lb_Equals.Text = "-";
            // 
            // lb_Length
            // 
            this.lb_Length.AutoSize = true;
            this.lb_Length.Location = new System.Drawing.Point(47, 170);
            this.lb_Length.Name = "lb_Length";
            this.lb_Length.Size = new System.Drawing.Size(11, 12);
            this.lb_Length.TabIndex = 3;
            this.lb_Length.Text = "-";
            // 
            // lb_Replace
            // 
            this.lb_Replace.AutoSize = true;
            this.lb_Replace.Location = new System.Drawing.Point(47, 208);
            this.lb_Replace.Name = "lb_Replace";
            this.lb_Replace.Size = new System.Drawing.Size(11, 12);
            this.lb_Replace.TabIndex = 4;
            this.lb_Replace.Text = "-";
            // 
            // lb_Substring
            // 
            this.lb_Substring.AutoSize = true;
            this.lb_Substring.Location = new System.Drawing.Point(260, 87);
            this.lb_Substring.Name = "lb_Substring";
            this.lb_Substring.Size = new System.Drawing.Size(11, 12);
            this.lb_Substring.TabIndex = 1;
            this.lb_Substring.Text = "-";
            // 
            // lb_ToLower
            // 
            this.lb_ToLower.AutoSize = true;
            this.lb_ToLower.Location = new System.Drawing.Point(260, 129);
            this.lb_ToLower.Name = "lb_ToLower";
            this.lb_ToLower.Size = new System.Drawing.Size(11, 12);
            this.lb_ToLower.TabIndex = 2;
            this.lb_ToLower.Text = "-";
            this.lb_ToLower.Click += new System.EventHandler(this.label6_Click);
            // 
            // lb_ToUpper
            // 
            this.lb_ToUpper.AutoSize = true;
            this.lb_ToUpper.Location = new System.Drawing.Point(260, 170);
            this.lb_ToUpper.Name = "lb_ToUpper";
            this.lb_ToUpper.Size = new System.Drawing.Size(11, 12);
            this.lb_ToUpper.TabIndex = 3;
            this.lb_ToUpper.Text = "-";
            // 
            // lb_Trim
            // 
            this.lb_Trim.AutoSize = true;
            this.lb_Trim.Location = new System.Drawing.Point(260, 208);
            this.lb_Trim.Name = "lb_Trim";
            this.lb_Trim.Size = new System.Drawing.Size(11, 12);
            this.lb_Trim.TabIndex = 4;
            this.lb_Trim.Text = "-";
            // 
            // lb_Split
            // 
            this.lb_Split.AutoSize = true;
            this.lb_Split.Location = new System.Drawing.Point(47, 246);
            this.lb_Split.Name = "lb_Split";
            this.lb_Split.Size = new System.Drawing.Size(11, 12);
            this.lb_Split.TabIndex = 1;
            this.lb_Split.Text = "-";
            // 
            // lb_Split2
            // 
            this.lb_Split2.AutoSize = true;
            this.lb_Split2.Location = new System.Drawing.Point(47, 284);
            this.lb_Split2.Name = "lb_Split2";
            this.lb_Split2.Size = new System.Drawing.Size(11, 12);
            this.lb_Split2.TabIndex = 2;
            this.lb_Split2.Text = "-";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_Trim);
            this.Controls.Add(this.lb_Replace);
            this.Controls.Add(this.lb_ToUpper);
            this.Controls.Add(this.lb_Length);
            this.Controls.Add(this.lb_ToLower);
            this.Controls.Add(this.lb_Substring);
            this.Controls.Add(this.lb_Split2);
            this.Controls.Add(this.lb_Split);
            this.Controls.Add(this.lb_Equals);
            this.Controls.Add(this.lb_Contain);
            this.Controls.Add(this.lb_test);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_test;
        private System.Windows.Forms.Label lb_Contain;
        private System.Windows.Forms.Label lb_Equals;
        private System.Windows.Forms.Label lb_Length;
        private System.Windows.Forms.Label lb_Replace;
        private System.Windows.Forms.Label lb_Substring;
        private System.Windows.Forms.Label lb_ToLower;
        private System.Windows.Forms.Label lb_ToUpper;
        private System.Windows.Forms.Label lb_Trim;
        private System.Windows.Forms.Label lb_Split;
        private System.Windows.Forms.Label lb_Split2;
    }
}