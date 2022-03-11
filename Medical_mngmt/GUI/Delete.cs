using Medical_mngmt.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Medical_mngmt.GUI
{
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
         Patient pt = new Patient();
        public int Patient_Id = 0;
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Patient_Id=Convert.ToInt32(txtPatientId.Text.ToString()); 
            DataTable dt = pt.SearchDetailsbyId(Patient_Id);
            if(dt.Rows.Count>0)
            {
                txtName.Text = dt.Rows[0]["Name"].ToString();
                txtAge.Text = dt.Rows[0]["Age"].ToString();
                txtAddress.Text = dt.Rows[0]["Address"].ToString();
                txtMobile.Text = dt.Rows[0]["Mobile_No"].ToString();
                txtGender.Text = dt.Rows[0]["Gender"].ToString();
                txtEmail.Text = dt.Rows[0]["Email"].ToString();
                txtblood.Text = dt.Rows[0]["Blood_Group"].ToString();
                txtSymptom.Text = dt.Rows[0]["Symptoms"].ToString();
                txtRelative.Text = dt.Rows[0]["Relative_Name"].ToString();
                txtDiagnosis.Text = dt.Rows[0]["Diagnosis"].ToString();
                txtDiagnosisBy.Text = dt.Rows[0]["Diagnosis_By"].ToString();
                richTxtMedicine.Text = dt.Rows[0]["Medicine"].ToString();
                txtAdmittedDays.Text = dt.Rows[0]["Admitted_Days"].ToString();
                cmbWardreq.Text = dt.Rows[0]["Ward_Required"].ToString();
                cmbTypeofWard.Text = dt.Rows[0]["Type_of_Ward"].ToString();
            }
            else
            {
                MessageBox.Show("Invalid Patient_Id");
            }
            txtPatientId.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i=pt.DeletePatient(Patient_Id);

            if(i>0)
            { 
                
                    MessageBox.Show("Patient deleted successfully.");
             }
            else
            {
                MessageBox.Show("Invalid Patient Id.");
            }
           Reset();
        }
        public void Reset() /*clear all textbox*/
        {
            txtName.Clear();
            txtAge.Clear();
            txtAddress.Clear();
            txtMobile.Clear();
            txtGender.SelectedIndex = 0;
            txtEmail.Clear();
            txtblood.SelectedIndex = 0;
            txtSymptom.Clear();
            txtRelative.Clear();
            txtDiagnosis.Clear();
            txtDiagnosisBy.Clear();
            richTxtMedicine.ResetText();
            txtAdmittedDays.Clear();
            cmbWardreq.SelectedIndex=0;
            cmbTypeofWard.SelectedIndex=0;
        }

        private void Delete_Load(object sender, EventArgs e)
        {
            cmbWardreq.SelectedIndex = 0;
            cmbTypeofWard.SelectedIndex = 0;
            txtblood.SelectedIndex = 0;
            txtGender.SelectedIndex = 0;
        }
    }

}
