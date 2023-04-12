using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KhoaDAL
    {
        QuanLyNhanSuDAL ObjQLNS=new QuanLyNhanSuDAL();
        public DataSet SelectAll()
        {
           return ObjQLNS.SelectAll("Khoa_SelectAll");
        }
        public void Insert(SqlParameter[] pr)
        {
            ObjQLNS.Insert("Khoa_Insert", pr);
        }
        public void Update(SqlParameter[] pr)
        {
            ObjQLNS.Update("Khoa_Update", pr);
        }
        public void Delete(SqlParameter pr)
        {
            ObjQLNS.Delete("Khoa_Delete", pr);
        }
        public DataSet Find(SqlParameter p)
        {
            return ObjQLNS.Find("Khoa_Find", p);
        }
    }
}
