using PhongKham.Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnThemThuoc_Click(object sender, EventArgs e)
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


            var thuoc = new tThuoc
            {
                TenThuoc = txtTenThuoc.Text,
                NuocSX = txtNuocSX.Text,
                GhiChu = txtGhiChu.Text,
                HanSuDung = txtHanSuDung.Text,
                DonGia = (int?)txtGia.Value,
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
                    table.Rows.Add(t.MaThuoc, t.TenThuoc, t.NuocSX, toCurrency((int)t.DonGia), t.HanSuDung, t.GhiChu);
                }

                dgvThuoc.DataSource = table;
            }
        }

        string toCurrency(int price)
        {
            return price.ToString("0,# đ");
        }
    }
}
