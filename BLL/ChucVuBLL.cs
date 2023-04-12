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
    public class ChucVuBLL
    {
        ChucVuDAL _objChucVuDAL = new ChucVuDAL();
        public void SelectAll(DataGridView dgv)
        {
            DataSet ds = _objChucVuDAL.SelectAll();
            dgv.DataSource = ds;
            dgv.DataMember = ds.Tables[0].TableName.ToString();
            dgv.AutoResizeColumns();
        }
        public void insert(ChucVu _objChucVu)
        {
            _objChucVuDAL.Insert(Setpara(_objChucVu));
        }
        public void Update(ChucVu _objChucVu)
        {
            _objChucVuDAL.Update(Setpara(_objChucVu));
        }
        public void Delete(ChucVu _objChucVu)
        {
            SqlParameter p = new SqlParameter("@MaCV", SqlDbType.VarChar, 10);
            p.Value = _objChucVu.MaCV;
            _objChucVuDAL.Delete(p);
        }
        public void Find(DataGridView dgv, string input)
        {
            SqlParameter p = new SqlParameter("@TenCV", SqlDbType.NVarChar, 50);
            p.Value = input;
            DataSet ds = _objChucVuDAL.Find(p);
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
            private SqlParameter[] Setpara(ChucVu _objChucVu) //gán giá trị vào parameter
        {
            SqlParameter[] pr = new SqlParameter[2];
            SqlParameter p0 = new SqlParameter("@MaCV", SqlDbType.VarChar, 10);
            p0.Value = _objChucVu.MaCV;
            pr[0] = p0;
            SqlParameter p1 = new SqlParameter("@TenCV", SqlDbType.NVarChar, 50);
            p1.Value = _objChucVu.TenCV;
            pr[1] = p1;
            return pr;
        }
        public List<string> getlistchucVu()
        {
            List<string> listchucvu = new List<string>();
            DataSet ds = _objChucVuDAL.SelectAll();
            int sohang = ds.Tables[0].Rows.Count;
            for(int i=0;i<sohang; i++)
            {
                listchucvu.Add($"{ds.Tables[0].Rows[i]["MaCV"].ToString()}({ds.Tables[0].Rows[i]["TenCV"].ToString()})");
            }
            return listchucvu;
        }

    }
}
