using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class QuaTrinhHocTapDAL
    {
        QuanLyNhanSuDAL ObjQLNS = new QuanLyNhanSuDAL();
        public DataSet SelectAll()
        {
            return ObjQLNS.SelectAll("QuaTrinhHocTap_SelectAll");
        }
        public void Insert(SqlParameter[] pr)
        {
            ObjQLNS.Insert("QuaTrinhHocTap_Insert", pr);
        }
        public void Update(SqlParameter[] pr)
        {
            ObjQLNS.Update("QuaTrinhHocTap_Update", pr);
        }
        public void Delete(SqlParameter pr)
        {
            ObjQLNS.Delete("QuaTrinhHocTap_Delete", pr);
        }
    }
}
