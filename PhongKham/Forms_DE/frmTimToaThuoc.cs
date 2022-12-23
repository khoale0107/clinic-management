using DevExpress.XtraEditors;
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
    public partial class frmTimToaThuoc : DevExpress.XtraEditors.XtraForm
    {
        public frmTimToaThuoc()
        {
            InitializeComponent();
            loadData();
        }

        void loadData()
        {
            using (var context = new PhongKhamEntities())
            {
                var tToaThuocs = from t in context.tToaThuocs
                                 select t;


                DataTable table = new DataTable();
                table.Columns.Add("STT toa thuốc", typeof(int));
                table.Columns.Add("Bệnh nhân", typeof(string));
                table.Columns.Add("Bệnh được chẩn đoán", typeof(string));
                table.Columns.Add("Ngày khám", typeof(string));
                table.Columns.Add("Mã bệnh nhân", typeof(string));

                foreach (var t in tToaThuocs)
                {
                    string ngaykham = ((DateTime)t.NgayKham).ToString("MMMM dd yyyy");
                    if (t.BenhNhan != null)
                    {
                        table.Rows.Add(t.STT, t.tBenhNhan.TenBenhNhan, t.BenhDuocChanDoan, ngaykham, t.tBenhNhan.MaBenhNhan);

                    }
                }

                dgvToaThuoc.DataSource = table;

            }
        }

    }


}