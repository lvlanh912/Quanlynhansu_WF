using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlynhansu
{
    public partial class Frmmain : Form
    {
        public Frmmain()
        {
            InitializeComponent();
        }

        private void khoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKhoa form = new FrmKhoa();
            form.ShowDialog();
         }

        private void chứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCV form = new FrmCV();
            form.ShowDialog();
        }

        private void họcVấnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHV form = new FrmHV();
            form.ShowDialog();
        }

        private void quáTrìnhHọcTậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmQTHT form = new FrmQTHT();
            form.ShowDialog();
        }

        private void quáTrìnhCôngTácToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmQTCT form = new FrmQTCT();
            form.ShowDialog();
        }

        private void nhânSựToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNhanSu form = new FrmNhanSu();
            form.ShowDialog();
        }

        private void tìmKiếmNhânSựToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FrmThongKe form = new FrmThongKe();
            form.ShowDialog();
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
            FrmTimKiem form = new FrmTimKiem();
            form.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            FrmBaoCao form = new FrmBaoCao();
            form.ShowDialog();
        }
    }
}
