using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Entity;

namespace BLL
{
    public class NhanSuBLL
    { 
        NhanSuDAL _objNhanSuDAL = new NhanSuDAL();
        public void SelectAll(DataGridView dgv)
        {
            DataSet ds = _objNhanSuDAL.SelectAll();
            dgv.DataSource = ds;
            dgv.DataMember = ds.Tables[0].TableName.ToString();
            dgv.AutoResizeColumns();
        }
        public DataSet SelectAll()
        {
            return _objNhanSuDAL.SelectAll();
        }
        public DataSet SelectGV()
        {
            return _objNhanSuDAL.SelectGV();
        }
        public DataSet SelectGVAge()
        {
            return _objNhanSuDAL.SelectGVAge();
        }
        public void FindMaNS(DataGridView dgv,string input)
        {
            SqlParameter p = new SqlParameter("@MaNS", SqlDbType.VarChar, 10);
            p.Value = input;
            DataSet ds = _objNhanSuDAL.FindMaNS(p);
            if (ds.Tables[0].Rows.Count > 0)//nếu có dữ liệu trong bảng
            {
                dgv.DataSource = ds;
                dgv.DataMember = ds.Tables[0].TableName.ToString();
                dgv.AutoResizeColumns();
            }
            else
                MessageBox.Show("không tìm thấy");
           
        }
        
        public void FindTenNS(DataGridView dgv, string input)
        {
            SqlParameter p = new SqlParameter("@TenNS", SqlDbType.NVarChar,50);
            p.Value = input;
            DataSet ds = _objNhanSuDAL.FindTenNS(p);
            if (ds.Tables[0].Rows.Count > 0)//nếu có dữ liệu trong bảng
            {
                dgv.DataSource = ds;
                dgv.DataMember = ds.Tables[0].TableName.ToString();
                dgv.AutoResizeColumns();
            }
            else
                MessageBox.Show("không tìm thấy");
        }
        public void insert(NhanSu _objNhanSu)
        {
            _objNhanSuDAL.Insert(Setpara(_objNhanSu));
        }
        public void Update(NhanSu _objNhanSu)
        {
            _objNhanSuDAL.Update(Setpara(_objNhanSu));
        }
        public void Delete(NhanSu _objNhanSu)
        {
            SqlParameter p = new SqlParameter("@MaNS", SqlDbType.VarChar, 10);
            p.Value = _objNhanSu.MANS;
            _objNhanSuDAL.Delete(p);
        }
        public void ThongkeQTCT(DataGridView dgv, String MaNS)
        {
            SqlParameter[] pr = new SqlParameter[1];
            SqlParameter p1 = new SqlParameter("@MaNS", SqlDbType.VarChar,10);
            p1.Value = MaNS;
            pr[0] = p1;
            DataSet ds = _objNhanSuDAL.ThongkeQTCT(pr);
            if (ds.Tables[0].Rows.Count > 0)//nếu có dữ liệu trong bảng
            {
                dgv.DataSource = ds;
                dgv.DataMember = ds.Tables[0].TableName.ToString();
                dgv.AutoResizeColumns();
            }
            else
                MessageBox.Show("Không tồn tại dữ liệu nào");
        }
        public void ThongkeTuoi(DataGridView dgv, int agemin,int agemax)
        {
            SqlParameter[] pr = new SqlParameter[2];
            SqlParameter p1 = new SqlParameter("@agemin", SqlDbType.Int);
            p1.Value = agemin;
            pr[0] = p1;
            SqlParameter p2 = new SqlParameter("@agemax", SqlDbType.Int);
            p2.Value = agemax;
            pr[1] = p2;
            DataSet ds = _objNhanSuDAL.ThongkeTuoi(pr);
            if (ds.Tables[0].Rows.Count > 0)//nếu có dữ liệu trong bảng
            {
                dgv.DataSource = ds;
                dgv.DataMember = ds.Tables[0].TableName.ToString();
                dgv.AutoResizeColumns();
            }
            else
                MessageBox.Show("Không tồn tại dữ liệu nào");
        }
        //
        public void ThongkeHV(DataGridView dgv, string MaHV)
        {
            SqlParameter[] pr = new SqlParameter[1];
            SqlParameter p1 = new SqlParameter("@MaHV", SqlDbType.VarChar,10);
            p1.Value = MaHV;
            pr[0] = p1;
            DataSet ds = _objNhanSuDAL.ThongkeHV(pr);
            if (ds.Tables[0].Rows.Count > 0)//nếu có dữ liệu trong bảng
            {
                dgv.DataSource = ds;
                dgv.DataMember = ds.Tables[0].TableName.ToString();
                dgv.AutoResizeColumns();
            }
            else
                MessageBox.Show("Không tồn tại dữ liệu nào");
        }
        private SqlParameter[] Setpara(NhanSu _objNhanSu) //gán giá trị vào parameter
        {
            SqlParameter[] pr = new SqlParameter[7];
            //Add Parameter MaNS
            SqlParameter p0 = new SqlParameter("@MaNS", SqlDbType.VarChar, 10);
            p0.Value = _objNhanSu.MANS;
            pr[0] = p0;
            //Add Parameter TenNS
            SqlParameter p1 = new SqlParameter("@TenNS", SqlDbType.NVarChar, 50);
            p1.Value = _objNhanSu.TenNS;
            pr[1] = p1;
            //Add Parameter GioiTinh
            SqlParameter p2 = new SqlParameter("@GioiTinh", SqlDbType.NVarChar, 10);
            p2.Value = _objNhanSu.GioiTinh;
            pr[2] = p2;
            //Add Parameter NgaySinh
            SqlParameter p3 = new SqlParameter("@NgaySinh", SqlDbType.Date);
            p3.Value = _objNhanSu.NgaySinh;
            pr[3] = p3;
            //Add Parameter DiaChi
            SqlParameter p4 = new SqlParameter("@DiaChi", SqlDbType.NVarChar,255);
            p4.Value = _objNhanSu.DiaChi;
            pr[4] = p4;
            //Add Parameter SDT
            SqlParameter p5 = new SqlParameter("@SDT", SqlDbType.Char,10);
            p5.Value = _objNhanSu.SDT;
            pr[5] = p5;
            //Add Parameter Email
            SqlParameter p7 = new SqlParameter("@Email", SqlDbType.VarChar, 50);
            p7.Value = _objNhanSu.Email;
            pr[7] = p7;
            return pr;
        }
        public List<string> getlistNhanSu()//lấy danh sách nhân sự theo dạng MaNS(TenNS)
        {
            List<string> list = new List<string>();
            DataSet ds = _objNhanSuDAL.SelectAll();
            int sohang = ds.Tables[0].Rows.Count;
            for (int i = 0; i < sohang; i++)
            {
                list.Add($"{ds.Tables[0].Rows[i]["MaNS"].ToString()}({ds.Tables[0].Rows[i]["TenNS"].ToString()})");
            }
            return list;
        }

    }
}
