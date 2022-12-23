namespace PhongKham.Forms_DE
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.benhNhanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thuocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toaThuocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timKiemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tùyChọnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.benhNhanToolStripMenuItem,
            this.thuocToolStripMenuItem,
            this.toaThuocToolStripMenuItem,
            this.timKiemToolStripMenuItem,
            this.báoCáoToolStripMenuItem,
            this.tùyChọnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(850, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // benhNhanToolStripMenuItem
            // 
            this.benhNhanToolStripMenuItem.Name = "benhNhanToolStripMenuItem";
            this.benhNhanToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.benhNhanToolStripMenuItem.Text = "Bệnh nhân";
            this.benhNhanToolStripMenuItem.Click += new System.EventHandler(this.benhNhanToolStripMenuItem_Click);
            // 
            // thuocToolStripMenuItem
            // 
            this.thuocToolStripMenuItem.Name = "thuocToolStripMenuItem";
            this.thuocToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.thuocToolStripMenuItem.Text = "Thuốc";
            this.thuocToolStripMenuItem.Click += new System.EventHandler(this.thuocToolStripMenuItem_Click);
            // 
            // toaThuocToolStripMenuItem
            // 
            this.toaThuocToolStripMenuItem.Name = "toaThuocToolStripMenuItem";
            this.toaThuocToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.toaThuocToolStripMenuItem.Text = "Toa thuốc";
            this.toaThuocToolStripMenuItem.Click += new System.EventHandler(this.toaThuocToolStripMenuItem_Click);
            // 
            // timKiemToolStripMenuItem
            // 
            this.timKiemToolStripMenuItem.Name = "timKiemToolStripMenuItem";
            this.timKiemToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.timKiemToolStripMenuItem.Text = "Tìm kiếm";
            // 
            // báoCáoToolStripMenuItem
            // 
            this.báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            this.báoCáoToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.báoCáoToolStripMenuItem.Text = "Báo cáo";
            // 
            // tùyChọnToolStripMenuItem
            // 
            this.tùyChọnToolStripMenuItem.Name = "tùyChọnToolStripMenuItem";
            this.tùyChọnToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.tùyChọnToolStripMenuItem.Text = "Tùy chọn";
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::PhongKham.Properties.Resources.bh;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(850, 504);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phòng Khám";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem benhNhanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toaThuocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thuocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timKiemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tùyChọnToolStripMenuItem;
    }
}

