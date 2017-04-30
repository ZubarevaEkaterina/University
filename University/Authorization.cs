﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University
{
    public partial class Authorization : Form
    {
        private string login;
        private string password;

        public Authorization()
        {
            InitializeComponent();
        }

        private void Authorization_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            User check = new User();
            check.Authorize(login, password);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            login = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            password = textBox2.Text;
        }
    }
}
