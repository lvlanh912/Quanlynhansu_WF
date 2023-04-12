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
    public partial class FrmCV : Form
    {
        MControl _manager = new MControl();
        ChucVuBLL _ObjChucVuBLL = new ChucVuBLL();
        ChucVu _objChucVu = new ChucVu();
        public FrmCV()
        {
            InitializeComponent();
        }

        private void FrmCV_Load(object sender, EventArgs e)
        {
            _manager.ManagerControl(this, 0);
            _ObjChucVuBLL.SelectAll(Dgv);
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            _manager.ManagerControl(this, 1);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaCV.Text))//Nếu ô txtMaCV có dữ liệu mới thực hiện
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
                txtMaCV.Text = Dgv.Rows[e.RowIndex].Cells["MaCV"].Value.ToString();
                txtTenCV.Text = Dgv.Rows[e.RowIndex].Cells["TenCV"].Value.ToString();
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            //lưu thêm
            //đã gán dữ liệu cho đối tượng thành công và ô txtmaCV được phép sửa
            if (setdata(_objChucVu) && txtMaCV.Enabled)
            {
                _ObjChucVuBLL.insert(_objChucVu);
                MessageBox.Show("Thêm thành công");
                _manager.ManagerControl(this, 0);
                _ObjChucVuBLL.SelectAll(Dgv);
            }
            //lưu Sửa
            //đã gán dữ liệu cho đối tượng thành công và ô txtmaCV không được phép sửa
            else if (setdata(_objChucVu) && !txtMaCV.Enabled)
            {
                _ObjChucVuBLL.Update(_objChucVu);
                MessageBox.Show("Sửa thành công");
                _manager.ManagerControl(this, 0);
                _ObjChucVuBLL.SelectAll(Dgv);
            }
            else
            {
                MessageBox.Show("vui lòng kiểm tra lại thông tin");
            }

        }
        bool setdata(ChucVu CV)
        {
            //txtMaCV với txtTenCV có giá trị mới thực hiện gán
            if (!string.IsNullOrWhiteSpace(txtMaCV.Text) && !string.IsNullOrWhiteSpace(txtMaCV.Text))
            {
                CV.MaCV = txtMaCV.Text;
                CV.TenCV = txtTenCV.Text;
                return true;
            }
            return false;

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (setdata(_objChucVu))//nếu hàm setdata trả về true(có dữ liệu và gán thành công)
            {
                _ObjChucVuBLL.Delete(_objChucVu);
                MessageBox.Show("Đã xoá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _ObjChucVuBLL.SelectAll(Dgv);
            }
            else
            {
                MessageBox.Show("Chọn mục cần xoá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
