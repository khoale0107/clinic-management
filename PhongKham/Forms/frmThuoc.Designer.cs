namespace PhongKham.Forms
{
    partial class frmThuoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThuoc));
            this.dgvThuoc = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenThuoc = new System.Windows.Forms.TextBox();
            this.txtNuocSX = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.NumericUpDown();
            this.txtHanSuDung = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnThemThuoc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGia)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvThuoc
            // 
            this.dgvThuoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvThuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThuoc.Location = new System.Drawing.Point(317, 98);
            this.dgvThuoc.Name = "dgvThuoc";
            this.dgvThuoc.RowHeadersWidth = 51;
            this.dgvThuoc.RowTemplate.Height = 24;
            this.dgvThuoc.Size = new System.Drawing.Size(577, 340);
            this.dgvThuoc.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh mục thuốc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên thuốc:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nước sản xuất:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Giá:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtTenThuoc
            // 
            this.txtTenThuoc.Location = new System.Drawing.Point(134, 98);
            this.txtTenThuoc.Name = "txtTenThuoc";
            this.txtTenThuoc.Size = new System.Drawing.Size(162, 22);
            this.txtTenThuoc.TabIndex = 5;
            // 
            // txtNuocSX
            // 
            this.txtNuocSX.Location = new System.Drawing.Point(134, 126);
            this.txtNuocSX.Name = "txtNuocSX";
            this.txtNuocSX.Size = new System.Drawing.Size(162, 22);
            this.txtNuocSX.TabIndex = 6;
            // 
            // txtGia
            // 
            this.txtGia.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtGia.Location = new System.Drawing.Point(134, 154);
            this.txtGia.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(120, 22);
            this.txtGia.TabIndex = 8;
            this.txtGia.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtGia.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // txtHanSuDung
            // 
            this.txtHanSuDung.Location = new System.Drawing.Point(134, 182);
            this.txtHanSuDung.Name = "txtHanSuDung";
            this.txtHanSuDung.Size = new System.Drawing.Size(162, 22);
            this.txtHanSuDung.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Hạn sử dụng:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(134, 210);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(162, 22);
            this.txtGhiChu.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ghi chú:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnThemThuoc
            // 
            this.btnThemThuoc.Location = new System.Drawing.Point(134, 256);
            this.btnThemThuoc.Name = "btnThemThuoc";
            this.btnThemThuoc.Size = new System.Drawing.Size(79, 35);
            this.btnThemThuoc.TabIndex = 13;
            this.btnThemThuoc.Text = "Thêm";
            this.btnThemThuoc.UseVisualStyleBackColor = true;
            this.btnThemThuoc.Click += new System.EventHandler(this.btnThemThuoc_Click);
            // 
            // frmThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 450);
            this.Controls.Add(this.btnThemThuoc);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtHanSuDung);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtNuocSX);
            this.Controls.Add(this.txtTenThuoc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvThuoc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmThuoc";
            this.Text = "Danh mục thuốc";
            this.Load += new System.EventHandler(this.frmThuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvThuoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenThuoc;
        private System.Windows.Forms.TextBox txtNuocSX;
        private System.Windows.Forms.NumericUpDown txtGia;
        private System.Windows.Forms.TextBox txtHanSuDung;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnThemThuoc;
    }
}