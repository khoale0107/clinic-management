using DevExpress.XtraEditors;
using PhongKham.Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace PhongKham.Forms_DE
{
    public partial class frmToaThuoc : DevExpress.XtraEditors.XtraForm
    {
        public frmToaThuoc()
        {
            InitializeComponent();
        }

        private void frmToaThuoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phongKhamDataSet.tToaThuoc' table. You can move, or remove it, as needed.
            toolStripDelete.Enabled = false;
            btnEditChiTietToaThuoc.Enabled = false;
            dtNgayKham.EditValue = DateTime.Now;
            txtIdToaThuoc.Properties.ReadOnly = true;
            lookUpEdit1.EditValue = "";
            //lookUpEdit1.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSuggest;


            loadData();
            loadCombobox();
        }

        void loadCombobox()
        {
            var tbenhNhans = new PhongKhamEntities().tBenhNhans.ToList();

            DataTable table = new DataTable();
            table.Columns.Add("Mã bệnh nhân", typeof(string));
            table.Columns.Add("Tên bệnh nhân", typeof(string));
            table.Columns.Add("Tuổi", typeof(string));

            foreach (var r in tbenhNhans)
            {
                table.Rows.Add(r.MaBenhNhan, r.TenBenhNhan, r.Tuoi);
            }

            lookUpEdit1.Properties.DisplayMember = "Tên bệnh nhân";
            lookUpEdit1.Properties.ValueMember = "Mã bệnh nhân";
            
            lookUpEdit1.Properties.DataSource = table;
        }

        void loadData()
        {
            using (var context = new PhongKhamEntities())
            {
                var tToaThuocs = from t in context.tToaThuocs
                                 select t;


                DataTable table = new DataTable();
                table.Columns.Add("STT toa thuốc", typeof(int));
                table.Columns.Add("Bệnh nhân", typeof(string));
                table.Columns.Add("Bệnh được chẩn đoán", typeof(string));
                table.Columns.Add("Ngày khám", typeof(string));
                table.Columns.Add("Mã bệnh nhân", typeof(string));

                foreach (var t in tToaThuocs)
                {
                    string ngaykham = ((DateTime)t.NgayKham).ToString("MMMM dd yyyy");
                    table.Rows.Add(t.STT, t.tBenhNhan.TenBenhNhan, t.BenhDuocChanDoan, ngaykham, t.tBenhNhan.MaBenhNhan);
                }

                dgvToaThuoc.DataSource = table;

            }
        }


        //####################  CELL CLICK #################################################
        private void dgvToaThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex == dgvToaThuoc.Rows.Count - 1)
            {
                //Chống lỗi khi nhấn vào tên cột (hàng trên cùng), hàng rỗng dưới cùng
                return;
            }

            btnEditChiTietToaThuoc.Enabled = true;

            //DataGridViewRow row = dgvBenhNhan.Rows[dgvBenhNhan.SelectedCells[0].RowIndex];
            DataGridViewRow row = dgvToaThuoc.Rows[e.RowIndex];
            string gia = row.Cells[3].Value.ToString();
            string idToaThuoc = row.Cells[0].Value.ToString();

            txtIdToaThuoc.Text = idToaThuoc;
            lookUpEdit1.EditValue = row.Cells[4].Value.ToString();
            txtBenhDuocChanDoan.Text = row.Cells[2].Value.ToString();
            dtNgayKham.EditValue = DateTime.Parse(row.Cells[3].Value.ToString());

            //enable controls
            toolStripDelete.Enabled = true;

            //load tChiTietToaThuocs
            loadChiTietToaThuoc();

        }

        private void loadChiTietToaThuoc()
        {
            var db = new PhongKhamEntities();
            var tChiTietToaThuocs = from record in db.tChiTietToaThuocs
                                    where record.STT.ToString() == txtIdToaThuoc.Text.ToString()
                                    select record;

            DataTable table = new DataTable();
            table.Columns.Add("Thuốc", typeof(string));
            table.Columns.Add("Số lượng", typeof(string));
            table.Columns.Add("Liều dùng", typeof(string));

            foreach (var r in tChiTietToaThuocs)
            {
                table.Rows.Add(r.tThuoc.TenThuoc, r.SoLuong, r.LieuDung);
            }

            dgvChiTietToaThuoc.DataSource = table;
        }

        // ################################## SAVE #######################################
        private void toolStripSave_Click(object sender, EventArgs e)
        {
            if (txtIdToaThuoc.Text.Length == 0)
                themToatThuoc();
            else
                capNhatToaThuoc();
        }

        // ################################## CANCEL #######################################
        private void toolStripCancel_Click(object sender, EventArgs e)
        {
            txtIdToaThuoc.Text = "";
            txtBenhDuocChanDoan.Text = "";
            dtNgayKham.EditValue = DateTime.Now;
            toolStripDelete.Enabled = false;
            dgvChiTietToaThuoc.DataSource = null;
            btnEditChiTietToaThuoc.Enabled = false;
            lookUpEdit1.EditValue = "";
        }

        // ################################## DELETE #######################################
        private void toolStripDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa?", "Xóa tóa thuốc", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                using (var context = new PhongKhamEntities())
                {
                    var stub = new tToaThuoc { STT = Convert.ToInt32(txtIdToaThuoc.Text) };
                    context.tToaThuocs.Attach(stub);
                    context.tToaThuocs.Remove(stub);
                    context.SaveChanges();
                }

                MessageBox.Show("Đã xóa toa thuốc" + txtIdToaThuoc.Text);
                toolStripDelete.Enabled = false;
                toolStripCancel.PerformClick();
                loadData();
            }
            else if (dialogResult == DialogResult.No) {}
        }

        // ################################## ADD #######################################
        void themToatThuoc()
        {
            if (txtBenhDuocChanDoan.Text.Length == 0)
            {
                MessageBox.Show("Hãy nhập đủ thông tin.");
                return;
            }

            if (lookUpEdit1.EditValue == "")
            {
                MessageBox.Show("Hãy chọn bệnh nhân.");
                return;
            }

            tToaThuoc toaThuoc = new tToaThuoc
            {
                BenhDuocChanDoan = txtBenhDuocChanDoan.Text,
                //BenhNhan = cbBenhNhan.SelectedValue.ToString(),
                BenhNhan = lookUpEdit1.EditValue.ToString(),
                NgayKham = (DateTime)dtNgayKham.EditValue,
            };

            using (var context = new PhongKhamEntities())
            {
                context.tToaThuocs.Add(toaThuoc);
                context.SaveChanges();
            }

            toolStripCancel.PerformClick();
            Utilities.selectDgvRow(dgvToaThuoc, txtIdToaThuoc.Text);
            MessageBox.Show("Thêm toa thuốc thành công");
            loadData();
        }

        // ################################## UPDATE #######################################
        void capNhatToaThuoc()
        {
            if (txtBenhDuocChanDoan.Text.Length == 0)
            {
                MessageBox.Show("Hãy nhập đủ thông tin.");
                return;
            }

            if (lookUpEdit1.EditValue == "")
            {
                MessageBox.Show("Hãy chọn bệnh nhân.");
                return;
            }

            using (var context = new PhongKhamEntities())
            {
                var toaThuoc = context.tToaThuocs.FirstOrDefault(x => x.STT.ToString() == txtIdToaThuoc.Text);
                toaThuoc.BenhDuocChanDoan = txtBenhDuocChanDoan.Text;
                //toaThuoc.BenhNhan = cbBenhNhan.SelectedValue.ToString();
                toaThuoc.BenhNhan = lookUpEdit1.EditValue.ToString();
                toaThuoc.NgayKham = (DateTime)dtNgayKham.EditValue;
                context.SaveChanges();
            }

            loadData();
            Utilities.selectDgvRow(dgvToaThuoc, txtIdToaThuoc.Text);
            MessageBox.Show("Cập nhật toa thuốc thành công");
        }



        //######################### CHI TIET CLICK
        private void btnEditChiTietToaThuoc_Click(object sender, EventArgs e)
        {
            frmChiTietToaThuoc frm = new frmChiTietToaThuoc(this);
            frm.ShowDialog();
        }

    }
}