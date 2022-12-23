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
            this.tìmBệnhNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmThuốcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tùyChọnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmToaThuocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.benhNhanToolStripMenuItem.Image = global::PhongKham.Properties.Resources.examination;
            this.benhNhanToolStripMenuItem.Name = "benhNhanToolStripMenuItem";
            this.benhNhanToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.benhNhanToolStripMenuItem.Text = "Bệnh nhân";
            this.benhNhanToolStripMenuItem.Click += new System.EventHandler(this.benhNhanToolStripMenuItem_Click);
            // 
            // thuocToolStripMenuItem
            // 
            this.thuocToolStripMenuItem.Image = global::PhongKham.Properties.Resources.pill;
            this.thuocToolStripMenuItem.Name = "thuocToolStripMenuItem";
            this.thuocToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.thuocToolStripMenuItem.Text = "Thuốc";
            this.thuocToolStripMenuItem.Click += new System.EventHandler(this.thuocToolStripMenuItem_Click);
            // 
            // toaThuocToolStripMenuItem
            // 
            this.toaThuocToolStripMenuItem.Image = global::PhongKham.Properties.Resources.clipboard;
            this.toaThuocToolStripMenuItem.Name = "toaThuocToolStripMenuItem";
            this.toaThuocToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.toaThuocToolStripMenuItem.Text = "Toa thuốc";
            this.toaThuocToolStripMenuItem.Click += new System.EventHandler(this.toaThuocToolStripMenuItem_Click);
            // 
            // timKiemToolStripMenuItem
            // 
            this.timKiemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tìmBệnhNhânToolStripMenuItem,
            this.tìmThuốcToolStripMenuItem,
            this.tìmToaThuocToolStripMenuItem});
            this.timKiemToolStripMenuItem.Image = global::PhongKham.Properties.Resources.search;
            this.timKiemToolStripMenuItem.Name = "timKiemToolStripMenuItem";
            this.timKiemToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.timKiemToolStripMenuItem.Text = "Tìm kiếm";
            // 
            // tìmBệnhNhânToolStripMenuItem
            // 
            this.tìmBệnhNhânToolStripMenuItem.Name = "tìmBệnhNhânToolStripMenuItem";
            this.tìmBệnhNhânToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.tìmBệnhNhânToolStripMenuItem.Text = "Tìm bệnh nhân";
            this.tìmBệnhNhânToolStripMenuItem.Click += new System.EventHandler(this.tìmBệnhNhânToolStripMenuItem_Click);
            // 
            // tìmThuốcToolStripMenuItem
            // 
            this.tìmThuốcToolStripMenuItem.Name = "tìmThuốcToolStripMenuItem";
            this.tìmThuốcToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.tìmThuốcToolStripMenuItem.Text = "Tìm thuốc";
            this.tìmThuốcToolStripMenuItem.Click += new System.EventHandler(this.tìmThuốcToolStripMenuItem_Click);
            // 
            // báoCáoToolStripMenuItem
            // 
            this.báoCáoToolStripMenuItem.Image = global::PhongKham.Properties.Resources.presentation;
            this.báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            this.báoCáoToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.báoCáoToolStripMenuItem.Text = "Báo cáo";
            // 
            // tùyChọnToolStripMenuItem
            // 
            this.tùyChọnToolStripMenuItem.Image = global::PhongKham.Properties.Resources.options;
            this.tùyChọnToolStripMenuItem.Name = "tùyChọnToolStripMenuItem";
            this.tùyChọnToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.tùyChọnToolStripMenuItem.Text = "Tùy chọn";
            // 
            // tìmToaThuocToolStripMenuItem
            // 
            this.tìmToaThuocToolStripMenuItem.Name = "tìmToaThuocToolStripMenuItem";
            this.tìmToaThuocToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.tìmToaThuocToolStripMenuItem.Text = "Tìm toa thuốc";
            this.tìmToaThuocToolStripMenuItem.Click += new System.EventHandler(this.tìmToaThuocToolStripMenuItem_Click);
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
        private System.Windows.Forms.ToolStripMenuItem tìmBệnhNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmThuốcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmToaThuocToolStripMenuItem;
    }
}

