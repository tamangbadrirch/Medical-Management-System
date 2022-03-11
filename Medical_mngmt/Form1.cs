using Medical_mngmt.BLL;
using Medical_mngmt.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Medical_mngmt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void llHideShow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{

        //}

        //private void btncheck_CheckedChanged(object sender, EventArgs e)
        //{

        //}

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtUsername.Clear();
            cmbUsertype.SelectedIndex = 0;
        }
        private string Validation()
        {
            string res = string.Empty;
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                res = "Username cannot be blank.";
            }
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                res = "Password cannot be blank.";
            }
            return res;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string validationmsg = string.Empty;
            validationmsg = Validation();
            if (string.IsNullOrEmpty(validationmsg))
            {
                if (cmbUsertype.Text=="Admin" && txtPassword.Text=="admin" && txtUsername.Text=="admin")
                {
                    Admin ad = new Admin();
                    ad.Show();
                    this.Hide();
                }
                else
                {
                   SqlConnection con = Connect.GetConnection();
                   string sql = "select * from tblAdmin where [Name] = '" + txtUsername.Text + "'   and [Password] = '" + txtPassword.Text +"' ";
                   SqlCommand cmd=new SqlCommand(sql,con);
                   SqlDataAdapter da=new SqlDataAdapter(cmd);
                    DataTable dt=new DataTable();
                    da.Fill(dt);
                   if (dt.Rows.Count>0)
                    {
                        if(cmbUsertype.Text=="User")
                        {
                            Dashboard ds = new Dashboard();
                            ds.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Username and Password.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username and Password.");
                    }
;                }
            }
            else
            {
                MessageBox.Show(validationmsg);
            }

        }

        private void txtHideShow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(txtHideShow.Text=="Show")
            {
                txtHideShow.Text = "Hide";
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtHideShow.Text = "Show";
                txtPassword.PasswordChar ='*';
            }
        }

        private void llForgetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgetPassword fp=new ForgetPassword();
            fp.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbUsertype.SelectedIndex = 0;
        }
    }
}
