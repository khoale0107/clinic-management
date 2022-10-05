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

namespace PhongKham.Forms
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

            //Tạo mã bệnh nhân
            var rand = new Random();
            var maBenhNhan = rand.NextDouble().ToString().Substring(2, 6);
            var benhNhan = new tBenhNhan {
                MaBenhNhan = maBenhNhan,
                TenBenhNhan = txtTenBenhNhan.Text,
                Tuoi = (byte)txtTuoi.Value,
                GioiTinh = radioNam.Checked == true ? radioNam.Text : radioNu.Text,
                DiaChi = txtDiaChi.Text,
            };

            //Thêm bệnh nhân
            using (var context = new PhongKhamEntities())
            {
                context.tBenhNhans.Add(benhNhan);
                context.SaveChanges();
            }

            MessageBox.Show("Thêm bệnh nhân thành công.");
            loadData();
        }

        void loadData()
        {
            using (var context = new PhongKhamEntities())
            {
                var tBenhNhans = context.tBenhNhans.ToList();

                DataTable table = new DataTable();
                table.Columns.Add("ID", typeof(int));
                table.Columns.Add("Tên bệnh nhân", typeof(string));
                table.Columns.Add("Tuổi", typeof(byte));
                table.Columns.Add("Giới tính", typeof(string));
                table.Columns.Add("Địa chỉ", typeof(string));

                foreach (var t in tBenhNhans)
                {
                    table.Rows.Add(t.MaBenhNhan, t.TenBenhNhan, t.Tuoi, t.GioiTinh, t.DiaChi);
                }

                dgvBenhNhan.DataSource = table;
            }

            //var ketqua = from benhNhan in DataModule.db.tBenhNhans
            //             select new
            //             {
            //                 MaBenhNhan = benhNhan.MaBenhNhan,
            //                 TenBenhNhan = benhNhan.TenBenhNhan,
            //                 Tuoi = benhNhan.Tuoi,
            //                 GioiTinh = benhNhan.GioiTinh,
            //                 DiaChi = benhNhan.DiaChi
            //             };
            //dgvBenhNhan.DataSource = ketqua.ToList();
        }
    }
}
