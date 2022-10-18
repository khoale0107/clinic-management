using System;
using System.Data;
using System.Linq;
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
            setupControls();
        }
        void setupControls()
        {
            toolStripDelete.Enabled = false;
        }

        void loadData()
        {
            using (var context = new PhongKhamEntities())
            {
                var tBenhNhans = from t in  context.tBenhNhans
                                 orderby t.TenBenhNhan
                                 select t;

                DataTable table = new DataTable();
                table.Columns.Add("ID", typeof(string));
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



            //var ketqua = from benhNhan in new PhongKhamEntities().tBenhNhans
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



        private void dgvBenhNhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex == dgvBenhNhan.Rows.Count - 1) {
                //Chống lỗi khi nhấn vào tên cột (hàng trên cùng) hoặc hàng rỗng dưới cùng
                return;
            }
            //DataGridViewRow row = dgvBenhNhan.Rows[dgvBenhNhan.SelectedCells[0].RowIndex];
            DataGridViewRow row = dgvBenhNhan.Rows[e.RowIndex];

            txtIdBN.Text = row.Cells[0].Value.ToString();
            txtTenBenhNhan.Text = row.Cells[1].Value.ToString();
            txtTuoi.Value = Convert.ToDecimal(row.Cells[2].Value);
            txtDiaChi.Text = row.Cells[4].Value.ToString();

            if (row.Cells[3].Value.ToString() == "Nam")
                radioNam.Checked = true;
            else
                radioNu.Checked = true;

            //enable controls
            toolStripDelete.Enabled = true;
        }


        //################### Them benh nhan ###############################
        private void toolStripSave_Click(object sender, EventArgs e)
        {
            if (txtIdBN.Text.Length == 0)
            {
                ThemBenhNhan();
            }
            else
            {
                MessageBox.Show("cập nhật thành công");
            }
            
        }


        //######################## Xoa benh nhan ###############################
        private void toolStripDelete_Click(object sender, EventArgs e)
        {
            using (var context = new PhongKhamEntities())
            {
                var stub = new tBenhNhan { MaBenhNhan = txtIdBN.Text };
                context.tBenhNhans.Attach(stub);
                context.tBenhNhans.Remove(stub);
                context.SaveChanges();
            }

            MessageBox.Show("Đã xóa " + txtTenBenhNhan.Text);
            toolStripDelete.Enabled = false;
            toolStripCancel.PerformClick();
            loadData();
        }

        //################### Cancel ###############################
        private void toolStripCancel_Click(object sender, EventArgs e)
        {
            txtIdBN.Text = "";
            txtDiaChi.Text = "";
            txtTenBenhNhan.Text = "";
            txtTuoi.Value = 0;
            radioNam.Checked = true;

            toolStripDelete.Enabled = false;
        }


        //################### Them benh nhan ###############################
        public void ThemBenhNhan()
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
            var benhNhan = new tBenhNhan
            {
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
            toolStripCancel.PerformClick();
            loadData();

            //Select row added
            foreach (DataGridViewRow row in dgvBenhNhan.Rows)
            {
                if (row.Cells[0].Value.ToString() == maBenhNhan)
                {
                    row.Selected = true;
                    break;
                }
            }
        }

    }
}
