using BLL;
using Entity;
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
    public partial class FrmNhanSu : Form
    {
        MControl _manager = new MControl();
        NhanSuBLL _ObjNhanSuBLL = new NhanSuBLL();
        NhanSu _objNhanSu = new NhanSu();
        public FrmNhanSu()
        {
            InitializeComponent();
        }

        private void FrmNhanSu_Load(object sender, EventArgs e)
        {
            _manager.ManagerControl(this, 0);
            _ObjNhanSuBLL.SelectAll(Dgv);
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            _manager.ManagerControl(this, 1);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaNS.Text))//Nếu ô txtMaNhanSu có dữ liệu mới thực hiện
            {
                _manager.ManagerControl(this, 2);
            }
            else
            {
                MessageBox.Show("vui lòng chọn dữ liệu cần sửa");
            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            _manager.ManagerControl(this, 0);
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            _manager.CloseForm(this);
        }

        private void Dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)//chọn vào hàng dữ liệu mới gán
            {
                txtMaNS.Text = Dgv.Rows[e.RowIndex].Cells["MaNS"].Value.ToString();
                txtTenNS.Text = Dgv.Rows[e.RowIndex].Cells["TenNS"].Value.ToString();
                txtDiaChi.Text = Dgv.Rows[e.RowIndex].Cells["DiaChi"].Value.ToString();
                txtEmail.Text = Dgv.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                txtSDT.Text = Dgv.Rows[e.RowIndex].Cells["SDT"].Value.ToString();
                dtpNgaySinh.Text = Dgv.Rows[e.RowIndex].Cells["NgaySinh"].Value.ToString();
                pickgioitinh(Dgv.Rows[e.RowIndex].Cells["GioiTinh"].Value.ToString());

            }
        }
        void pickgioitinh(string gioitinh)
        {
            if (gioitinh == "Nam")
            {
                rdoNam.Checked = true;
            }
            else if (gioitinh == "Nữ")
            {
                rdoNu.Checked = true;
            }
            else
            {
                rdoNam.Checked = false;
                rdoNu.Checked = false;
            } 
                
               
        }
        private void btnluu_Click(object sender, EventArgs e)
        {
            //lưu thêm
            //đã gán dữ liệu cho đối tượng thành công và ô txtmaNhanSu được phép sửa
            if (setdata(_objNhanSu) && txtMaNS.Enabled)
            {
                _ObjNhanSuBLL.insert(_objNhanSu);
                MessageBox.Show("Thêm thành công");
                _manager.ManagerControl(this, 0);
                _ObjNhanSuBLL.SelectAll(Dgv);
            }
            //lưu Sửa
            //đã gán dữ liệu cho đối tượng thành công và ô txtmaNhanSu không được phép sửa
            else if (setdata(_objNhanSu) && !txtMaNS.Enabled)
            {
                _ObjNhanSuBLL.Update(_objNhanSu);
                MessageBox.Show("Sửa thành công");
                _manager.ManagerControl(this, 0);
                _ObjNhanSuBLL.SelectAll(Dgv);
            }
            else
            {
                MessageBox.Show("vui lòng kiểm tra lại thông tin");
            }

        }
        bool setdata(NhanSu NhanSu)
        {
            //có đầy đủ dữ liệu mới gán
            if (checkvalueitem(this))
            {
                NhanSu.MANS = txtMaNS.Text;
                NhanSu.TenNS = txtTenNS.Text;
                NhanSu.Email = txtEmail.Text;
                NhanSu.SDT = txtSDT.Text;
                NhanSu.DiaChi = txtDiaChi.Text;
                NhanSu.NgaySinh = dtpNgaySinh.Value;
                setgioitinh(NhanSu);
                return true;
            }
            return false;

        }
        bool checkvalueitem(Form form)
        {
            foreach(Control c in form.Controls)
            {
                if (c is TextBox && string.IsNullOrEmpty(c.Text))//nếu có 1 textbox không có dữ liệu
                    return false;
                if (c is DateTimePicker && string.IsNullOrEmpty(c.Text))
                    return false;
            }
            if (rdoNam.Checked || rdoNu.Checked)
            {
                return true;
            }
               
            return false;
        }
        void setgioitinh(NhanSu nhanSu)
        {
            if (rdoNam.Checked)
                nhanSu.GioiTinh = "Nam";
            else
                nhanSu.GioiTinh = "Nữ";
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (setdata(_objNhanSu))//nếu hàm setdata trả về true
            {
                _ObjNhanSuBLL.Delete(_objNhanSu);
                MessageBox.Show("Đã xoá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _ObjNhanSuBLL.SelectAll(Dgv);
            }
            else
            {
                MessageBox.Show("Chọn mục cần xoá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
