using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlynhansu
{
    public partial class FrmThongKe : Form
    {
        HocVanBLL _HV = new HocVanBLL();
        NhanSuBLL _NS = new NhanSuBLL();
        public FrmThongKe()
        {
            InitializeComponent();
        }

        private void rdoHV_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoHV.Checked)
            {
                cbbHV.Enabled = true;
                txttuoie.Enabled = false;
                txttuois.Enabled = false;
                cbbNS.Enabled = false;
            }
            else if(rdotuoi.Checked)
            {
                txttuoie.Enabled = true;
                txttuois.Enabled = true;
                cbbHV.Enabled = false;
                cbbNS.Enabled = false;
            }
            else if (rdoQTCT.Checked)
            {
                cbbNS.Enabled = true;
                cbbHV.Enabled = false;
                txttuoie.Enabled = false;
                txttuois.Enabled = false;
            }
        }

        private void FrmThongKe_Load(object sender, EventArgs e)
        {
            setcbbHV(cbbHV);
            setcbbNS(cbbNS);
        }
        

        private void btnthoat_Click(object sender, EventArgs e)
        {
            MControl mControl = new MControl();
            mControl.CloseForm(this);
        }

        private void btnthongke_Click(object sender, EventArgs e)
        {
            //theo học vấn
            if(rdoHV.Checked && cbbHV.SelectedIndex != -1)
            {
                _NS.ThongkeHV(Dgv, cbbHV.SelectedItem.ToString().Split('(')[0]);
            }
            //theo độ tuổi
            else if(rdotuoi.Checked && IsNumber(txttuois.Text, txttuoie.Text))
            {
                _NS.ThongkeTuoi(Dgv, Convert.ToInt32(txttuois.Text), Convert.ToInt32(txttuoie.Text));
            }
            //theo QTCT
            else if(rdoQTCT.Checked && cbbNS.SelectedIndex != -1)
            {
                _NS.ThongkeQTCT(Dgv, cbbNS.SelectedItem.ToString().Split('(')[0]);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn (Nhập) đúng dữ liệu");
            }
        }
        bool IsNumber(string start,string end)
        {
            Regex rg = new Regex(@"^\d+$");
            if(rg.IsMatch(start) && rg.IsMatch(end))
            {     
                return true;
            }
            return false;
        }

        void setcbbHV(ComboBox cbb)
        {
            foreach (var item in _HV.getlistHocVan())
            {
                cbb.Items.Add(item.ToString());
            }
        }
        void setcbbNS(ComboBox cbb)
        {
            foreach (var item in _NS.getlistNhanSu())
            {
                cbb.Items.Add(item.ToString());
            }
        }
    }
}
