using Medical_mngmt.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Medical_mngmt
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        //private void lblExit_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //}

        private void lblExit_Click_1(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Close();
        }

        //private void txtName_KeyDown(object sender, KeyEventArgs e)
        //{
            
        //}

        //private void txtAddress_KeyDown(object sender, KeyEventArgs e)
        //{
            
        //}

        //private void txtMobileNo_KeyDown(object sender, KeyEventArgs e)
        //{
           
        //}

        //private void txtGender_KeyDown(object sender, KeyEventArgs e)
        //{
           
        //}
        User u = new User();
        private void btnSave_Click(object sender, EventArgs e)
        {
            string msg = Validation();
            if(string.IsNullOrEmpty(msg))
            {
                int i = u.CreateUser(txtName.Text, txtAddress.Text, txtMobileNo.Text, txtGender.Text, txtEmail.Text, txtPassword.Text);
                if (i > 0)
                {
                    MessageBox.Show("User Created!!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Loadgrid();
                    Reset();
                }
            }
            
            else
            {
                MessageBox.Show(msg);
            }
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            Loadgrid();
        }

        private void Loadgrid()
        {
            DataTable dt = u.GetUser();
            dgvAdmin.DataSource = dt;
        }
        public string Validation()
        {
            string res = string.Empty;
            double convertedNumber;
            bool IsNumeric = double.TryParse(txtMobileNo.Text, out convertedNumber);
            if(string.IsNullOrEmpty(txtName.Text))
            {
                res = "Please enter Name";
            }
            else if(string.IsNullOrEmpty(txtAddress.Text))
            {
                res = "Please enter address";
            }
            else if(! IsNumeric)
            {
                res = "Invalid Mobile No.";
            }
            else if(string.IsNullOrEmpty(txtGender.Text))
            {
                res = "Please enter gender";
            }
            else if(string.IsNullOrEmpty(txtEmail.Text))
            {
                res = "Please enter Email";
            }
            else if(string.IsNullOrEmpty(txtPassword.Text))
            {
                res = "Please enter Password";
            }
            return res;
        }

        //private void txtName_KeyDown_1(object sender, KeyEventArgs e)
        //{

        //}

        //private void txtAddress_KeyDown_1(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        txtMobileNo.Select();
        //    }
        //}

        //private void txtMobileNo_KeyDown_1(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        txtGender.Select();
        //    }
        //}

        //private void txtGender_KeyDown_1(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        txtPassword.Select();
        //    }
        //}

        //private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if(e.KeyCode==Keys.Enter)
        //    {
        //        txtPassword.Select();
        //    }
        //}
        public void Reset()
        {
            txtName.Clear();
            txtAddress.Clear();
            txtMobileNo.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            txtGender.SelectedIndex = 0;

        }

        private void dgvAdmin_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            UserId = Convert.ToInt32(dgvAdmin.CurrentRow.Cells[0].Value.ToString());
            DataTable dt = u.GetPatientById(UserId);
            txtName.Text = dt.Rows[0]["Name"].ToString();
            txtAddress.Text = dt.Rows[0]["Address"].ToString();
            txtMobileNo.Text = dt.Rows[0]["Mobile_No"].ToString();
            txtGender.Text = dt.Rows[0]["Gender"].ToString();
            txtEmail.Text = dt.Rows[0]["Email"].ToString();
            txtPassword.Text = dt.Rows[0]["Password"].ToString();
        }
        public int UserId = 0;
        //private void btnEdit_Click(object sender, EventArgs e)
        //{
            
        //}

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int i = u.UpdateUser(txtName.Text, txtAddress.Text, txtMobileNo.Text, txtGender.Text, txtEmail.Text, txtPassword.Text, UserId);
            if (i > 0)
            {
                MessageBox.Show("User updated successfully!!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Loadgrid();
                Reset();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = u.DeleteUser(UserId);
            if(i>0)
            {
                MessageBox.Show("User Deleted Successfully.");
                Loadgrid();
                Reset();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
          
        }
    }
}
