using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class clsconnect
    {
        SqlConnection Conn;
        string Connstring = @"Data Source=DESKTOP-KISACQV\SQLEXPRESS;Initial Catalog=Quanlynhansu;Integrated Security=True";//chuỗi kết nối
        public SqlConnection ConnectData()
        {
            return Conn = new SqlConnection(Connstring);
        }
    }
}
