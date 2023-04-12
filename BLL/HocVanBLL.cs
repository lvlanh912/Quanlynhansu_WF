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
    public class HocVanBLL
    {
        HocVanDAL _objHocVanDAL = new HocVanDAL();
        public void SelectAll(DataGridView dgv)
        {
            DataSet ds = _objHocVanDAL.SelectAll();
            dgv.DataSource = ds;
            dgv.DataMember = ds.Tables[0].TableName.ToString();
            dgv.AutoResizeColumns();
        }
        public void insert(HocVan _objHocVan)
        {
            _objHocVanDAL.Insert(Setpara(_objHocVan));
        }
        public void Update(HocVan _objHocVan)
        {
            _objHocVanDAL.Update(Setpara(_objHocVan));
        }
        public void Delete(HocVan _objHocVan)
        {
            SqlParameter p = new SqlParameter("@MaHV", SqlDbType.VarChar, 10);
            p.Value = _objHocVan.MaHV;
            _objHocVanDAL.Delete(p);
        }
        public void Find(DataGridView dgv, string input)
        {
            SqlParameter p = new SqlParameter("@TenHV", SqlDbType.NVarChar, 50);
            p.Value = input;
            DataSet ds = _objHocVanDAL.Find(p);
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
        private SqlParameter[] Setpara(HocVan _objHocVan) //gán giá trị vào parameter
        {
            SqlParameter[] pr = new SqlParameter[2];
            SqlParameter p0 = new SqlParameter("@MaHV", SqlDbType.VarChar, 10);
            p0.Value = _objHocVan.MaHV;
            pr[0] = p0;
            SqlParameter p1 = new SqlParameter("@TenHV", SqlDbType.NVarChar, 50);
            p1.Value = _objHocVan.TenHV;
            pr[1] = p1;
            return pr;
        }
        public List<string> getlistHocVan()//lấy danh sách học vấn theo dạng MaHV(tenHV)
        {
            List<string> listchucvu = new List<string>();
            DataSet ds = _objHocVanDAL.SelectAll();
            int sohang = ds.Tables[0].Rows.Count;
            for (int i = 0; i < sohang; i++)
            {
                listchucvu.Add($"{ds.Tables[0].Rows[i]["MaHV"].ToString()}({ds.Tables[0].Rows[i]["TenHV"].ToString()})");
            }
            return listchucvu;
        }
    }
}
