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
    public class QuaTrinhCongTacBLL
    {
        QuaTrinhCongTacDAL _objQuaTrinhCongTacDAL = new QuaTrinhCongTacDAL();
        public void SelectAll(DataGridView dgv)
        {
            DataSet ds = _objQuaTrinhCongTacDAL.SelectAll();
            dgv.DataSource = ds;
            dgv.DataMember = ds.Tables[0].TableName.ToString();
            dgv.AutoResizeColumns();
        }
        public void insert(QuaTrinhCongTac _objQuaTrinhCongTac)
        {
            _objQuaTrinhCongTacDAL.Insert(Setpara(_objQuaTrinhCongTac));
        }
        public void Update(QuaTrinhCongTac _objQuaTrinhCongTac)
        {
            _objQuaTrinhCongTacDAL.Update(Setpara(_objQuaTrinhCongTac));
        }
        public void Delete(QuaTrinhCongTac _objQuaTrinhCongTac)
        {
            SqlParameter p = new SqlParameter("@MaCT", SqlDbType.VarChar, 10);
            p.Value = _objQuaTrinhCongTac.MaCT;
            _objQuaTrinhCongTacDAL.Delete(p);
        }
        //
        private SqlParameter[] Setpara(QuaTrinhCongTac _objQuaTrinhCongTac) //gán giá trị vào parameter
        {
            SqlParameter[] pr = new SqlParameter[6];
            SqlParameter p1 = new SqlParameter("@MaKhoa", SqlDbType.VarChar, 10);
            p1.Value = _objQuaTrinhCongTac.MaKhoa;
            pr[0] = p1;
            SqlParameter p2 = new SqlParameter("@MaNS", SqlDbType.VarChar,10);
            p2.Value = _objQuaTrinhCongTac.MANS;
            pr[1] = p2;
            SqlParameter p3 = new SqlParameter("@NamBatDau", SqlDbType.Date);
            p3.Value = _objQuaTrinhCongTac.NamBatDau;
            pr[2] = p3;
            SqlParameter p4 = new SqlParameter("@NamKetThuc", SqlDbType.Date);
            p4.Value = _objQuaTrinhCongTac.NamKetThuc;
            pr[3] = p4;
            SqlParameter p5 = new SqlParameter("@MaCV", SqlDbType.VarChar, 10);
            p5.Value = _objQuaTrinhCongTac.MaCV;
            pr[4] = p5;
            SqlParameter p6 = new SqlParameter("@MaCT", SqlDbType.VarChar, 10);
            p6.Value = _objQuaTrinhCongTac.MaCT;
            pr[5] = p6;
            return pr;
        }
      public void setcbbCV(ComboBox cbb)
        {
             foreach(var item in new ChucVuBLL().getlistchucVu())
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
        public void setcbbKhoa(ComboBox cbb)
        {
            foreach (var item in new KhoaBLL().getlistKhoa())
            {
                cbb.Items.Add(item);
            }

        }
    }
}
