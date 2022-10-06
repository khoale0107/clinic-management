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
            configLayout();
        }
        void configLayout()
        {
            btnDeleteBN.Enabled = false;
            btnEditBN.Enabled = false;
        }

        void loadData()
        {
            using (var context = new PhongKhamEntities())
            {
                var tBenhNhans = context.tBenhNhans.ToList();

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

        //################### Them benh nhan ###############################
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

        //######################## Xoa benh nhan ###############################
        private void btnDeleteBN_Click(object sender, EventArgs e)
        {
            using (var context = new PhongKhamEntities())
            {
                var stub = new tBenhNhan { MaBenhNhan = txtIdBN.Text };
                context.tBenhNhans.Attach(stub);
                context.tBenhNhans.Remove(stub);
                context.SaveChanges();
            }

            MessageBox.Show("Đã xóa " + txtTenBenhNhan.Text);
            btnDeleteBN.Enabled = false;
            loadData();
        }

        private void dgvBenhNhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex == dgvBenhNhan.Rows.Count - 1) {
                //Chống lỗi khi nhấn vào tên cột (hàng trên cùng) hoặc hàng rỗng dưới cùng
                return;
            }
            //DataGridViewRow row = dgvBenhNhan.Rows[dgvBenhNhan.SelectedCells[0].RowIndex];
            DataGridViewRow row = dgvBenhNhan.Rows[e.RowIndex];

            if (dgvBenhNhan.SelectedCells.Count == 0)
            {
                //chống lỗi khi nhấn Ctrl + click liên tiếp vào 1 cell hoặc cell rỗng cuối bảng
                return;
            }

            txtIdBN.Text = row.Cells[0].Value.ToString();
            txtTenBenhNhan.Text = row.Cells[1].Value.ToString();
            txtTuoi.Value = Convert.ToDecimal(row.Cells[2].Value);
            txtDiaChi.Text = row.Cells[4].Value.ToString();

            if (row.Cells[3].Value.ToString() == "Nam")
                radioNam.Checked = true;
            else
                radioNu.Checked = true;

            btnDeleteBN.Enabled = true;
            btnEditBN.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtIdBN.Text = "";
            txtDiaChi.Text = "";
            txtTenBenhNhan.Text = "";
            txtTuoi.Value = 0;
            radioNam.Checked = true;

            btnDeleteBN.Enabled = false;
        }
    }
}
