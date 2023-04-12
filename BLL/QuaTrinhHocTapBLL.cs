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
    public class QuaTrinhHocTapBLL
    {
        QuaTrinhHocTapDAL _objQuaTrinhHocTapDAL = new QuaTrinhHocTapDAL();
        public void SelectAll(DataGridView dgv)
        {
            DataSet ds = _objQuaTrinhHocTapDAL.SelectAll();
            dgv.DataSource = ds;
            dgv.DataMember = ds.Tables[0].TableName.ToString();
            dgv.AutoResizeColumns();
        }
        public void insert(QuaTrinhHocTap _objQuaTrinhHocTap)
        {
            _objQuaTrinhHocTapDAL.Insert(Setpara(_objQuaTrinhHocTap));
        }
        public void Update(QuaTrinhHocTap _objQuaTrinhHocTap)
        {
            _objQuaTrinhHocTapDAL.Update(Setpara(_objQuaTrinhHocTap));
        }
        public void Delete(QuaTrinhHocTap _objQuaTrinhHocTap)
        {
            SqlParameter p = new SqlParameter("@MaQTHT", SqlDbType.VarChar, 10);
            p.Value = _objQuaTrinhHocTap.MaQTHT;
            _objQuaTrinhHocTapDAL.Delete(p);
        }
        //
        private SqlParameter[] Setpara(QuaTrinhHocTap _objQuaTrinhHocTap) //gán giá trị vào parameter
        {
            SqlParameter[] pr = new SqlParameter[6];
            SqlParameter p1 = new SqlParameter("@MaHV", SqlDbType.VarChar, 10);
            p1.Value = _objQuaTrinhHocTap.MaHV;
            pr[0] = p1;
            SqlParameter p2 = new SqlParameter("@Truong", SqlDbType.NVarChar,55);
            p2.Value = _objQuaTrinhHocTap.Truong;
            pr[1] = p2;
            SqlParameter p3 = new SqlParameter("@NamBatDau", SqlDbType.Date);
            p3.Value = _objQuaTrinhHocTap.NamBatDau;
            pr[2] = p3;
            SqlParameter p4 = new SqlParameter("@NamKetThuc", SqlDbType.Date);
            p4.Value = _objQuaTrinhHocTap.NamKetThuc;
            pr[3] = p4;
            SqlParameter p5 = new SqlParameter("@MaNS", SqlDbType.VarChar, 10);
            p5.Value = _objQuaTrinhHocTap.MANS;
            pr[4] = p5;
            SqlParameter p6 = new SqlParameter("@MaQTHT", SqlDbType.VarChar, 10);
            p6.Value = _objQuaTrinhHocTap.MaQTHT;
            pr[5] = p6;
            return pr;
        }
        public void setcbbHV(ComboBox cbb)
        {
            foreach (var item in new HocVanBLL().getlistHocVan())
            {
                cbb.Items.Add(item);
            }

        }
        public void setcbbNS(ComboBox cbb)
        {
            foreach (var item in new NhanSuBLL().getlistNhanSu())
            {
                cbb.Items.Add(item);
            }

        }
    }
}
