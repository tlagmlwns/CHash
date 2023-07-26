namespace Week2
{
    partial class ModalForm
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
            this.모달열기ToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.닫기ToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btn5k = new System.Windows.Forms.Button();
            this.btnY = new System.Windows.Forms.Button();
            this.btnN = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.모달열기ToolStripMenu,
            this.닫기ToolStripMenu});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // 모달열기ToolStripMenu
            // 
            this.모달열기ToolStripMenu.Name = "모달열기ToolStripMenu";
            this.모달열기ToolStripMenu.Size = new System.Drawing.Size(122, 22);
            this.모달열기ToolStripMenu.Text = "모달열기";
            this.모달열기ToolStripMenu.Click += new System.EventHandler(this.모달열기ToolStripMenu_Click);
            // 
            // 닫기ToolStripMenu
            // 
            this.닫기ToolStripMenu.Name = "닫기ToolStripMenu";
            this.닫기ToolStripMenu.Size = new System.Drawing.Size(122, 22);
            this.닫기ToolStripMenu.Text = "닫기";
            this.닫기ToolStripMenu.Click += new System.EventHandler(this.닫기ToolStripMenu_Click);
            // 
            // btn5k
            // 
            this.btn5k.Location = new System.Drawing.Point(180, 137);
            this.btn5k.Name = "btn5k";
            this.btn5k.Size = new System.Drawing.Size(75, 23);
            this.btn5k.TabIndex = 0;
            this.btn5k.Text = "OK";
            this.btn5k.UseVisualStyleBackColor = true;
            this.btn5k.Click += new System.EventHandler(this.btn5k_Click);
            // 
            // btnY
            // 
            this.btnY.Location = new System.Drawing.Point(180, 177);
            this.btnY.Name = "btnY";
            this.btnY.Size = new System.Drawing.Size(75, 23);
            this.btnY.TabIndex = 0;
            this.btnY.Text = "Yes";
            this.btnY.UseVisualStyleBackColor = true;
            this.btnY.Click += new System.EventHandler(this.btnY_Click);
            // 
            // btnN
            // 
            this.btnN.Location = new System.Drawing.Point(180, 218);
            this.btnN.Name = "btnN";
            this.btnN.Size = new System.Drawing.Size(75, 23);
            this.btnN.TabIndex = 1;
            this.btnN.Text = "No";
            this.btnN.UseVisualStyleBackColor = true;
            this.btnN.Click += new System.EventHandler(this.btnN_Click);
            // 
            // ModalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnN);
            this.Controls.Add(this.btnY);
            this.Controls.Add(this.btn5k);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ModalForm";
            this.Text = "ModalForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 모달열기ToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem 닫기ToolStripMenu;
        private System.Windows.Forms.Button btnY;
        private System.Windows.Forms.Button btn5k;
        private System.Windows.Forms.Button btnN;
    }
}