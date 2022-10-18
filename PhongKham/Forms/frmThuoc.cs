using PhongKham.Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhongKham.Forms
{
    public partial class frmThuoc : Form
    {
        public frmThuoc()
        {
            InitializeComponent();
        }

        private void frmThuoc_Load(object sender, EventArgs e)
        {
            loadData();
            setupControls();
        }
        public void setupControls()
        {
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
                    table.Rows.Add(t.MaThuoc, t.TenThuoc, t.NuocSX, toCurrency((int) t.DonGia), t.HanSuDung, t.GhiChu);
                }

                dgvThuoc.DataSource = table;
            }
        }
        string toCurrency(int price)
        {
            return price.ToString("0,# đ");
        }

        private void toolStripSave_Click(object sender, EventArgs e)
        {
            if (txtIDThuoc.Text.Length == 0)
            {
                ThemThuoc();
            }
            else
            {
                MessageBox.Show("cap nhat thuoc thanh cong");
            }
        }

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

            MessageBox.Show("Thêm thuốc thành công.");
            loadData();
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

            txtIDThuoc.Text = row.Cells[0].Value.ToString();
            txtTenThuoc.Text = row.Cells[1].Value.ToString();
            txtNuocSX.Text = row.Cells[2].Value.ToString();
            txtGia.Value = Convert.ToDecimal(Regex.Replace(gia, @"\D", ""));
            txtHanSuDung.Text = row.Cells[4].Value.ToString();
            txtGhiChu.Text = row.Cells[5].Value.ToString();

            //enable controls
            toolStripDelete.Enabled = true;
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

        private void toolStripDelete_Click(object sender, EventArgs e)
        {
            using (var context = new PhongKhamEntities())
            {
                var stub = new tThuoc{ MaThuoc = Convert.ToInt32(txtIDThuoc.Text) };
                context.tThuocs.Attach(stub);
                context.tThuocs.Remove(stub);
                context.SaveChanges();
            }

            MessageBox.Show("Đã xóa " + txtTenThuoc.Text);
            toolStripDelete.Enabled = false;
            toolStripCancel.PerformClick();
            loadData();
        }
    }
}
