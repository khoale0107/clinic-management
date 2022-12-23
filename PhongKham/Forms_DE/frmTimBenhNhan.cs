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
    public partial class frmTimBenhNhan : DevExpress.XtraEditors.XtraForm
    {
        public frmTimBenhNhan()
        {
            InitializeComponent();
            var db = new PhongKhamEntities();

            var tBenhNhans = from t in db.tBenhNhans
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
    }
}