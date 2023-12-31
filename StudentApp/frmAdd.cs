using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StudentApp
{
    public partial class frmAdd : Form
    {
        public frmAdd()
        {
            InitializeComponent();
        }

        private void frmAdd_Load(object sender, EventArgs e)
        {

        }
        int num1, num2;
        private void btnCal_Click(object sender, EventArgs e)

        {
            
           
            if ((String.IsNullOrEmpty(txtNum1.Text)))
            {
                MessageBox.Show("Please type Num1!", "Warmed" );
                txtNum1.Focus();
                return;
            }  if ((String.IsNullOrEmpty(txtNum2.Text)))
            {
                MessageBox.Show("Please type Num2!");
                txtNum2.Focus();
                return;
            }
           
                try { 
                num1 = int.Parse(txtNum1.Text);           
                } catch (Exception ee)
                {
                MessageBox.Show("The value of num1 must be integer!");
                txtNum1.Clear();
                txtNum1.Focus();
                return;
                }
            try
            {
                num2 = int.Parse(txtNum2.Text);
            }
            catch (Exception ee)
            {

                MessageBox.Show("The value of num2 must be integer!", "Warming!");
                txtNum2.Clear();
                txtNum2.Focus();
                return;
            }
           
            int res = (num1 + num2);
            txtRes.Text = res.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            txtRes.Clear();
        }
    }
}
