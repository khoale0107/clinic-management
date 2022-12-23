namespace PhongKham.Forms_DE
{
    partial class frmChiTietToaThuoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChiTietToaThuoc));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripCancel = new System.Windows.Forms.ToolStripButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cbThuoc = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtSoLuong = new System.Windows.Forms.NumericUpDown();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtLieuDung = new System.Windows.Forms.TextBox();
            this.txtTenBenhNhan = new System.Windows.Forms.TextBox();
            this.txtIdToaThuoc = new System.Windows.Forms.TextBox();
            this.txtNgayKham = new System.Windows.Forms.TextBox();
            this.txtBenhDuocChanDOan = new System.Windows.Forms.TextBox();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dgvChiTietToaThuoc = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbThuoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietToaThuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(370, 41);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(322, 36);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "CHI TIẾT TOA THUỐC";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSave,
            this.toolStripDelete,
            this.toolStripCancel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1025, 27);
            this.toolStrip1.TabIndex = 17;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSave
            // 
            this.toolStripSave.Image = global::PhongKham.Properties.Resources.diskette;
            this.toolStripSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSave.Name = "toolStripSave";
            this.toolStripSave.Size = new System.Drawing.Size(64, 24);
            this.toolStripSave.Text = "Save";
            this.toolStripSave.Click += new System.EventHandler(this.toolStripSave_Click);
            // 
            // toolStripDelete
            // 
            this.toolStripDelete.Image = global::PhongKham.Properties.Resources.delete1;
            this.toolStripDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDelete.Name = "toolStripDelete";
            this.toolStripDelete.Size = new System.Drawing.Size(77, 24);
            this.toolStripDelete.Text = "Delete";
            this.toolStripDelete.Click += new System.EventHandler(this.toolStripDelete_Click);
            // 
            // toolStripCancel
            // 
            this.toolStripCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripCancel.Image = ((System.Drawing.Image)(resources.GetObject("toolStripCancel.Image")));
            this.toolStripCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCancel.Name = "toolStripCancel";
            this.toolStripCancel.Size = new System.Drawing.Size(57, 24);
            this.toolStripCancel.Text = "Cancel";
            this.toolStripCancel.Click += new System.EventHandler(this.toolStripCancel_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupControl1.Controls.Add(this.cbThuoc);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.txtSoLuong);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.txtLieuDung);
            this.groupControl1.Location = new System.Drawing.Point(12, 94);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(24);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(376, 226);
            this.groupControl1.TabIndex = 34;
            this.groupControl1.Text = "Chi tiết toa thuốc";
            // 
            // cbThuoc
            // 
            this.cbThuoc.Location = new System.Drawing.Point(127, 46);
            this.cbThuoc.Name = "cbThuoc";
            this.cbThuoc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbThuoc.Properties.PopupView = this.searchLookUpEdit1View;
            this.cbThuoc.Size = new System.Drawing.Size(234, 22);
            this.cbThuoc.TabIndex = 45;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(23, 123);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(60, 16);
            this.labelControl9.TabIndex = 44;
            this.labelControl9.Text = "Liều dùng:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(127, 83);
            this.txtSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(233, 23);
            this.txtSoLuong.TabIndex = 41;
            this.txtSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(23, 85);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(56, 16);
            this.labelControl8.TabIndex = 40;
            this.labelControl8.Text = "Số lượng:";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(23, 49);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(62, 16);
            this.labelControl7.TabIndex = 39;
            this.labelControl7.Text = "Tên thuốc:";
            // 
            // txtLieuDung
            // 
            this.txtLieuDung.Location = new System.Drawing.Point(128, 123);
            this.txtLieuDung.Multiline = true;
            this.txtLieuDung.Name = "txtLieuDung";
            this.txtLieuDung.Size = new System.Drawing.Size(233, 57);
            this.txtLieuDung.TabIndex = 33;
            // 
            // txtTenBenhNhan
            // 
            this.txtTenBenhNhan.Location = new System.Drawing.Point(130, 76);
            this.txtTenBenhNhan.Name = "txtTenBenhNhan";
            this.txtTenBenhNhan.ReadOnly = true;
            this.txtTenBenhNhan.Size = new System.Drawing.Size(232, 23);
            this.txtTenBenhNhan.TabIndex = 19;
            // 
            // txtIdToaThuoc
            // 
            this.txtIdToaThuoc.Location = new System.Drawing.Point(130, 42);
            this.txtIdToaThuoc.Name = "txtIdToaThuoc";
            this.txtIdToaThuoc.ReadOnly = true;
            this.txtIdToaThuoc.Size = new System.Drawing.Size(231, 23);
            this.txtIdToaThuoc.TabIndex = 28;
            // 
            // txtNgayKham
            // 
            this.txtNgayKham.Location = new System.Drawing.Point(129, 112);
            this.txtNgayKham.Name = "txtNgayKham";
            this.txtNgayKham.ReadOnly = true;
            this.txtNgayKham.Size = new System.Drawing.Size(231, 23);
            this.txtNgayKham.TabIndex = 32;
            // 
            // txtBenhDuocChanDOan
            // 
            this.txtBenhDuocChanDOan.Location = new System.Drawing.Point(159, 150);
            this.txtBenhDuocChanDOan.Multiline = true;
            this.txtBenhDuocChanDOan.Name = "txtBenhDuocChanDOan";
            this.txtBenhDuocChanDOan.ReadOnly = true;
            this.txtBenhDuocChanDOan.Size = new System.Drawing.Size(201, 57);
            this.txtBenhDuocChanDOan.TabIndex = 33;
            // 
            // groupControl2
            // 
            this.groupControl2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.txtBenhDuocChanDOan);
            this.groupControl2.Controls.Add(this.txtNgayKham);
            this.groupControl2.Controls.Add(this.txtIdToaThuoc);
            this.groupControl2.Controls.Add(this.txtTenBenhNhan);
            this.groupControl2.Location = new System.Drawing.Point(12, 328);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(24);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(376, 226);
            this.groupControl2.TabIndex = 18;
            this.groupControl2.Text = "Toa thuốc";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(23, 153);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(128, 16);
            this.labelControl5.TabIndex = 37;
            this.labelControl5.Text = "Bệnh được chẩn đoán:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(23, 79);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(65, 16);
            this.labelControl4.TabIndex = 36;
            this.labelControl4.Text = "Bệnh nhân:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(23, 115);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(68, 16);
            this.labelControl3.TabIndex = 35;
            this.labelControl3.Text = "Ngày khám:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(23, 45);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(86, 16);
            this.labelControl2.TabIndex = 34;
            this.labelControl2.Text = "STT toa thuốc:";
            // 
            // dgvChiTietToaThuoc
            // 
            this.dgvChiTietToaThuoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvChiTietToaThuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietToaThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietToaThuoc.Location = new System.Drawing.Point(401, 94);
            this.dgvChiTietToaThuoc.Margin = new System.Windows.Forms.Padding(4);
            this.dgvChiTietToaThuoc.Name = "dgvChiTietToaThuoc";
            this.dgvChiTietToaThuoc.ReadOnly = true;
            this.dgvChiTietToaThuoc.RowHeadersWidth = 51;
            this.dgvChiTietToaThuoc.RowTemplate.Height = 24;
            this.dgvChiTietToaThuoc.Size = new System.Drawing.Size(611, 460);
            this.dgvChiTietToaThuoc.TabIndex = 45;
            this.dgvChiTietToaThuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietToaThuoc_CellClick);
            // 
            // frmChiTietToaThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 567);
            this.Controls.Add(this.dgvChiTietToaThuoc);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.labelControl1);
            this.IconOptions.Image = global::PhongKham.Properties.Resources._3358576;
            this.Name = "frmChiTietToaThuoc";
            this.Text = "Chi tiết toa thuốc";
            this.Load += new System.EventHandler(this.frmChiTietToaThuoc_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbThuoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietToaThuoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripSave;
        private System.Windows.Forms.ToolStripButton toolStripDelete;
        private System.Windows.Forms.ToolStripButton toolStripCancel;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox txtLieuDung;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.TextBox txtTenBenhNhan;
        private System.Windows.Forms.TextBox txtIdToaThuoc;
        private System.Windows.Forms.TextBox txtNgayKham;
        private System.Windows.Forms.TextBox txtBenhDuocChanDOan;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private System.Windows.Forms.NumericUpDown txtSoLuong;
        public System.Windows.Forms.DataGridView dgvChiTietToaThuoc;
        private DevExpress.XtraEditors.SearchLookUpEdit cbThuoc;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
    }
}