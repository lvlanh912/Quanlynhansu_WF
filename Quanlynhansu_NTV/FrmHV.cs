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
    public partial class FrmHV : Form
    {
        MControl _manager = new MControl();
        HocVanBLL _ObjHocVanBLL = new HocVanBLL();
        HocVan _objHocVan = new HocVan();
        public FrmHV()
        {
            InitializeComponent();
        }

        private void FrmHV_Load(object sender, EventArgs e)
        {
            _manager.ManagerControl(this, 0);
            _ObjHocVanBLL.SelectAll(Dgv);
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            _manager.ManagerControl(this, 1);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaHV.Text))//Nếu ô txtMaHV có dữ liệu mới thực hiện
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
                txtMaHV.Text = Dgv.Rows[e.RowIndex].Cells["MaHV"].Value.ToString();
                txtTenHV.Text = Dgv.Rows[e.RowIndex].Cells["TenHV"].Value.ToString();
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            //lưu thêm
            //đã gán dữ liệu cho đối tượng thành công và ô txtmaHV được phép sửa
            if (setdata(_objHocVan) && txtMaHV.Enabled)
            {
                _ObjHocVanBLL.insert(_objHocVan);
                MessageBox.Show("Thêm thành công");
                _manager.ManagerControl(this, 0);
                _ObjHocVanBLL.SelectAll(Dgv);
            }
            //lưu Sửa
            //đã gán dữ liệu cho đối tượng thành công và ô txtmaHV không được phép sửa
            else if (setdata(_objHocVan) && !txtMaHV.Enabled)
            {
                _ObjHocVanBLL.Update(_objHocVan);
                MessageBox.Show("Sửa thành công");
                _manager.ManagerControl(this, 0);
                _ObjHocVanBLL.SelectAll(Dgv);
            }
            else
            {
                MessageBox.Show("vui lòng kiểm tra lại thông tin");
            }

        }
        bool setdata(HocVan HV)
        {
            //txtMaHV với txtTenHV có giá trị mới thực hiện gán
            if (!string.IsNullOrWhiteSpace(txtMaHV.Text) && !string.IsNullOrWhiteSpace(txtMaHV.Text))
            {
                HV.MaHV = txtMaHV.Text;
                HV.TenHV = txtTenHV.Text;
                return true;
            }
            return false;

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (setdata(_objHocVan))//nếu hàm setdata trả về true
            {
                _ObjHocVanBLL.Delete(_objHocVan);
                MessageBox.Show("Đã xoá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _ObjHocVanBLL.SelectAll(Dgv);
            }
            else
            {
                MessageBox.Show("Chọn mục cần xoá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
