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
    public partial class Create : Form
    {
        private string login;
        private string password;
        private string role;

        public Create()
        {
            InitializeComponent();
            string[] s = { "Студент", "Преподаватель", "Админ" };
            comboBox1.DataSource = s;
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            login = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            password = textBox2.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            role = comboBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!= "" & textBox2.Text != "" & comboBox1.Text != "")
            {

            
            Connection database = new Connection();
/*
                database. connection.Open();
                database. query.Connection = database.connection;
                database.query.CommandText = "INSERT INTO [User] ( [Login], [Password], [status] ) VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "', '" + comboBox1.Text + "');";
                database.query.ExecuteNonQuery();
                */
                database.QueryExecuteNon("INSERT INTO [User] ( Login, [Password], status )VALUES('" + textBox1.Text.ToString() + "', '" + textBox2.Text.ToString() + "', '" + comboBox1.Text.ToString() + "');");
            database.CloseConnection();
        }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Connection database = new Connection();
            database.QueryExecuteNon("delete from [User] where login = '" + login + "';");
            database.CloseConnection();
            MessageBox.Show("ре");
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
