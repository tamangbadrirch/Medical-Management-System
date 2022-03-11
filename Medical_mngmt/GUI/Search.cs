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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //private void btnSearch_Click(object sender, EventArgs e)
        //{

        //}
        public int Patient_Id = 0;
        Patient pt = new Patient();
        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            Patient_Id = Convert.ToInt32(txtPatientId.Text);
            DataTable dt = pt.SearchDetailsbyId(Patient_Id);
            if (dt.Rows.Count > 0)
            {
                dgvSearch.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Invalid Patient_Id");
            }
            txtPatientId.Clear();

        }

        //private void txtPatientId_TextChanged(object sender, EventArgs e)
        //{

        //}
    }
}
