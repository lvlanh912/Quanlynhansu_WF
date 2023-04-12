using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhanSuDAL
    {
        QuanLyNhanSuDAL ObjQLNS = new QuanLyNhanSuDAL();
        public DataSet SelectAll()
        {
            return ObjQLNS.SelectAll("NhanSu_SelectAll");
        }
        public void Insert(SqlParameter[] pr)
        {
            ObjQLNS.Insert("NhanSu_Insert", pr);
        }
        public void Update(SqlParameter[] pr)
        {
            ObjQLNS.Update("NhanSu_Update", pr);
        }
        public void Delete(SqlParameter pr)
        {
            ObjQLNS.Delete("NhanSu_Delete", pr);
        }
        public DataSet FindMaNS(SqlParameter p)
        {
            return ObjQLNS.Find("NhanSu_FindMa",p);
        }
        public DataSet FindTenNS(SqlParameter p)
        {
            return ObjQLNS.Find("NhanSu_FindTen", p);
        }
        public DataSet ThongkeTuoi(SqlParameter[] p1)
        {
            return ObjQLNS.Thongke("NhanSu_ThongkeTuoi", p1);
        }
        public DataSet ThongkeHV(SqlParameter[] p1)
        {
            return ObjQLNS.Thongke("NhanSu_ThongkeHV", p1);
        }
        public DataSet ThongkeQTCT(SqlParameter[] p1)
        {
            return ObjQLNS.Thongke("NhanSu_ThongkeQTCT", p1);
        }
        public DataSet SelectGV()
        {
            
            return ObjQLNS.SelectAll("Select_GiangVien");
        }
        public DataSet SelectGVAge()
        {

            return ObjQLNS.SelectAll("Select_GiangVienAge");
        }

    }
}
