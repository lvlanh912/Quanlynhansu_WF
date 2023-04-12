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
using Entity;

namespace Quanlynhansu
{
    public partial class FrmKhoa : Form
    {
        MControl _manager = new MControl();
        KhoaBLL _ObjKhoaBLL = new KhoaBLL();
        Khoa _objkhoa=new Khoa();
        public FrmKhoa()
        {
            InitializeComponent();
        }

        private void FrmKhoa_Load(object sender, EventArgs e)
        {
            _manager.ManagerControl(this, 0);
            _ObjKhoaBLL.SelectAll(Dgv);
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            _manager.ManagerControl(this, 1);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtMaKhoa.Text))//Nếu ô txtMakhoa có dữ liệu mới thực hiện
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
                txtMaKhoa.Text = Dgv.Rows[e.RowIndex].Cells["MaKhoa"].Value.ToString();
                txtTenKhoa.Text = Dgv.Rows[e.RowIndex].Cells["TenKhoa"].Value.ToString();
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            //lưu thêm
            //đã gán dữ liệu cho đối tượng thành công và ô txtmakhoa được phép sửa
            if (setdata(_objkhoa)&&txtMaKhoa.Enabled)
            {
                _ObjKhoaBLL.insert(_objkhoa);
                MessageBox.Show("Thêm thành công");
                _manager.ManagerControl(this, 0);
                _ObjKhoaBLL.SelectAll(Dgv);
            }
            //lưu Sửa
            //đã gán dữ liệu cho đối tượng thành công và ô txtmakhoa không được phép sửa
            else if (setdata(_objkhoa) && !txtMaKhoa.Enabled)
            {
                _ObjKhoaBLL.Update(_objkhoa);
                MessageBox.Show("Sửa thành công");
                _manager.ManagerControl(this, 0);
                _ObjKhoaBLL.SelectAll(Dgv);
            }
            else
            {
                MessageBox.Show("vui lòng kiểm tra lại thông tin");
            }
            
        }
        bool setdata(Khoa khoa)
        {
            //txtMaKhoa với txtTenkhoa có giá trị mới thực hiện gán
            if(!string.IsNullOrWhiteSpace(txtMaKhoa.Text)&& !string.IsNullOrWhiteSpace(txtMaKhoa.Text))
            {
                khoa.Makhoa = txtMaKhoa.Text;
                khoa.TenKhoa = txtTenKhoa.Text;
                return true;
            }
            return false;
           
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (setdata(_objkhoa))//nếu hàm setdata trả về true
            {
                _ObjKhoaBLL.Delete(_objkhoa);
                MessageBox.Show("Đã xoá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _ObjKhoaBLL.SelectAll(Dgv);
            }
            else
            {
                MessageBox.Show("Chọn mục cần xoá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
