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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void benhNhanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilities.openForm(new Forms_DE.frmBenhNhan());
        }

        private void toaThuocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilities.openForm(new Forms_DE.frmToaThuoc());
        }

        private void thuocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilities.openForm(new Forms_DE.frmThuoc());
        }

        private void tìmBệnhNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilities.openForm(new Forms_DE.frmTimBenhNhan());
        }

        private void tìmThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilities.openForm(new Forms_DE.frmTimThuoc());
        }

        private void tìmToaThuocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilities.openForm(new Forms_DE.frmTimToaThuoc());
        }
    }
}
