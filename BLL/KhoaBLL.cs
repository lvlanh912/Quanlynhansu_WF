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
    public class KhoaBLL
    {
        KhoaDAL _objKhoaDAL = new KhoaDAL();
        public void SelectAll(DataGridView dgv)
        {
            DataSet ds = _objKhoaDAL.SelectAll();
            dgv.DataSource = ds;
            dgv.DataMember = ds.Tables[0].TableName.ToString();
            dgv.AutoResizeColumns();
        }
        public void insert(Khoa _objKhoa)
        {
            _objKhoaDAL.Insert(Setpara(_objKhoa));
        }
        public void Update(Khoa _objKhoa)
        {
            _objKhoaDAL.Update(Setpara(_objKhoa));
        }
        public void Delete(Khoa _objKhoa)
        {
            SqlParameter p = new SqlParameter("@MaKhoa", SqlDbType.VarChar, 10);
            p.Value = _objKhoa.Makhoa;
            _objKhoaDAL.Delete(p);
        }
        public void Find(DataGridView dgv, string input)
        {
            SqlParameter p = new SqlParameter("@TenKhoa", SqlDbType.NVarChar, 50);
            p.Value = input;
            DataSet ds = _objKhoaDAL.Find(p);
            if (ds.Tables[0].Rows.Count > 0)//nếu có dữ liệu trong bảng
            {
                dgv.DataSource = ds;
                dgv.DataMember = ds.Tables[0].TableName.ToString();
                dgv.AutoResizeColumns();
            }
            else
                MessageBox.Show("không tìm thấy");
        }

        //
        private SqlParameter[] Setpara(Khoa _objKhoa) //gán giá trị vào parameter
        {
            SqlParameter[] pr = new SqlParameter[2];
            SqlParameter p0 = new SqlParameter("@MaKhoa", SqlDbType.VarChar, 10);
            p0.Value = _objKhoa.Makhoa;
            pr[0] = p0;
            SqlParameter p1 = new SqlParameter("@TenKhoa", SqlDbType.NVarChar, 50);
            p1.Value = _objKhoa.TenKhoa;
            pr[1] = p1;
            return pr;
        }
        public List<string> getlistKhoa()//lấy danh sách khoa theo dạng MaKhoa(Tenkhoa)
        {
            List<string> listchucvu = new List<string>();
            DataSet ds = _objKhoaDAL.SelectAll();
            int sohang = ds.Tables[0].Rows.Count;
            for (int i = 0; i < sohang; i++)
            {
                listchucvu.Add($"{ds.Tables[0].Rows[i]["MaKhoa"].ToString()}({ds.Tables[0].Rows[i]["TenKhoa"].ToString()})");
            }
            return listchucvu;
        }
    }
}
