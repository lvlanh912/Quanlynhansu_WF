using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class QuanLyNhanSuDAL
    {
        SqlConnection _ketnoi = new clsconnect().ConnectData();
        public DataSet Find(string storeName,SqlParameter p)//chọn 
        {
            _ketnoi.Open();
            SqlCommand _cmd = new SqlCommand();
            _cmd.Connection = _ketnoi;
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.CommandText = storeName;
            _cmd.Parameters.Add(p);
            SqlDataAdapter da = new SqlDataAdapter(_cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            _ketnoi.Close();
            return ds;
        }
        public DataSet Thongke(string storeName, SqlParameter[] p)//chọn 
        {
            _ketnoi.Open();
            SqlCommand _cmd = new SqlCommand();
            _cmd.Connection = _ketnoi;
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.CommandText = storeName;
            foreach(SqlParameter pr in p)
            {
                _cmd.Parameters.Add(pr);
            }
            SqlDataAdapter da = new SqlDataAdapter(_cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            _ketnoi.Close();
            return ds;
        }
        public DataSet SelectAll(string storeName)//chọn 
        {
            _ketnoi.Open();
            SqlCommand _cmd = new SqlCommand();
            _cmd.Connection = _ketnoi;
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.CommandText = storeName;
            SqlDataAdapter da = new SqlDataAdapter(_cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            _ketnoi.Close();
            return ds;
        }
        public void Insert(string storename, SqlParameter[] pr)//thêm
        {
            _ketnoi.Open();
            //sử dụng sqlcommand
            SqlCommand _cmd = new SqlCommand();
            _cmd.Connection = _ketnoi;
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.CommandText = storename;
            foreach (SqlParameter p in pr)
            {
                //2 parametter này tự sinh không cần thêm
                if(p.ParameterName!="@MaCT" && p.ParameterName != "@MaQTHT")
                {
                    _cmd.Parameters.Add(p);
                }
            }    
              
            _cmd.ExecuteNonQuery();
            _ketnoi.Close();
        }
        public void Update(string storename, SqlParameter[] pr)//sửa
        {
            _ketnoi.Open();
            SqlCommand _cmd = new SqlCommand();
            _cmd.Connection = _ketnoi;
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.CommandText = storename;
            foreach (SqlParameter p in pr)
            {
                _cmd.Parameters.Add(p);
            }
            _cmd.ExecuteNonQuery();
            _ketnoi.Close();
        }
        public void Delete(string storename, SqlParameter pr)//xoá
        {
            _ketnoi.Open();
            SqlCommand _cmd = new SqlCommand();
            _cmd.Connection = _ketnoi;
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.CommandText = storename;
             _cmd.Parameters.Add(pr);
            _cmd.ExecuteNonQuery();
            _ketnoi.Close();
        }
    }
}
