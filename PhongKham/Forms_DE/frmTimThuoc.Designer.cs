namespace PhongKham.Forms_DE
{
    partial class frmTimThuoc
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
            this.dgvThuoc = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvThuoc
            // 
            this.dgvThuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThuoc.Location = new System.Drawing.Point(0, 0);
            this.dgvThuoc.MainView = this.gridView1;
            this.dgvThuoc.Name = "dgvThuoc";
            this.dgvThuoc.Size = new System.Drawing.Size(1154, 678);
            this.dgvThuoc.TabIndex = 1;
            this.dgvThuoc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.dgvThuoc;
            this.gridView1.Name = "gridView1";
            // 
            // frmTimThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 678);
            this.Controls.Add(this.dgvThuoc);
            this.IconOptions.Image = global::PhongKham.Properties.Resources._3358576;
            this.Name = "frmTimThuoc";
            this.Text = "Tìm kiếm thuốc";
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgvThuoc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}