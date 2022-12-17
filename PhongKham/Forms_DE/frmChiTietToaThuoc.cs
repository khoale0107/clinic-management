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
            string tenBenhNhan = frmToaThuoc.lookUpEdit1.Properties
                                    .GetDisplayText(frmToaThuoc.lookUpEdit1.EditValue);

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
            table.Columns.Add("Tên thuốc", typeof(string));
            table.Columns.Add("Số lượng", typeof(string));
            table.Columns.Add("Liều dùng", typeof(string));

            foreach (var r in tChiTietToaThuocs)
            {
                table.Rows.Add(r.tThuoc.TenThuoc, r.SoLuong, r.LieuDung);
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
            Console.WriteLine("add");
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
        }
    }
}