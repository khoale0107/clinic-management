namespace PhongKham.Forms_DE
{
    partial class frmTimBenhNhan
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
            this.dgvBenhNhan = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBenhNhan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBenhNhan
            // 
            this.dgvBenhNhan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBenhNhan.Location = new System.Drawing.Point(0, 0);
            this.dgvBenhNhan.MainView = this.gridView1;
            this.dgvBenhNhan.Name = "dgvBenhNhan";
            this.dgvBenhNhan.Size = new System.Drawing.Size(1137, 620);
            this.dgvBenhNhan.TabIndex = 0;
            this.dgvBenhNhan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.dgvBenhNhan;
            this.gridView1.Name = "gridView1";
            // 
            // frmTimBenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 620);
            this.Controls.Add(this.dgvBenhNhan);
            this.IconOptions.Image = global::PhongKham.Properties.Resources._3358576;
            this.Name = "frmTimBenhNhan";
            this.Text = "Tìm bệnh nhân";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBenhNhan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgvBenhNhan;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}