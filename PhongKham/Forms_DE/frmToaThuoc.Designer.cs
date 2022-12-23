namespace PhongKham.Forms_DE
{
    partial class frmToaThuoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmToaThuoc));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripCancel = new System.Windows.Forms.ToolStripButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtNgayKham = new DevExpress.XtraEditors.DateEdit();
            this.txtIdToaThuoc = new DevExpress.XtraEditors.TextEdit();
            this.txtBenhDuocChanDoan = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEditChiTietToaThuoc = new DevExpress.XtraEditors.SimpleButton();
            this.dgvChiTietToaThuoc = new System.Windows.Forms.DataGridView();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dgvToaThuoc = new System.Windows.Forms.DataGridView();
            this.phongKhamDataSet = new PhongKham.PhongKhamDataSet();
            this.tToaThuocTableAdapter = new PhongKham.PhongKhamDataSetTableAdapters.tToaThuocTableAdapter();
            this.cbBenhNhan = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayKham.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayKham.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdToaThuoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBenhDuocChanDoan.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietToaThuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToaThuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongKhamDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbBenhNhan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(1113, 27);
            this.toolStrip1.TabIndex = 6;
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
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.groupBox2);
            this.groupControl1.Controls.Add(this.groupBox1);
            this.groupControl1.Location = new System.Drawing.Point(13, 40);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1091, 306);
            this.groupControl1.TabIndex = 7;
            this.groupControl1.Text = "Thông tin toa thuốc";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbBenhNhan);
            this.groupBox2.Controls.Add(this.dtNgayKham);
            this.groupBox2.Controls.Add(this.txtIdToaThuoc);
            this.groupBox2.Controls.Add(this.txtBenhDuocChanDoan);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(6, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(436, 268);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chung";
            // 
            // dtNgayKham
            // 
            this.dtNgayKham.EditValue = null;
            this.dtNgayKham.Location = new System.Drawing.Point(119, 132);
            this.dtNgayKham.Name = "dtNgayKham";
            this.dtNgayKham.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgayKham.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgayKham.Size = new System.Drawing.Size(284, 22);
            this.dtNgayKham.TabIndex = 30;
            // 
            // txtIdToaThuoc
            // 
            this.txtIdToaThuoc.Location = new System.Drawing.Point(119, 32);
            this.txtIdToaThuoc.Name = "txtIdToaThuoc";
            this.txtIdToaThuoc.Size = new System.Drawing.Size(284, 22);
            this.txtIdToaThuoc.TabIndex = 29;
            // 
            // txtBenhDuocChanDoan
            // 
            this.txtBenhDuocChanDoan.Location = new System.Drawing.Point(119, 189);
            this.txtBenhDuocChanDoan.Name = "txtBenhDuocChanDoan";
            this.txtBenhDuocChanDoan.Size = new System.Drawing.Size(284, 22);
            this.txtBenhDuocChanDoan.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 135);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Ngày khám:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 184);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 32);
            this.label3.TabIndex = 21;
            this.label3.Text = "Bệnh được\r\nchẩn đoán:\r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 35);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "STT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Bệnh nhân:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnEditChiTietToaThuoc);
            this.groupBox1.Controls.Add(this.dgvChiTietToaThuoc);
            this.groupBox1.Location = new System.Drawing.Point(448, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(638, 268);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết toa thuốc";
            // 
            // btnEditChiTietToaThuoc
            // 
            this.btnEditChiTietToaThuoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditChiTietToaThuoc.Enabled = false;
            this.btnEditChiTietToaThuoc.Location = new System.Drawing.Point(527, 22);
            this.btnEditChiTietToaThuoc.Name = "btnEditChiTietToaThuoc";
            this.btnEditChiTietToaThuoc.Size = new System.Drawing.Size(104, 29);
            this.btnEditChiTietToaThuoc.TabIndex = 21;
            this.btnEditChiTietToaThuoc.Text = "Chi tiết";
            this.btnEditChiTietToaThuoc.Click += new System.EventHandler(this.btnEditChiTietToaThuoc_Click);
            // 
            // dgvChiTietToaThuoc
            // 
            this.dgvChiTietToaThuoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvChiTietToaThuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietToaThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietToaThuoc.Location = new System.Drawing.Point(7, 59);
            this.dgvChiTietToaThuoc.Margin = new System.Windows.Forms.Padding(4);
            this.dgvChiTietToaThuoc.Name = "dgvChiTietToaThuoc";
            this.dgvChiTietToaThuoc.ReadOnly = true;
            this.dgvChiTietToaThuoc.RowHeadersWidth = 51;
            this.dgvChiTietToaThuoc.RowTemplate.Height = 24;
            this.dgvChiTietToaThuoc.Size = new System.Drawing.Size(624, 209);
            this.dgvChiTietToaThuoc.TabIndex = 20;
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.dgvToaThuoc);
            this.groupControl2.Location = new System.Drawing.Point(13, 354);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1091, 364);
            this.groupControl2.TabIndex = 8;
            this.groupControl2.Text = "DANH SÁCH TOA THUỐC";
            // 
            // dgvToaThuoc
            // 
            this.dgvToaThuoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvToaThuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvToaThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvToaThuoc.Location = new System.Drawing.Point(6, 32);
            this.dgvToaThuoc.Margin = new System.Windows.Forms.Padding(4);
            this.dgvToaThuoc.Name = "dgvToaThuoc";
            this.dgvToaThuoc.ReadOnly = true;
            this.dgvToaThuoc.RowHeadersWidth = 51;
            this.dgvToaThuoc.RowTemplate.Height = 24;
            this.dgvToaThuoc.Size = new System.Drawing.Size(1079, 326);
            this.dgvToaThuoc.TabIndex = 20;
            this.dgvToaThuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvToaThuoc_CellClick);
            // 
            // phongKhamDataSet
            // 
            this.phongKhamDataSet.DataSetName = "PhongKhamDataSet";
            this.phongKhamDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tToaThuocTableAdapter
            // 
            this.tToaThuocTableAdapter.ClearBeforeFill = true;
            // 
            // cbBenhNhan
            // 
            this.cbBenhNhan.Location = new System.Drawing.Point(119, 80);
            this.cbBenhNhan.Name = "cbBenhNhan";
            this.cbBenhNhan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbBenhNhan.Properties.PopupView = this.searchLookUpEdit1View;
            this.cbBenhNhan.Size = new System.Drawing.Size(284, 22);
            this.cbBenhNhan.TabIndex = 46;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // frmToaThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 731);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.toolStrip1);
            this.IconOptions.Image = global::PhongKham.Properties.Resources._3358576;
            this.Name = "frmToaThuoc";
            this.Text = "Danh mục Toa Thuốc";
            this.Load += new System.EventHandler(this.frmToaThuoc_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayKham.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayKham.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdToaThuoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBenhDuocChanDoan.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietToaThuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvToaThuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongKhamDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbBenhNhan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.ToolStripButton toolStripSave;
        public System.Windows.Forms.ToolStripButton toolStripDelete;
        public System.Windows.Forms.ToolStripButton toolStripCancel;
        public DevExpress.XtraEditors.GroupControl groupControl1;
        public DevExpress.XtraEditors.GroupControl groupControl2;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.DataGridView dgvToaThuoc;
        public System.Windows.Forms.DataGridView dgvChiTietToaThuoc;
        public PhongKhamDataSet phongKhamDataSet;
        public System.Windows.Forms.GroupBox groupBox1;
        public PhongKhamDataSetTableAdapters.tToaThuocTableAdapter tToaThuocTableAdapter;
        public DevExpress.XtraEditors.SimpleButton btnEditChiTietToaThuoc;
        public System.Windows.Forms.GroupBox groupBox2;
        public DevExpress.XtraEditors.TextEdit txtBenhDuocChanDoan;
        public DevExpress.XtraEditors.TextEdit txtIdToaThuoc;
        public DevExpress.XtraEditors.DateEdit dtNgayKham;
        public DevExpress.XtraEditors.SearchLookUpEdit cbBenhNhan;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
    }
}