namespace Week2
{
    partial class Form22
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
            this.모달리스ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.모달리스대화상자ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.모달리스ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.모달리스대화상자ToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // 모달리스대화상자ToolStripMenuItem
            // 
            this.모달리스대화상자ToolStripMenuItem.Name = "모달리스대화상자ToolStripMenuItem";
            this.모달리스대화상자ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.모달리스대화상자ToolStripMenuItem.Text = "모달리스 대화상자";
            this.모달리스대화상자ToolStripMenuItem.Click += new System.EventHandler(this.모달리스대화상자ToolStripMenuItem_Click);
            // 
            // 모달리스ToolStripMenuItem
            // 
            this.모달리스ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.모달리스대화상자ToolStripMenuItem1});
            this.모달리스ToolStripMenuItem.Name = "모달리스ToolStripMenuItem";
            this.모달리스ToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.모달리스ToolStripMenuItem.Text = "모달리스 ";
            // 
            // 모달리스대화상자ToolStripMenuItem1
            // 
            this.모달리스대화상자ToolStripMenuItem1.Name = "모달리스대화상자ToolStripMenuItem1";
            this.모달리스대화상자ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.모달리스대화상자ToolStripMenuItem1.Text = "모달리스 대화상자";
            // 
            // Form22
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form22";
            this.Text = "Form22";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 모달리스대화상자ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 모달리스ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 모달리스대화상자ToolStripMenuItem1;
    }
}