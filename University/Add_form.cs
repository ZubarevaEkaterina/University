using System;
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
    public partial class Add_form : Form
    {
        public Add_form()
        {
            InitializeComponent();
         
            Connection database = new Connection();

            database.QueryExecuteReader("SELECT Group.[Group_name] FROM[Group];");
            while (database.reader.Read())
            {
                comboBox2.Items.Add(database.reader["Group_name"].ToString());
            }

            database.CloseConnection();

            database.QueryExecuteReader("SELECT Subject.[subject_name] FROM[Subject];");
            while (database.reader.Read())
            {
                comboBox1.Items.Add(database.reader["subject_name"].ToString());
            }

            database.CloseConnection();


            database.QueryExecuteReader("SELECT Type.[Type] FROM[Type];");
            while (database.reader.Read())
            {
                comboBox6.Items.Add(database.reader["Type"].ToString());
            }

            database.CloseConnection();

            int[] days = { 1, 2, 3, 4, 5, 6, 7 };
            

            for (int i = 0; i < days.Length; i++)
            {
                comboBox5.Items.Add(days[i]);
            }

            int[] time = { 1, 2, 3, 4, 5, 6, 7, 8 };

            for (int i = 0; i < time.Length; i++)
            {
                comboBox3.Items.Add(time[i]);
            }


            database.QueryExecuteReader("SELECT Cabinet.[number] FROM[Cabinet];");
            while (database.reader.Read())
            {
                comboBox4.Items.Add(database.reader["number"].ToString());
            }


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           Add_lesson add = new Add_lesson();
            add.Create_les(Convert.ToInt32(comboBox5.Text), comboBox1.Text, Convert.ToInt32(comboBox3.Text), comboBox4.Text, comboBox6.Text, comboBox2.Text);
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void Message (string text)
        { var res = MessageBox.Show(text); }
    }
}
