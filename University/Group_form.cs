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
    public partial class Group_form : Form
    {
        public Group_form()
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
           
         Schedule sch = new Schedule();
            sch.GetSchedule(comboBox1.Text);
        }

        public void show_sch()
        {
            Schedule sch = new Schedule();
            sch.GetSchedule(comboBox1.Text);
        }

        public void create_new()
        {
            Add_form sch = new Add_form();
            sch.Show();
            Add_lesson les = new Add_lesson();
            les.Create_les(comboBox1.Text);
        }

    }
       

        
    
}
