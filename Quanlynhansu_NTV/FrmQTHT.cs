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
    public partial class FrmQTHT : Form
    {
        MControl _manager = new MControl();
        QuaTrinhHocTapBLL _ObjQuaTrinhHocTapBLL = new QuaTrinhHocTapBLL();
        QuaTrinhHocTap _objQuaTrinhHocTap = new QuaTrinhHocTap();
        public FrmQTHT()
        {
            InitializeComponent();
        }

        void load()
        {
            _ObjQuaTrinhHocTapBLL.SelectAll(Dgv);
            _ObjQuaTrinhHocTapBLL.setcbbHV(cbbHV);
            _ObjQuaTrinhHocTapBLL.setcbbNS(cbbNS);
            _manager.ManagerControl(this, 0);
        }
        private void FrmQTHT_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            _manager.ManagerControl(this, 1);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaQTHT.Text))//Nếu ô txtMaQTCT có dữ liệu mới thực hiện
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
                txtMaQTHT.Text = Dgv.Rows[e.RowIndex].Cells["MaQTHT"].Value.ToString();
                cbbNS.Text = Dgv.Rows[e.RowIndex].Cells["MaNS"].Value.ToString();
                cbbHV.Text = Dgv.Rows[e.RowIndex].Cells["MaHV"].Value.ToString();
                txtTruong.Text= Dgv.Rows[e.RowIndex].Cells["Truong"].Value.ToString();
                dtpstart.Text = Dgv.Rows[e.RowIndex].Cells["NamBatDau"].Value.ToString();
                dtpend.Text = Dgv.Rows[e.RowIndex].Cells["NamKetThuc"].Value.ToString();//gán giá trị trong Dgv vào 
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            //lưu thêm
            //đã gán dữ liệu cho đối tượng thành công và ô txtmaQTCT được phép sửa
            if (setdata(_objQuaTrinhHocTap) && txtMaQTHT.Enabled)
            {
                _ObjQuaTrinhHocTapBLL.insert(_objQuaTrinhHocTap);
                MessageBox.Show("Thêm thành công");
                load();
            }
            //lưu Sửa
            //đã gán dữ liệu cho đối tượng thành công và ô txtmaQTCT không được phép sửa
            else if (setdata(_objQuaTrinhHocTap) && !txtMaQTHT.Enabled)
            {
                _ObjQuaTrinhHocTapBLL.Update(_objQuaTrinhHocTap);
                MessageBox.Show("Sửa thành công");
                load();
            }
            else
            {
                MessageBox.Show("vui lòng kiểm tra lại thông tin");
            }

        }
        bool setdata(QuaTrinhHocTap QTHT)
        {

            if (!string.IsNullOrWhiteSpace(dtpstart.Text) && !string.IsNullOrWhiteSpace(cbbNS.Text)
                && !string.IsNullOrWhiteSpace(cbbHV.Text) && !string.IsNullOrWhiteSpace(dtpend.Text))
            {
                QTHT.MaQTHT = txtMaQTHT.Text;
                QTHT.MANS = cbbNS.Text.Split('(')[0];
                QTHT.MaHV = cbbHV.Text.Split('(')[0];
                QTHT.Truong = txtTruong.Text;
                QTHT.NamBatDau = dtpstart.Value;
                QTHT.NamKetThuc = dtpend.Value;
                return true;
            }
            return false;

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (setdata(_objQuaTrinhHocTap))//nếu hàm setdata trả về true
            {
                _ObjQuaTrinhHocTapBLL.Delete(_objQuaTrinhHocTap);
                MessageBox.Show("Đã xoá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load();
            }
            else
            {
                MessageBox.Show("Chọn mục cần xoá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
