﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.Trim() == "root" && txtusername.Text.Trim() == "root")
            {

                btnDel mainform = new btnDel();
                mainform.Show();
                this.Hide();
            }
            else {

                MessageBox.Show("please enter the username, and the password and try again");
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtusername.Focus();
        }
    }
}
