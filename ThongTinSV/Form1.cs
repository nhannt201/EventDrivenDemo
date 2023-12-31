using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ThongTinSV
{
    public partial class frmStudent : Form
    {
        string id,  name,  country,  gender,  adr,  lang;
        public frmStudent()
        {
            InitializeComponent();      
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btQuit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtID.Text = ""; txtName.Text = ""; txtAdr.Text = "";
            cboCountry.SelectedIndex = 0;
            radFemale.Checked = false;
            radMale.Checked = true;
            ckChinese.Checked = false;
            ckEn.Checked = false;
            ckFre.Checked = false;
            ckKr.Checked = false;
            ckOther.Checked = false; ;
            txtID.Focus();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            id = txtID.Text;
            name = txtName.Text;
            adr = txtAdr.Text;
            if (radMale.Checked)
            {
                gender = radMale.Text;
            } else { gender = radFemale.Text; }
            country = cboCountry.SelectedItem.ToString();
            if (ckChinese.Checked)
            {
                lang += ckChinese.Text + " ";
            }
            if (ckEn.Checked)
            {
                lang += ckEn.Text + " ";
            }
            if (ckFre.Checked)
            {
                lang += ckFre.Text + " ";
            }
            if (ckKr.Checked)
            {
                lang += ckKr.Text + " ";
            }
            if (ckOther.Checked)
            {
                lang += ckOther.Text + " ";
            }
            lstName.Items.Add(name);
            frmInfo finfo = new frmInfo(id, name, country, gender, adr, lang);
            finfo.Show();
        }
    }
}
