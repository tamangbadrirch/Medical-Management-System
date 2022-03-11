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
    public partial class ViewDetaills : Form
    {
        public ViewDetaills()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        Patient pt = new Patient();
        private void ViewDetaills_Load(object sender, EventArgs e)
        {
            DataTable dt = pt.GetPatient();
            dvgViewdetails.DataSource = dt;
            
        }

        private void dvgViewdetails_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int Patient_Id = Convert.ToInt32(dvgViewdetails.CurrentRow.Cells[0].Value.ToString());
            Update up =new Update();
            up.Patient_Id = Convert.ToInt32(dvgViewdetails.CurrentRow.Cells[0].Value.ToString());
            up.Show();
            this.Hide();

        }
    }
}
