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
    public partial class Group : Form
    {
        public Group()
        {
            InitializeComponent();
            Connection database = new Connection();
            database.QueryExecuteReader("SELECT Group.[Group_name] FROM[Group];");
            while (database.reader.Read())
            {
                comboBox1.Items.Add(database.reader["Group_name"].ToString());
            }
            database.reader.Close();
            database.CloseConnection();

            
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //User person = new User();
         //  var form = new Schedule_form(comboBox1.Text);
         //   form.ShowDialog();
         Lesson les = new Lesson();
            les.GetLesson(comboBox1.Text);
        }
    }
       

        
    
}
