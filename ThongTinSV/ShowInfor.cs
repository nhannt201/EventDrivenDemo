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
    public partial class frmInfo : Form
    {
        public frmInfo(string id, string name, string country, string gender, string adr, string lang)
        {
            InitializeComponent();
            lb_id.Text += id;
            lb_name.Text += name;
            lb_gender.Text += gender;
            lb_adr.Text += adr;
            lb_country.Text += country;
            lb_lang.Text += lang;
        }

        private void btQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
