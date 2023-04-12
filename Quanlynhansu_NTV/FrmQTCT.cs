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
    public partial class FrmQTCT : Form
    {
        MControl _manager = new MControl();
        QuaTrinhCongTacBLL _ObjQuaTrinhCongTacBLL = new QuaTrinhCongTacBLL();
        QuaTrinhCongTac _objQuaTrinhCongTac = new QuaTrinhCongTac();
        public FrmQTCT()
        {
            InitializeComponent();
        }
        void load()
        {
            
            _ObjQuaTrinhCongTacBLL.SelectAll(Dgv);
            _ObjQuaTrinhCongTacBLL.setcbbCV(cbbCV);
            _ObjQuaTrinhCongTacBLL.setcbbKhoa(cbbKhoa);
            _ObjQuaTrinhCongTacBLL.setcbbNS(cbbNS);
            _manager.ManagerControl(this, 0);
        }
        private void FrmQTCT_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            _manager.ManagerControl(this, 1);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaCT.Text))//Nếu ô txtMaQTCT có dữ liệu mới thực hiện
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
                txtMaCT.Text = Dgv.Rows[e.RowIndex].Cells["MaCT"].Value.ToString();
                cbbNS.Text = Dgv.Rows[e.RowIndex].Cells["MaNS"].Value.ToString();
                cbbCV.Text= Dgv.Rows[e.RowIndex].Cells["MaCV"].Value.ToString();
                cbbKhoa.Text= Dgv.Rows[e.RowIndex].Cells["MaKhoa"].Value.ToString();
                dtpstart.Text= Dgv.Rows[e.RowIndex].Cells["NamBatDau"].Value.ToString();
                dtpend.Text = Dgv.Rows[e.RowIndex].Cells["NamKetThuc"].Value.ToString();//gán giá trị trong Dgv vào 
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            //lưu thêm
            //đã gán dữ liệu cho đối tượng thành công và ô txtmaQTCT được phép sửa
            if (setdata(_objQuaTrinhCongTac) && txtMaCT.Enabled)
            {
                _ObjQuaTrinhCongTacBLL.insert(_objQuaTrinhCongTac);
                MessageBox.Show("Thêm thành công");
                load();
            }
            //lưu Sửa
            //đã gán dữ liệu cho đối tượng thành công và ô txtmaQTCT không được phép sửa
            else if (setdata(_objQuaTrinhCongTac) && !txtMaCT.Enabled)
            {
                _ObjQuaTrinhCongTacBLL.Update(_objQuaTrinhCongTac);
                MessageBox.Show("Sửa thành công");
                load();
            }
            else
            {
                MessageBox.Show("vui lòng kiểm tra lại thông tin");
            }

        }
        bool setdata(QuaTrinhCongTac QTCT)
        {

            if (!string.IsNullOrWhiteSpace(dtpstart.Text) && !string.IsNullOrWhiteSpace(cbbCV.Text)
                && !string.IsNullOrWhiteSpace(cbbKhoa.Text) && !string.IsNullOrWhiteSpace(dtpend.Text))
            {
                QTCT.MaCT = txtMaCT.Text;
                QTCT.MANS = cbbNS.Text.Split('(')[0];
                QTCT.MaCV = cbbCV.Text.Split('(')[0];
                QTCT.MaKhoa = cbbKhoa.Text.Split('(')[0];
                QTCT.NamBatDau = dtpstart.Value;
                QTCT.NamKetThuc = dtpend.Value;
                return true;
            }
            return false;

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (setdata(_objQuaTrinhCongTac))//nếu hàm setdata trả về true
            {
                _ObjQuaTrinhCongTacBLL.Delete(_objQuaTrinhCongTac);
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
