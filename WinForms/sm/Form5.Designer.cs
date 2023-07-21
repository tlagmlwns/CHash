namespace sm
{
    partial class Form5
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
            this.text_Result = new System.Windows.Forms.TextBox();
            this.text_Num1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.text_Num2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_Plus = new System.Windows.Forms.Button();
            this.bt_Minus = new System.Windows.Forms.Button();
            this.bt_Multi = new System.Windows.Forms.Button();
            this.bt_Division = new System.Windows.Forms.Button();
            this.bt_Sum = new System.Windows.Forms.Button();
            this.bt_Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text_Result
            // 
            this.text_Result.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text_Result.Location = new System.Drawing.Point(106, 39);
            this.text_Result.Name = "text_Result";
            this.text_Result.Size = new System.Drawing.Size(276, 29);
            this.text_Result.TabIndex = 0;
            // 
            // text_Num1
            // 
            this.text_Num1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text_Num1.Location = new System.Drawing.Point(106, 79);
            this.text_Num1.Name = "text_Num1";
            this.text_Num1.Size = new System.Drawing.Size(100, 29);
            this.text_Num1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(65, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "값1";
            // 
            // text_Num2
            // 
            this.text_Num2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text_Num2.Location = new System.Drawing.Point(282, 79);
            this.text_Num2.Name = "text_Num2";
            this.text_Num2.Size = new System.Drawing.Size(100, 29);
            this.text_Num2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(241, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "값2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(58, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "결과";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // bt_Plus
            // 
            this.bt_Plus.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bt_Plus.Location = new System.Drawing.Point(62, 129);
            this.bt_Plus.Name = "bt_Plus";
            this.bt_Plus.Size = new System.Drawing.Size(92, 36);
            this.bt_Plus.TabIndex = 3;
            this.bt_Plus.Text = "+";
            this.bt_Plus.UseVisualStyleBackColor = true;
            this.bt_Plus.Click += new System.EventHandler(this.bt_Plus_Click);
            // 
            // bt_Minus
            // 
            this.bt_Minus.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bt_Minus.Location = new System.Drawing.Point(170, 129);
            this.bt_Minus.Name = "bt_Minus";
            this.bt_Minus.Size = new System.Drawing.Size(98, 36);
            this.bt_Minus.TabIndex = 4;
            this.bt_Minus.Text = "-";
            this.bt_Minus.UseVisualStyleBackColor = true;
            this.bt_Minus.Click += new System.EventHandler(this.bt_Minus_Click);
            // 
            // bt_Multi
            // 
            this.bt_Multi.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bt_Multi.Location = new System.Drawing.Point(282, 129);
            this.bt_Multi.Name = "bt_Multi";
            this.bt_Multi.Size = new System.Drawing.Size(100, 36);
            this.bt_Multi.TabIndex = 3;
            this.bt_Multi.Text = "*";
            this.bt_Multi.UseVisualStyleBackColor = true;
            this.bt_Multi.Click += new System.EventHandler(this.bt_Multi_Click);
            // 
            // bt_Division
            // 
            this.bt_Division.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bt_Division.Location = new System.Drawing.Point(62, 171);
            this.bt_Division.Name = "bt_Division";
            this.bt_Division.Size = new System.Drawing.Size(92, 36);
            this.bt_Division.TabIndex = 4;
            this.bt_Division.Text = "/";
            this.bt_Division.UseVisualStyleBackColor = true;
            this.bt_Division.Click += new System.EventHandler(this.bt_Division_Click);
            // 
            // bt_Sum
            // 
            this.bt_Sum.Location = new System.Drawing.Point(170, 171);
            this.bt_Sum.Name = "bt_Sum";
            this.bt_Sum.Size = new System.Drawing.Size(98, 36);
            this.bt_Sum.TabIndex = 5;
            this.bt_Sum.Text = "%";
            this.bt_Sum.UseVisualStyleBackColor = true;
            this.bt_Sum.Click += new System.EventHandler(this.bt_Sum_Click);
            // 
            // bt_Clear
            // 
            this.bt_Clear.Location = new System.Drawing.Point(282, 171);
            this.bt_Clear.Name = "bt_Clear";
            this.bt_Clear.Size = new System.Drawing.Size(100, 36);
            this.bt_Clear.TabIndex = 5;
            this.bt_Clear.Text = "Clear";
            this.bt_Clear.UseVisualStyleBackColor = true;
            this.bt_Clear.Click += new System.EventHandler(this.bt_Clear_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 287);
            this.Controls.Add(this.bt_Clear);
            this.Controls.Add(this.bt_Sum);
            this.Controls.Add(this.bt_Division);
            this.Controls.Add(this.bt_Multi);
            this.Controls.Add(this.bt_Minus);
            this.Controls.Add(this.bt_Plus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_Num2);
            this.Controls.Add(this.text_Num1);
            this.Controls.Add(this.text_Result);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_Result;
        private System.Windows.Forms.TextBox text_Num1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_Num2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_Plus;
        private System.Windows.Forms.Button bt_Minus;
        private System.Windows.Forms.Button bt_Multi;
        private System.Windows.Forms.Button bt_Division;
        private System.Windows.Forms.Button bt_Sum;
        private System.Windows.Forms.Button bt_Clear;
    }
}