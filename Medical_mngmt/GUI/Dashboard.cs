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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //private void tCToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    TermsandCondition tc = new TermsandCondition();
        //    tc.Show();
        //}

        //private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Form1 fm = new Form1();
        //    fm.Show();
        //    this.Hide();
        //}

        private void tcToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            TermsandCondition tc = new TermsandCondition();
            tc.Show();

        }

        private void logOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete dt = new Delete();
            dt.Show();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Update up = new Update();
            up.Show();
        }

        //private void addPatientRecordToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    AddPatient ap=new AddPatient();
        //    ap.Show();
        //}

        private void billToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bill bll=new Bill();
            bll.Show();
        }

        private void formatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewDetaills vd=new ViewDetaills();
            vd.Show();
        }

        //private void searchlToolStripMenuItem1_Click(object sender, EventArgs e)
        //{
        //    Search sr=new Search();
        //    sr.Show();
        //}

        private void searchByPatientIdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search sr = new Search();
            sr.Show();
        }

        private void searchByAddressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchByAddress sd=new SearchByAddress();
            sd.Show();
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPatient ad = new AddPatient();
            ad.Show();
        }
    }
}
