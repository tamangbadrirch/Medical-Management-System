using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Medical_mngmt.BLL
{
    public class Patient
    {
        public int CreatePatient(string Name, int Age, string Address, string Mobile_No, string Gender, string Email, string Blood_Group, string Symptoms, string Relative_Name, string Diagnosis, string Diagnosis_By, string Medicine, int Admitted_Days, string Ward_Required, string Type_of_Ward) /*insert Patient data into database*/
        {
            string sql = "insert into tblPatient values(@a,@b,@c,@d,@e,@f,@g,@h,@i,@j,@k,@l,@m,@n,@o)";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@a",Name),
                new SqlParameter("@b",Age),
                new SqlParameter("@c",Address),
                new SqlParameter("@d",Mobile_No),
                new SqlParameter("@e",Gender),
                new SqlParameter("@f",Email),
                new SqlParameter("@g",Blood_Group),
                new SqlParameter("@h",Symptoms),
                new SqlParameter("@i",Relative_Name),
                new SqlParameter("@j",Diagnosis),
                new SqlParameter("@k",Diagnosis_By),
                new SqlParameter("@l",Medicine),
                new SqlParameter("@m",Admitted_Days),
                new SqlParameter("@n",Ward_Required),
                new SqlParameter("@o",Type_of_Ward),
            };
            return Connect.IUD(sql, param);
        }
        public DataTable GetPatient() /*patient full details */
        {
        string sql = "select * from tblPatient ";
            return Connect.GetTable(sql, null);
        }
        public DataTable SearchDetailsbyId(int Patient_Id) /* Search by Patient_Id*/
        {
            string sql = "select * from tblPatient where Patient_Id=@a";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@a",Patient_Id),
            };
            return Connect.GetTable(sql, param);
        }
        public DataTable SearchbyAddress(string Address) /* Search by Address when search button is clicked*/
        {
            string sql = "select * from tblPatient where Address=@a";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@a",Address),
            };
            return Connect.GetTable(sql, param);
        }
        public DataTable SearchDetailsbyAddress(string Address) /* Search by Address if user type one letter*/
        {
            string sql = "select * from tblPatient where Address like @a";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@a",Address+"%"),
            };
            return Connect.GetTable(sql, param);
        }
        //public DataTable GetPatientById(int Patient_Id) /*n Patient informartion from tblPatient*/
        //{
        //    string sql = "select * from tblPatient where Patient_Id=@a";
        //    SqlParameter[] param = new SqlParameter[]
        //    {
        //        new SqlParameter("@a",Patient_Id),
        //    };
        //    return Connect.GetTable(sql, param);
        //}
         public int DeletePatient(int Patient_Id) /*delete single patient details from tblPatient Details*/
        {
            string sql = "delete  from tblPatient where Patient_Id=@a";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@a",Patient_Id),
            };
            return Connect.IUD(sql, param);
        }
       
        //Update all patient details from tblPatient
        public int UpdatePatient(string Name, int Age, string Address, string Mobile_No, string Gender, string Email, string Blood_Group, string Symptoms, string Relative_Name, string Diagnosis, string Diagnosis_By, string Medicine, int Admitted_Days, string Ward_Required, string Type_of_Ward,int Patient_Id )
        {
            string sql = "update  tblPatient set Name=@a,Age=@b,Address=@c,Mobile_No=@d,Gender=@e,Email=@f,Blood_Group=@g,Symptoms=@h,Relative_Name=@i,Diagnosis=@j,Diagnosis_By=@k,Medicine=@l,Admitted_Days=@m,Ward_Required=@n,Type_of_Ward=@o where Patient_Id=@p";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@a",Name),
                new SqlParameter("@b",Age),
                new SqlParameter("@c",Address),
                new SqlParameter("@d",Mobile_No),
                new SqlParameter("@e",Gender),
                new SqlParameter("@f",Email),
                new SqlParameter("@g",Blood_Group),
                new SqlParameter("@h",Symptoms),
                new SqlParameter("@i",Relative_Name),
                new SqlParameter("@j",Diagnosis),
                new SqlParameter("@k",Diagnosis_By),
                new SqlParameter("@l",Medicine),
                new SqlParameter("@m",Admitted_Days),
                new SqlParameter("@n",Ward_Required),
                new SqlParameter("@o",Type_of_Ward),
                new SqlParameter("@p",Patient_Id)

            };
            return Connect.IUD(sql, param);
        
       }
        //Bill calculation
        public int BillCalculation(int AdmittedDays,int chargeperday,int medicinefees,int doctorfees)
        {
            return AdmittedDays*chargeperday+medicinefees+doctorfees;
            
        }

    }
}