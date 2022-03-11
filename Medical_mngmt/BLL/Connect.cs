using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Medical_mngmt.BLL
{
    public static class Connect
    {
        public static string strcon = ConfigurationManager.ConnectionStrings["Medical_mngmt.Properties.Settings.medicalConnectionString"].ConnectionString;
        public static SqlConnection GetConnection()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State != System.Data.ConnectionState.Open)
                {
                    con.Open();
                }
                return con;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static int IUD(string sql,SqlParameter[]param)
        {
            using (SqlConnection con=GetConnection())
            {
                using(SqlCommand cmd=new SqlCommand(sql,con))
                {
                    if(param!=null)
                    {
                        cmd.Parameters.AddRange(param);
                    }
                    try
                    {
                        return cmd.ExecuteNonQuery();
                    }
                    catch(Exception ex)
                    {
                        throw ex;    
                    }
                }
            }
        }
        public static DataTable GetTable(string sql,SqlParameter[]param)
        {
            using(SqlConnection con=new SqlConnection(strcon))
            {
                using(SqlCommand cmd=new SqlCommand(sql,con))
                {
                    if(param !=null)
                    {
                        cmd.Parameters.AddRange(param);
                    }
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }
    }
}
