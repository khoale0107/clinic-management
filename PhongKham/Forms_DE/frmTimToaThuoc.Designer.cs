namespace PhongKham.Forms_DE
{
    partial class frmTimToaThuoc
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
            this.dgvToaThuoc = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToaThuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvToaThuoc
            // 
            this.dgvToaThuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvToaThuoc.Location = new System.Drawing.Point(0, 0);
            this.dgvToaThuoc.MainView = this.gridView1;
            this.dgvToaThuoc.Name = "dgvToaThuoc";
            this.dgvToaThuoc.Size = new System.Drawing.Size(1111, 459);
            this.dgvToaThuoc.TabIndex = 0;
            this.dgvToaThuoc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.dgvToaThuoc;
            this.gridView1.Name = "gridView1";
            // 
            // frmTimToaThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 459);
            this.Controls.Add(this.dgvToaThuoc);
            this.IconOptions.Image = global::PhongKham.Properties.Resources._3358576;
            this.Name = "frmTimToaThuoc";
            this.Text = "Tìm toa thuốc";
            ((System.ComponentModel.ISupportInitialize)(this.dgvToaThuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgvToaThuoc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}