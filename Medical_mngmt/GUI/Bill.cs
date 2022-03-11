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
    public partial class Bill : Form
    {
        public Bill()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        Patient pt=new Patient();
        public int Patient_Id = 0;
        private void btnSearch_Click(object sender, EventArgs e) /*search patient details from vw_PatientDetails*/
        {
            Patient_Id=Convert.ToInt32(txtPatientId.Text);
            DataTable dt = pt.SearchDetailsbyId(Patient_Id);
            if(dt.Rows.Count>0)
            {
                dgvBill.DataSource = dt;
            }
            txtPatientId.Clear();
        }

        private void btntotal_Click(object sender, EventArgs e)
        {
            int total = pt.BillCalculation(Convert.ToInt32(txtAdmit.Text),Convert.ToInt32(txtcharge.Text),Convert.ToInt32(txtmedicinefees.Text),Convert.ToInt32(txtDoctorfees.Text));
             txtTotal.Text=total.ToString();
        }
    }
}
