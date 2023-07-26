namespace Week2
{
    partial class Form25
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
            this.components = new System.ComponentModel.Container();
            this.btnMO = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnMO
            // 
            this.btnMO.Font = new System.Drawing.Font("굴림", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMO.Location = new System.Drawing.Point(13, 13);
            this.btnMO.Name = "btnMO";
            this.btnMO.Size = new System.Drawing.Size(355, 149);
            this.btnMO.TabIndex = 0;
            this.btnMO.Text = "메세지 창 띄우기";
            this.btnMO.UseVisualStyleBackColor = true;
            this.btnMO.Click += new System.EventHandler(this.btnMO_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form25
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 185);
            this.Controls.Add(this.btnMO);
            this.Name = "Form25";
            this.Text = "Form25";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMO;
        private System.Windows.Forms.Timer timer1;
    }
}