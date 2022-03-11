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
    public partial class SearchByAddress : Form
    {
        public SearchByAddress()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        BLL.Patient pt = new BLL.Patient();
        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = pt.SearchbyAddress(txtAddress.Text);
            if (dt.Rows.Count > 0)
            {
                dgvSearch.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Wrong Address");
            }
            txtAddress.Clear();

        }

        //private void txtAddress_TextChanged(object sender, EventArgs e)
        //{

        //}
    }
    
}
