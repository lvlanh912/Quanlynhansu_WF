using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace Quanlynhansu
{
    public partial class FrmTimKiem : Form
    {
        NhanSuBLL _NS = new NhanSuBLL();
        KhoaBLL _Khoa = new KhoaBLL();
        ChucVuBLL _CV = new ChucVuBLL();
        HocVanBLL _HV=new HocVanBLL();
        public FrmTimKiem()
        {
            InitializeComponent();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            //xoá dữ liệu trong Datagridview
            Dgv.DataSource = null;
            //tìm theo mã nhân sự
            if (rdoMaNS.Checked && !string.IsNullOrEmpty(txtinput.Text))
            {
                _NS.FindMaNS(Dgv, txtinput.Text);
            }
            //tìm theo tên nhân sự
            else if(rdoTenNS.Checked&& !string.IsNullOrEmpty(txtinput.Text))
            {
                _NS.FindTenNS(Dgv, txtinput.Text);
            }
            //tìm theo tên khoa
            else if (rdoKhoa.Checked && !string.IsNullOrEmpty(txtinput.Text))
            {
                _Khoa.Find(Dgv, txtinput.Text);
            }
            //tìm theo tên học vấn
            else if (rdoHV.Checked && !string.IsNullOrEmpty(txtinput.Text))
            {
                _HV.Find(Dgv, txtinput.Text);
            }
            //tìm theo tên Chức vụ
            else if (rdoCV.Checked && !string.IsNullOrEmpty(txtinput.Text))
            {
                _CV.Find(Dgv, txtinput.Text);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn kiểu tìm kiếm");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MControl mControl = new MControl();
            mControl.CloseForm(this);

        }
    }
}
