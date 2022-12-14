using DevExpress.XtraEditors;
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
            toolStripDelete.Enabled = false;
            loadData();
            loadCombobox();
        }

        void loadCombobox()
        {
            var tbenhNhans = new PhongKhamEntities().tBenhNhans.ToList();
            cbBenhNhan.DisplayMember = "TenBenhNhan";
            cbBenhNhan.ValueMember = "MaBenhNhan";
            cbBenhNhan.DataSource = tbenhNhans;
            cbBenhNhan.SelectedIndex = -1;
        }

        void loadData()
        {
            using (var context = new PhongKhamEntities())
            {
                var tToaThuocs = from t in context.tToaThuocs
                                 select t;

                DataTable table = new DataTable();
                table.Columns.Add("STT", typeof(int));
                table.Columns.Add("Bệnh nhân", typeof(string));
                table.Columns.Add("Bệnh được chẩn đoán", typeof(string));
                table.Columns.Add("Ngày khám", typeof(string));

                foreach (var t in tToaThuocs)
                {
                    string ngaykham = ((DateTime)t.NgayKham).ToString("MMMM dd yyyy");
                    table.Rows.Add(t.STT, t.tBenhNhan.TenBenhNhan, t.BenhDuocChanDoan, ngaykham);
                }

                dgvToaThuoc.DataSource = table;
                gridControlBenhNhan.DataSource = table;
            }
        }

        private void dgvToaThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex == dgvToaThuoc.Rows.Count - 1)
            {
                //Chống lỗi khi nhấn vào tên cột (hàng trên cùng), hàng rỗng dưới cùng
                return;
            }

            //DataGridViewRow row = dgvBenhNhan.Rows[dgvBenhNhan.SelectedCells[0].RowIndex];
            DataGridViewRow row = dgvToaThuoc.Rows[e.RowIndex];
            string gia = row.Cells[3].Value.ToString();

            txtIdToaThuoc.Text = row.Cells[0].Value.ToString();
            cbBenhNhan.Text = row.Cells[1].Value.ToString();
            txtBenhDuocChanDoan.Text = row.Cells[2].Value.ToString();
            dtNgayKham.Value = DateTime.Parse(row.Cells[3].Value.ToString());


            //enable controls
            toolStripDelete.Enabled = true;
        }

        // ################################## SAVE #######################################
        private void toolStripSave_Click(object sender, EventArgs e)
        {
            if (txtIdToaThuoc.Text.Length == 0)
                themToatThuoc();
            else
                CapNhatToaThuoc();
        }

        // ################################## CANCEL #######################################
        private void toolStripCancel_Click(object sender, EventArgs e)
        {
            txtIdToaThuoc.Text = "";
            txtBenhDuocChanDoan.Text = "";
            dtNgayKham.Value = DateTime.Now;
            cbBenhNhan.SelectedIndex = -1;
            toolStripDelete.Enabled = false;
        }

        // ################################## DELETE #######################################
        private void toolStripDelete_Click(object sender, EventArgs e)
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

        // ################################## ADD #######################################
        void themToatThuoc()
        {
            if (txtBenhDuocChanDoan.Text.Length == 0 ||
                cbBenhNhan.SelectedIndex == -1)
            {
                MessageBox.Show("Hãy nhập đủ thông tin.");
                return;
            }

            tToaThuoc toaThuoc = new tToaThuoc
            {
                BenhDuocChanDoan = txtBenhDuocChanDoan.Text,
                BenhNhan = cbBenhNhan.SelectedValue.ToString(),
                NgayKham = dtNgayKham.Value,
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
        void CapNhatToaThuoc()
        {
            if (txtBenhDuocChanDoan.Text.Length == 0 ||
                cbBenhNhan.SelectedIndex == -1)
            {
                MessageBox.Show("Hãy nhập đủ thông tin.");
                return;
            }

            using (var context = new PhongKhamEntities())
            {
                var toaThuoc = context.tToaThuocs.FirstOrDefault(x => x.STT.ToString() == txtIdToaThuoc.Text);
                toaThuoc.BenhDuocChanDoan = txtBenhDuocChanDoan.Text;
                toaThuoc.BenhNhan = cbBenhNhan.SelectedValue.ToString();
                toaThuoc.NgayKham = dtNgayKham.Value;
                context.SaveChanges();
            }

            loadData();
            Utilities.selectDgvRow(dgvToaThuoc, txtIdToaThuoc.Text);
            MessageBox.Show("Cập nhật toa thuốc thành công");
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}