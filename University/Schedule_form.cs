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
    public partial class Schedule_form : Form
    {
        public Schedule_form()
        {
            InitializeComponent();
            Width = 1050;
            dataGridView1.Width = 1035;
            dataGridView1.Height = 700;
            Height = 700;
            StartPosition = FormStartPosition.CenterScreen;
            dataGridView1.RowCount = 8;
            dataGridView1.ColumnCount = 7;

            
            DataGridViewRow row = dataGridView1.Rows[0];
            for (int i = 0; i < 7; i++)
            {
                dataGridView1.Columns[i].Width = 140;
                dataGridView1.Rows[i].Height = 80;
                dataGridView1.Rows[i].HeaderCell.Value = (i + 1).ToString();
              
            }
         
            dataGridView1.Columns[0].HeaderCell.Value = "Понедельник";
            dataGridView1.Columns[1].HeaderCell.Value = "Вторник";
            dataGridView1.Columns[2].HeaderCell.Value = "Среда";
            dataGridView1.Columns[3].HeaderCell.Value = "Четверг";
            dataGridView1.Columns[4].HeaderCell.Value = "Пятница";
            dataGridView1.Columns[5].HeaderCell.Value = "Суббота";
            dataGridView1.Columns[6].HeaderCell.Value = "Воскресение";
            
    }



             public void Schedule_form_v (Lesson.les [] les)
          {
            
            
            

            for (int i = 0; i < les.Length; i++)
            {
                
                dataGridView1.Rows[(les[i].time)-1].Cells[les[i].day-1].Value = les[i].subject + "" + les[i].type;
            }
            
                
            
    }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
