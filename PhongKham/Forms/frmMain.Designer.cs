namespace PhongKham.Forms
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
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripBenhNhan = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripThuoc = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripToaThuoc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBenhNhan,
            this.toolStripThuoc,
            this.toolStripToaThuoc});
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.danhMụcToolStripMenuItem.Text = "Danh mục";
            // 
            // toolStripBenhNhan
            // 
            this.toolStripBenhNhan.Name = "toolStripBenhNhan";
            this.toolStripBenhNhan.Size = new System.Drawing.Size(224, 26);
            this.toolStripBenhNhan.Text = "Bệnh nhân";
            this.toolStripBenhNhan.Click += new System.EventHandler(this.toolStripBenhNhan_Click);
            // 
            // toolStripThuoc
            // 
            this.toolStripThuoc.Name = "toolStripThuoc";
            this.toolStripThuoc.Size = new System.Drawing.Size(224, 26);
            this.toolStripThuoc.Text = "Thuốc";
            this.toolStripThuoc.Click += new System.EventHandler(this.toolStripThuoc_Click);
            // 
            // toolStripToaThuoc
            // 
            this.toolStripToaThuoc.Name = "toolStripToaThuoc";
            this.toolStripToaThuoc.Size = new System.Drawing.Size(224, 26);
            this.toolStripToaThuoc.Text = "Toa thuốc";
            this.toolStripToaThuoc.Click += new System.EventHandler(this.toolStripToaThuoc_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhMụcToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(850, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(850, 504);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Phòng Khám";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripBenhNhan;
        private System.Windows.Forms.ToolStripMenuItem toolStripThuoc;
        private System.Windows.Forms.ToolStripMenuItem toolStripToaThuoc;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

