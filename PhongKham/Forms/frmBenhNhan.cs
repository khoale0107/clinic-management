using PhongKham.Modules;
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

        //################### CLICK ###############################
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

        //################### ADD or UPDATE ###############################
        private void toolStripSave_Click(object sender, EventArgs e)
        {
            if (txtIdBN.Text.Length == 0)
                ThemBenhNhan();
            else
                CapNhatBenhNhan();
        }


        //######################## DELETE ###############################
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
            txtTuoi.Value = 1;
            radioNam.Checked = true;

            toolStripDelete.Enabled = false;
        }

        //################### ADD ###############################
        public void ThemBenhNhan()
        {
            //Kiểm tra empty input
            if (string.IsNullOrEmpty(txtTenBenhNhan.Text))
            {
                MessageBox.Show("Hãy nhập tên bệnh nhân.");
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

            toolStripCancel.PerformClick();
            loadData();

            //Select added row
            Utilities.selectDgvRow(dgvBenhNhan, maBenhNhan);
            MessageBox.Show("Thêm bệnh nhân thành công.");
        }

        //################### UPDATE ###############################
        void CapNhatBenhNhan()
        {
            //Kiểm tra empty input
            if (string.IsNullOrEmpty(txtTenBenhNhan.Text))
            {
                MessageBox.Show("Hãy nhập tên bệnh nhân");
                return;
            }

            using (var context = new PhongKhamEntities())
            {
                var benhNhan = context.tBenhNhans.FirstOrDefault(x => x.MaBenhNhan == txtIdBN.Text); ;
                benhNhan.MaBenhNhan = txtIdBN.Text;
                benhNhan.TenBenhNhan = txtTenBenhNhan.Text;
                benhNhan.Tuoi = (byte)txtTuoi.Value;
                benhNhan.GioiTinh = radioNam.Checked == true ? radioNam.Text : radioNu.Text;
                benhNhan.DiaChi = txtDiaChi.Text;
                context.SaveChanges();
            }

            loadData();

            //Select updated row
            Utilities.selectDgvRow(dgvBenhNhan, txtIdBN.Text);
            MessageBox.Show("Cập nhật bệnh nhân thành công.");
        }
    }
}
