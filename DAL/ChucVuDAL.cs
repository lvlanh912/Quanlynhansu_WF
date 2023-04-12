using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChucVuDAL
    {
        QuanLyNhanSuDAL ObjQLNS = new QuanLyNhanSuDAL();
        public DataSet SelectAll()
        {
            return ObjQLNS.SelectAll("ChucVu_SelectAll");
        }
        public void Insert(SqlParameter[] pr)
        {
            ObjQLNS.Insert("ChucVu_Insert", pr);
        }
        public void Update(SqlParameter[] pr)
        {
            ObjQLNS.Update("ChucVu_Update", pr);
        }
        public void Delete(SqlParameter pr)
        {
            ObjQLNS.Delete("ChucVu_Delete", pr);
        }
        public DataSet Find(SqlParameter p)
        {
            return ObjQLNS.Find("ChucVu_Find", p);
        }
    }
}
