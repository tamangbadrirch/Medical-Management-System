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
    public partial class AddPatient : Form
    {
        public AddPatient()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        Patient pt = new Patient();
        private void btnSave_Click(object sender, EventArgs e)
        {
            string msg = Validation();
            if (string.IsNullOrEmpty(msg))
            {
                int i = pt.CreatePatient(txtName.Text, Convert.ToInt32(txtAge.Text), txtAddress.Text, txtMobile.Text, txtGender.Text, txtEmail.Text, txtblood.Text, txtSymptom.Text, txtRelative.Text, txtDiagnosis.Text, txtDiagnosisBy.Text, richTxtMedicine.Text, Convert.ToInt32(txtAdmittedDays.Text), cmbWardreq.Text, cmbTypeofWard.Text);
                if (i > 0)
                {
                    MessageBox.Show("Patient Created !!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show(msg);
            }
            Reset(); 
        }
        public string Validation()
        {
            string res = string.Empty;
            double outMobileNo;
            double outAge;
            bool isMobileNo=double.TryParse(txtMobile.Text,out outMobileNo);   /*Convert int to bool(true/false) for mblno*/
            bool isAge =double.TryParse(txtAge.Text, out outAge);             /*Convert int to bool(true/false) for age*/
            if(string.IsNullOrEmpty(txtName.Text))
            {
                res = "Please enter Name.";
            }
            else if(!isAge)/*enter age in int */
            {
                res = "Please enter valid Age";
            }
            else if(string.IsNullOrEmpty(txtAddress.Text))
            {
                res = "Please enter Address";
            }
            else if(!isMobileNo) /*enter mblno  is int */
            {
                res = "Please enter valid Mobile No.";
            }
            else if(string.IsNullOrEmpty(txtGender.Text))
            {
                res = "Please select Gender.";
            }
            else if(string.IsNullOrEmpty(txtEmail.Text))
            {
                res = "Please enter Email.";
            }
            else if(string.IsNullOrEmpty(txtblood.Text))
            {
                res = "Please select Blood Group";
            }
            else if(string.IsNullOrEmpty(txtSymptom.Text))
            {
                res = "Please enter Symptoms";
            }
            else if(string.IsNullOrEmpty(txtRelative.Text))
            {
                res = "Please enter Relative name";
            }
            else if (string.IsNullOrEmpty(txtDiagnosis.Text))
            {
                res = "Please enter Diagnosis";
            }
            else if (string.IsNullOrEmpty(txtDiagnosisBy.Text))
            {
                res = "Please enter Diagnosis By Name";
            }
            else if (string.IsNullOrEmpty(richTxtMedicine.Text))
            {
                res = "Please enter Medicine.";
            }
            //else if(cmbWardreq.Text=="No")
            //{
            //    cmbTypeofWard.dis
            //}
            return res;
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
            richTxtMedicine.Clear();
            txtAdmittedDays.Clear();
            cmbWardreq.SelectedIndex =0;
            cmbTypeofWard.SelectedIndex = 0;
        }

        private void AddPatient_Load(object sender, EventArgs e)
        {
            cmbWardreq.SelectedIndex = 0;
            cmbTypeofWard.SelectedIndex = 0;
            txtblood.SelectedIndex = 0;
            txtGender.SelectedIndex = 0;
        }
    }
}
