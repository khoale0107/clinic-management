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
    public partial class frmTimThuoc : DevExpress.XtraEditors.XtraForm
    {
        public frmTimThuoc()
        {
            InitializeComponent();
            loadData();
        }

        void loadData()
        {
            using (var context = new PhongKhamEntities())
            {
                var tThuocs = context.tThuocs.ToList();

                DataTable table = new DataTable();
                table.Columns.Add("ID", typeof(int));
                table.Columns.Add("Tên thuốc", typeof(string));
                table.Columns.Add("Nước sản xuất", typeof(string));
                table.Columns.Add("Đơn giá", typeof(string));
                table.Columns.Add("Hạn sử dụng", typeof(string));
                table.Columns.Add("Ghi chú", typeof(string));

                foreach (var t in tThuocs)
                {
                    table.Rows.Add(t.MaThuoc, t.TenThuoc, t.NuocSX, Utilities.toCurrency((int)t.DonGia), t.HanSuDung, t.GhiChu);
                }

                dgvThuoc.DataSource = table;
            }
        }
    }
}