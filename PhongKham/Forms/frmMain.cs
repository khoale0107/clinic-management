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

namespace PhongKham.Forms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void toolStripBenhNhan_Click(object sender, EventArgs e)
        {
            //frmBenhNhan frmBenhNhan = new frmBenhNhan();
            //frmBenhNhan.MdiParent = this;
            //frmBenhNhan.Show();

            FormModule.openForm(new frmBenhNhan());
        }

        private void toolStripThuoc_Click(object sender, EventArgs e)
        {
            FormModule.openForm(new frmThuoc());
        }

        private void toolStripToaThuoc_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
