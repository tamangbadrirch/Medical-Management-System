using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Medical_mngmt.BLL
{
    public class User
    {
        public int CreateUser(string Name, string Address, string Mobile_No, string Gender, string Email, string Password)
        {
            string sql = "insert into tblAdmin values(@a,@b,@c,@d,@e,@f)";
            SqlParameter[] param = new SqlParameter[]
            {
               new SqlParameter("@a",Name),
               new SqlParameter("@b",Address),
               new SqlParameter("@c",Mobile_No),
               new SqlParameter("@d",Gender),
               new SqlParameter("@e",Email),
               new SqlParameter("@f",Password),
            };
            return Connect.IUD(sql, param);
        }
        public DataTable GetPatientById(int UserId)
        {
            string sql = "select * from tblAdmin where UserId=@a";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@a",UserId),
            };
            return Connect.GetTable(sql, param);
        }
        public  int UpdateUser(string Name,string Address,string Mobile_No,string Gender,string Email,string Password ,int UserId) 
        {
            string sql = "update tblAdmin set Name=@a,Address=@b,Mobile_No=@c,Gender=@d,Email=@e,Password=@f where UserId=@g";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@a",Name),
                new SqlParameter("@b", Address),
                new SqlParameter("@c", Mobile_No),
                new SqlParameter("@d", Gender),
                new SqlParameter("@e", Email),
                new SqlParameter("@f", Password),
                new SqlParameter("@g",UserId),
            };
            return Connect.IUD(sql , param);
        }
        public DataTable GetUser()
        {
            string sql = "select * from tblAdmin order by UserId asc";
            return Connect.GetTable(sql, null);
        }
       public int DeleteUser(int UserId)
        {
            string sql = "delete from tblAdmin where UserId=@a";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@a",UserId),
            };
            return Connect.IUD(sql, param);
        }
      
    }
    
         
}
