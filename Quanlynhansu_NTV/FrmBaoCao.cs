using BLL;
using Microsoft.Reporting.WinForms;
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
    public partial class FrmBaoCao : Form
    {
        NhanSuBLL _NS = new NhanSuBLL();
        public FrmBaoCao()
        {
            InitializeComponent();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            DataTable dt;
            //in danh sách cán bộ
            if (rdocb.Checked)
            {
                rp.LocalReport.DataSources.Clear();
                dt = _NS.SelectAll().Tables[0];
                rp.LocalReport.ReportEmbeddedResource = "Quanlynhansu.rpt_CanBo.rdlc";
                ReportDataSource reportDataSource = new ReportDataSource("Ds", dt);
                rp.LocalReport.DataSources.Add(reportDataSource);
                this.rp.RefreshReport();
            }
            //in danh sách giảng viên
            else if (rdoGV.Checked)
            {
                rp.LocalReport.DataSources.Clear();
                dt = _NS.SelectGV().Tables[0];
                rp.LocalReport.ReportEmbeddedResource = "Quanlynhansu.rpt_GV.rdlc";
                ReportDataSource reportDataSource = new ReportDataSource("Ds", dt);
                rp.LocalReport.DataSources.Add(reportDataSource);
                this.rp.RefreshReport();
            }
            // in danh sách GV theo độ tuổi
            else if (rdoGVage.Checked)
            {
                rp.LocalReport.DataSources.Clear();
                dt = _NS.SelectGV().Tables[0];
                rp.LocalReport.ReportEmbeddedResource = "Quanlynhansu.rpt_GVAge.rdlc";
                ReportDataSource reportDataSource = new ReportDataSource("Ds", dt);
                rp.LocalReport.DataSources.Add(reportDataSource);
                this.rp.RefreshReport();
            }
            else
            {
                MessageBox.Show("vui lòng chọn một mục để thực hiện chức năng này");
            }
        }

        private void FrmBaoCao_Load(object sender, EventArgs e)
        {


            this.rp.RefreshReport();
        }

        private void rp_Load(object sender, EventArgs e)
        {

        }
    }
}
