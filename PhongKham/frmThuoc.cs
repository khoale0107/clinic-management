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

namespace PhongKham
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

            var thuoc = new tThuoc();

            thuoc.TenThuoc = txtTenThuoc.Text;
            thuoc.NuocSX = txtNuocSX.Text;
            thuoc.GhiChu = txtGhiChu.Text;
            thuoc.HanSuDung = txtHanSuDung.Text;
            thuoc.DonGia = (int)txtGia.Value;

            //Thêm thuốc
            DataModule.db.tThuocs.Add(thuoc);
            DataModule.db.SaveChanges();

            MessageBox.Show("Thêm thuốc thành công.");
            loadData();
        }

        void loadData()
        {
            var query = from row in DataModule.db.tThuocs
                        select new
                         {
                             TenThuoc = row.TenThuoc,
                             NuocSX = row.NuocSX,
                             Gia = row.DonGia,
                             HanSuDung = row.HanSuDung,
                             GhiChu = row.GhiChu
                         };

            dgvThuoc.DataSource = query.ToList();
        }

        string toCurrency(int price)
        {
            return price.ToString("0,# đ");
        }
    }
}
