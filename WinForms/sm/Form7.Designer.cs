namespace sm
{
    partial class Form7
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.bt_For = new System.Windows.Forms.Button();
            this.bt_Foreach = new System.Windows.Forms.Button();
            this.bt_While = new System.Windows.Forms.Button();
            this.bt_doWhile = new System.Windows.Forms.Button();
            this.bt_Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(498, 400);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // bt_For
            // 
            this.bt_For.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bt_For.Location = new System.Drawing.Point(516, 12);
            this.bt_For.Name = "bt_For";
            this.bt_For.Size = new System.Drawing.Size(202, 60);
            this.bt_For.TabIndex = 1;
            this.bt_For.Text = "For문";
            this.bt_For.UseVisualStyleBackColor = true;
            this.bt_For.Click += new System.EventHandler(this.bt_For_Click);
            // 
            // bt_Foreach
            // 
            this.bt_Foreach.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bt_Foreach.Location = new System.Drawing.Point(516, 96);
            this.bt_Foreach.Name = "bt_Foreach";
            this.bt_Foreach.Size = new System.Drawing.Size(202, 60);
            this.bt_Foreach.TabIndex = 1;
            this.bt_Foreach.Text = "Foreach문";
            this.bt_Foreach.UseVisualStyleBackColor = true;
            this.bt_Foreach.Click += new System.EventHandler(this.bt_Foreach_Click);
            // 
            // bt_While
            // 
            this.bt_While.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bt_While.Location = new System.Drawing.Point(516, 184);
            this.bt_While.Name = "bt_While";
            this.bt_While.Size = new System.Drawing.Size(202, 60);
            this.bt_While.TabIndex = 1;
            this.bt_While.Text = "While문";
            this.bt_While.UseVisualStyleBackColor = true;
            this.bt_While.Click += new System.EventHandler(this.bt_While_Click);
            // 
            // bt_doWhile
            // 
            this.bt_doWhile.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bt_doWhile.Location = new System.Drawing.Point(517, 268);
            this.bt_doWhile.Name = "bt_doWhile";
            this.bt_doWhile.Size = new System.Drawing.Size(202, 60);
            this.bt_doWhile.TabIndex = 1;
            this.bt_doWhile.Text = "doWhile문";
            this.bt_doWhile.UseVisualStyleBackColor = true;
            this.bt_doWhile.Click += new System.EventHandler(this.bt_doWhile_Click);
            // 
            // bt_Clear
            // 
            this.bt_Clear.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bt_Clear.Location = new System.Drawing.Point(516, 352);
            this.bt_Clear.Name = "bt_Clear";
            this.bt_Clear.Size = new System.Drawing.Size(202, 60);
            this.bt_Clear.TabIndex = 2;
            this.bt_Clear.Text = "초기화";
            this.bt_Clear.UseVisualStyleBackColor = true;
            this.bt_Clear.Click += new System.EventHandler(this.bt_Clear_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 450);
            this.Controls.Add(this.bt_Clear);
            this.Controls.Add(this.bt_doWhile);
            this.Controls.Add(this.bt_While);
            this.Controls.Add(this.bt_Foreach);
            this.Controls.Add(this.bt_For);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form7";
            this.Text = "Form7";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button bt_For;
        private System.Windows.Forms.Button bt_Foreach;
        private System.Windows.Forms.Button bt_While;
        private System.Windows.Forms.Button bt_doWhile;
        private System.Windows.Forms.Button bt_Clear;
    }
}