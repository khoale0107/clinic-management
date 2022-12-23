using DevExpress.XtraEditors;
using PhongKham.Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhongKham.Forms_DE
{
    public partial class frmThuoc : DevExpress.XtraEditors.XtraForm
    {
        public frmThuoc()
        {
            InitializeComponent();
        }

        private void frmThuoc_Load(object sender, EventArgs e)
        {
            loadData();
            toolStripDelete.Enabled = false;
        }

        void loadData()
        {
            using (var context = new PhongKhamEntities())
            {
                var tThuocs = context.tThuocs.ToList();

                DataTable table = new DataTable();
                table.Columns.Add("ID", typeof(int));
                table.Columns.Add("Tên thuốc", typeof(string));
                table.Columns.Add("Nước sản xuất", typeof(string));
                table.Columns.Add("Đơn giá", typeof(string));
                table.Columns.Add("Hạn sử dụng", typeof(string));
                table.Columns.Add("Ghi chú", typeof(string));

                foreach (var t in tThuocs)
                {
                    table.Rows.Add(t.MaThuoc, t.TenThuoc, t.NuocSX, Utilities.toCurrency((int)t.DonGia), t.HanSuDung, t.GhiChu);
                }

                dgvThuoc.DataSource = table;
            }
        }

        private void dgvThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex == dgvThuoc.Rows.Count - 1)
            {
                //Chống lỗi khi nhấn vào tên cột (hàng trên cùng) hoặc hàng rỗng dưới cùng
                return;
            }

            //DataGridViewRow row = dgvBenhNhan.Rows[dgvBenhNhan.SelectedCells[0].RowIndex];
            DataGridViewRow row = dgvThuoc.Rows[e.RowIndex];
            string gia = row.Cells[3].Value.ToString();

            //fill fields
            txtIDThuoc.Text = row.Cells[0].Value.ToString();
            txtTenThuoc.Text = row.Cells[1].Value.ToString();
            txtNuocSX.Text = row.Cells[2].Value.ToString();
            txtGia.Value = Convert.ToDecimal(Regex.Replace(gia, @"\D", ""));
            txtHanSuDung.Text = row.Cells[4].Value.ToString();
            txtGhiChu.Text = row.Cells[5].Value.ToString();

            //enable controls
            toolStripDelete.Enabled = true;
        }

        //########################## ADD ###################################
        public void ThemThuoc()
        {
            //Kiểm tra empty input
            if (string.IsNullOrEmpty(txtTenThuoc.Text) ||
                string.IsNullOrEmpty(txtNuocSX.Text) ||
                string.IsNullOrEmpty(txtGia.Value.ToString()) ||
                string.IsNullOrEmpty(txtHanSuDung.Text) ||
                string.IsNullOrEmpty(txtGhiChu.Text))
            {
                MessageBox.Show("Hãy nhập đủ thông tin 222");
                return;
            }

            var thuoc = new tThuoc
            {
                TenThuoc = txtTenThuoc.Text,
                NuocSX = txtNuocSX.Text,
                GhiChu = txtGhiChu.Text,
                HanSuDung = txtHanSuDung.Text,
                DonGia = (int)txtGia.Value,
            };

            //Thêm bệnh nhân
            using (var context = new PhongKhamEntities())
            {
                context.tThuocs.Add(thuoc);
                context.SaveChanges();
            }

            loadData();

            Utilities.selectDgvRow(dgvThuoc, thuoc.MaThuoc.ToString());
            MessageBox.Show("Thêm thuốc thành công.");
        }

        //########################## UPDATE ###################################
        void CapNhatThuoc()
        {
            //Kiểm tra empty input
            if (string.IsNullOrEmpty(txtTenThuoc.Text) ||
                string.IsNullOrEmpty(txtNuocSX.Text) ||
                string.IsNullOrEmpty(txtGia.Value.ToString()) ||
                string.IsNullOrEmpty(txtHanSuDung.Text) ||
                string.IsNullOrEmpty(txtGhiChu.Text))
            {
                MessageBox.Show("Hãy nhập đủ thông tin");
                return;
            }

            //Cập nhật thuốc
            using (var context = new PhongKhamEntities())
            {
                var thuoc = context.tThuocs.FirstOrDefault(x => x.MaThuoc.ToString() == txtIDThuoc.Text);
                thuoc.TenThuoc = txtTenThuoc.Text;
                thuoc.NuocSX = txtNuocSX.Text;
                thuoc.GhiChu = txtGhiChu.Text;
                thuoc.HanSuDung = txtHanSuDung.Text;
                thuoc.DonGia = (int)txtGia.Value;
                context.SaveChanges();
            }

            loadData();
            Utilities.selectDgvRow(dgvThuoc, txtIDThuoc.Text);
            MessageBox.Show("Cập nhật " + txtTenThuoc.Text + " thành công.");
        }

        private void toolStripSave_Click(object sender, EventArgs e)
        {
            if (txtIDThuoc.Text.Length == 0)
                ThemThuoc();
            else
                CapNhatThuoc();
        }

        //########################## Cancel ###################################
        private void toolStripCancel_Click(object sender, EventArgs e)
        {
            txtIDThuoc.Text = "";
            txtNuocSX.Text = "";
            txtTenThuoc.Text = "";
            txtHanSuDung.Text = "";
            txtGhiChu.Text = "";
            txtGia.Value = 1000;

            toolStripDelete.Enabled = false;
        }


        //########################## DElete ###################################
        private void toolStripDelete_Click(object sender, EventArgs e)
        {
            //using (var context = new PhongKhamEntities())
            //{
            //    var stub = new tThuoc { MaThuoc = Convert.ToInt32(txtIDThuoc.Text) };
            //    context.tThuocs.Attach(stub);
            //    context.tThuocs.Remove(stub);
            //    context.SaveChanges();
            //}

            var context = new PhongKhamEntities();

            int maThuoc = int.Parse(txtIDThuoc.Text);

            var thuoc = context.tThuocs
                .Where(r => r.MaThuoc == maThuoc)
                .Include(r => r.tChiTietToaThuocs)
                .FirstOrDefault();

            context.tThuocs.Remove(thuoc);
            context.SaveChanges();

            MessageBox.Show("Đã xóa " + txtTenThuoc.Text);
            toolStripDelete.Enabled = false;
            toolStripCancel.PerformClick();
            loadData();
        }
    }
}