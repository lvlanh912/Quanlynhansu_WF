using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HocVanDAL
    {
        QuanLyNhanSuDAL ObjQLNS = new QuanLyNhanSuDAL();
        public DataSet SelectAll()
        {
            return ObjQLNS.SelectAll("HocVan_SelectAll");
        }
        public void Insert(SqlParameter[] pr)
        {
            ObjQLNS.Insert("HocVan_Insert", pr);
        }
        public void Update(SqlParameter[] pr)
        {
            ObjQLNS.Update("HocVan_Update", pr);
        }
        public void Delete(SqlParameter pr)
        {
            ObjQLNS.Delete("HocVan_Delete", pr);
        }
        public DataSet Find(SqlParameter p)
        {
            return ObjQLNS.Find("HocVan_Find", p);
        }
    }
}
