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
    public partial class TermsandCondition : Form
    {
        public TermsandCondition()
        {
            InitializeComponent();
            label2.Text = @"1.Each and Every patients are equal and we treat them equally.

2.If you have any problem then please kindly contact us and feel free.

3.Payment must be made available before patient leave the clinic.

4.Payment made is not refundable.

5.People should pre book their appoinments to avoid inconvinance.

6.In case of emergency extra charge is taken.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
