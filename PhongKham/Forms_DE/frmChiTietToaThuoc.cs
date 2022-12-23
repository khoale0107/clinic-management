using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhongKham.Forms_DE
{
    public partial class frmChiTietToaThuoc : DevExpress.XtraEditors.XtraForm
    {
        private frmToaThuoc frmToaThuoc;
        private bool isUpdating = false;
        private int currentMaThuoc = 0;

        public frmChiTietToaThuoc()
        {
            InitializeComponent();
        }

        public frmChiTietToaThuoc(frmToaThuoc frmToaThuoc)
        {
            InitializeComponent();
            this.frmToaThuoc = frmToaThuoc;
        }

        private void frmChiTietToaThuoc_Load(object sender, EventArgs e)
        {
            string date = frmToaThuoc.dtNgayKham.EditValue.ToString().Split(' ')[0];
            string tenBenhNhan = frmToaThuoc.cbBenhNhan.Properties
                                    .GetDisplayText(frmToaThuoc.cbBenhNhan.EditValue);

            this.txtIdToaThuoc.Text = frmToaThuoc.txtIdToaThuoc.Text;
            this.txtTenBenhNhan.Text = tenBenhNhan;
            this.txtNgayKham.Text = date;
            this.txtBenhDuocChanDOan.Text = frmToaThuoc.txtBenhDuocChanDoan.Text;

            cbThuoc.EditValue = "";
            toolStripDelete.Enabled = false;

            loadData();
            loadCombobox();
        }

        void loadData()
        {
            var db = new PhongKhamEntities();

            var tChiTietToaThuocs = from r in db.tChiTietToaThuocs
                                    where r.STT.ToString() == txtIdToaThuoc.Text
                                    select r;

            DataTable table = new DataTable();
            table.Columns.Add("Mã thuốc", typeof(string));
            table.Columns.Add("Tên thuốc", typeof(string));
            table.Columns.Add("Số lượng", typeof(string));
            table.Columns.Add("Liều dùng", typeof(string));

            foreach (var r in tChiTietToaThuocs)
            {
                table.Rows.Add(r.tThuoc.MaThuoc ,r.tThuoc.TenThuoc, r.SoLuong, r.LieuDung);
            }

            dgvChiTietToaThuoc.DataSource = table;

            //lookUpEdit1.Properties.DisplayMember = "Tên bệnh nhân";
            //lookUpEdit1.Properties.ValueMember = "Mã bệnh nhân";

            //lookUpEdit1.Properties.DataSource = table;
        }

        void loadCombobox()
        {
            var tThuocs = new PhongKhamEntities().tThuocs.ToList();

            DataTable table = new DataTable();
            table.Columns.Add("Mã thuốc", typeof(string));
            table.Columns.Add("Tên thuốc", typeof(string));

            foreach (var r in tThuocs)
            {
                table.Rows.Add(r.MaThuoc, r.TenThuoc);
            }

            cbThuoc.Properties.DisplayMember = "Tên thuốc";
            cbThuoc.Properties.ValueMember = "Mã thuốc";

            cbThuoc.Properties.DataSource = table;
        }

        //##################################3 CLICK ########################################################
        private void dgvChiTietToaThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex == dgvChiTietToaThuoc.Rows.Count - 1)
            {
                //Chống lỗi khi nhấn vào tên cột (hàng trên cùng), hàng rỗng dưới cùng
                return;
            }

            DataGridViewRow row = dgvChiTietToaThuoc.Rows[e.RowIndex];
            cbThuoc.EditValue = row.Cells[0].Value.ToString();
            txtSoLuong.Text = row.Cells[2].Value.ToString();
            txtLieuDung.Text = row.Cells[3].Value.ToString();
            currentMaThuoc = int.Parse(cbThuoc.EditValue.ToString());

            isUpdating = true;
            toolStripDelete.Enabled = true;
        }


        //##################################3 SAVE ########################################################
        private void toolStripSave_Click(object sender, EventArgs e)
        {
            if (isUpdating)
            {
                updateChiTiet();
            }
            else
            {
                addChiTiet();
            }
        }

        //##################################3 ADD ########################################################
        void addChiTiet()
        {
            if (cbThuoc.EditValue == "" || cbThuoc.EditValue == null)
            {
                MessageBox.Show("Hãy chọn thuốc.");
                return;
            }
            if (txtLieuDung.Text == "")
            {
                MessageBox.Show("Hãy nhập liều dùng.");
                return;
            }

            tChiTietToaThuoc chiTietToaThuoc = new tChiTietToaThuoc
            {
                STT = int.Parse(txtIdToaThuoc.Text),
                Thuoc = int.Parse(cbThuoc.EditValue.ToString()),
                SoLuong = (byte)txtSoLuong.Value,
                LieuDung = txtLieuDung.Text,
            };

            try
            {
                var context = new PhongKhamEntities();
                context.tChiTietToaThuocs.Add(chiTietToaThuoc);
                context.SaveChanges();
            }
            catch (Exception error)
            {
                if (error is System.Data.Entity.Infrastructure.DbUpdateException)
                    MessageBox.Show("Thuốc này đã có trong toa thuốc", "Thêm thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("Có lỗi xảy ra.");

                return;
            }

            loadData();
            frmToaThuoc.loadChiTietToaThuoc();

            MessageBox.Show("Thêm chi tiết toa thuốc thành công");
        }

        //##################################3 UPDATE ########################################################
        void updateChiTiet()
        {
            Console.WriteLine("update");
        }

        //##################################3 CANCEL ########################################################
        private void toolStripCancel_Click(object sender, EventArgs e)
        {
            isUpdating = false;
            cbThuoc.EditValue = "";
            toolStripDelete.Enabled = false;
            txtSoLuong.Value = 1;
            txtLieuDung.Text = "";
        }

        //##################################3 DELETE ########################################################
        private void toolStripDelete_Click(object sender, EventArgs e)
        {
            var db = new PhongKhamEntities();
            int stt = int.Parse(txtIdToaThuoc.Text);


            var record = db.tChiTietToaThuocs
                        .Where(r => r.STT == stt)
                        .Where(r => r.Thuoc == currentMaThuoc).FirstOrDefault();

            db.tChiTietToaThuocs.Remove(record);
            db.SaveChanges();

            toolStripCancel.PerformClick();
            loadData();
            frmToaThuoc.loadChiTietToaThuoc();
            MessageBox.Show("Xóa thành công.");

            
        }
    }
}