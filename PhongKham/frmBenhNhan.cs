using PhongKham.Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhongKham
{
    public partial class frmBenhNhan : Form
    {
        public frmBenhNhan()
        {
            InitializeComponent();
        }

        private void frmBenhNhan_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnThemBN_Click(object sender, EventArgs e)
        {
            //Kiểm tra empty input
            if (string.IsNullOrEmpty(txtTenBenhNhan.Text) ||
                string.IsNullOrEmpty(txtTuoi.Value.ToString()))
            {
                MessageBox.Show("Hãy nhập đủ thông tin");
                return;
            }

            var benhNhan = new tBenhNhan();

            //Tạo mã bệnh nhân
            var rand = new Random();
            var maBenhNhan = rand.NextDouble().ToString().Substring(2, 6);
            
            benhNhan.MaBenhNhan = maBenhNhan;
            benhNhan.TenBenhNhan = txtTenBenhNhan.Text;
            benhNhan.Tuoi = (byte) txtTuoi.Value;
            benhNhan.GioiTinh = radioNam.Checked == true ? radioNam.Text : radioNu.Text;
            benhNhan.DiaChi = txtDiaChi.Text;

            //Thêm bệnh nhân
            DataModule.db.tBenhNhans.Add(benhNhan);
            DataModule.db.SaveChanges();

            MessageBox.Show("Thêm bệnh nhân thành công.");
            loadData();
        }

        void loadData()
        {
            var ketqua = from benhNhan in DataModule.db.tBenhNhans
                         select new
                         {
                             MaBenhNhan = benhNhan.MaBenhNhan,
                             TenBenhNhan = benhNhan.TenBenhNhan,
                             Tuoi = benhNhan.Tuoi,
                             GioiTinh = benhNhan.GioiTinh,
                             DiaChi = benhNhan.DiaChi
                         };

            dgvBenhNhan.DataSource = ketqua.ToList();
        }
    }
}
