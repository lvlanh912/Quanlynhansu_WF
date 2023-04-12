using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class QuaTrinhCongTacDAL
    {
        QuanLyNhanSuDAL ObjQLNS = new QuanLyNhanSuDAL();
        public DataSet SelectAll()
        {
            return ObjQLNS.SelectAll("QuaTrinhCongTac_SelectAll");
        }
        public void Insert(SqlParameter[] pr)
        {
            ObjQLNS.Insert("QuaTrinhCongTac_Insert", pr);
        }
        public void Update(SqlParameter[] pr)
        {
            ObjQLNS.Update("QuaTrinhCongTac_Update", pr);
        }
        public void Delete(SqlParameter pr)
        {
            ObjQLNS.Delete("QuaTrinhCongTac_Delete", pr);
        }
    }
}
