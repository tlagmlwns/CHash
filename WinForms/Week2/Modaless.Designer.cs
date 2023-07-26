namespace Week2
{
    partial class Modaless
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.모달리스대화상자ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.모달리스대화상자ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.모달리스대화상자ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // 모달리스대화상자ToolStripMenuItem
            // 
            this.모달리스대화상자ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.모달리스대화상자ToolStripMenuItem1});
            this.모달리스대화상자ToolStripMenuItem.Name = "모달리스대화상자ToolStripMenuItem";
            this.모달리스대화상자ToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.모달리스대화상자ToolStripMenuItem.Text = "모달리스 대화상자";
            // 
            // 모달리스대화상자ToolStripMenuItem1
            // 
            this.모달리스대화상자ToolStripMenuItem1.Name = "모달리스대화상자ToolStripMenuItem1";
            this.모달리스대화상자ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.모달리스대화상자ToolStripMenuItem1.Text = "모달리스 대화상자";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(184, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 288);
            this.label1.TabIndex = 1;
            this.label1.Text = "모달리스 \r\n대화상자 \r\n입니다.";
            // 
            // Modaless
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Modaless";
            this.Text = "Modaless";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 모달리스대화상자ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 모달리스대화상자ToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
    }
}