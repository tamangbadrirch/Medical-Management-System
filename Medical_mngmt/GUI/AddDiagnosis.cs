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
    public partial class AddDiagnosis : Form
    {
        public AddDiagnosis()
        {
            InitializeComponent();
        }
        BLL.Patient pt = new BLL.Patient();
        private void AddDiagnosis_Load(object sender, EventArgs e)
        {
            DataTable dt = pt.GetPatient();
            dgvDiagnosis.DataSource = dt;
        }
        int Patient_Id = 0;
        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
        public string Validation()
        {
            string res = string.Empty;
             if (string.IsNullOrEmpty(txtDiagnosis.Text))
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
        public void Reset()
        {
            txtDiagnosis.Clear();
            txtDiagnosisBy.Clear();
            richTxtMedicine.Clear();
            txtAdmittedDays.Clear();
            cmbWardreq.SelectedIndex = 0;
            cmbTypeofWard.SelectedIndex = 0;
        }

    }
}
