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
     partial class Schedule_form : Form
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
            
           dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
           

        }



        public void Schedule_form_v(Schedule sch, int count, string gr)
          {


            for (int i = 0; i < count; i++)
            {

                dataGridView1.Rows[(sch.day[i].lesson.time.time) - 1].Cells[sch.day[i].day - 1].Value = sch.day[i].lesson.subject.subject + ", "  + sch.day[i].lesson.cabinet.number + ", " + sch.day[i].lesson.teacher.name + ", " + sch.day[i].lesson.type.type;
                
            }

            label1.Text = "Расписание для " + gr;
                
            
    }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Добавить_Click(object sender, EventArgs e)
        {
           Group_form add = new Group_form();
            add.Show();
        }
    }
}
