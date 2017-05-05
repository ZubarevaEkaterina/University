using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class Add_lesson
    {
      
        public void Create_les(int day, string subject, int time, string cabinet, string type, string group)
        {
            int id_subject = 0;
            
            Connection database = new Connection();
            database.QueryExecuteReader("SELECT id FROM Subject WHERE Subject.subject_name = '"+ subject + "' and Subject.group = '"+ group +"';");

            while (database.reader.Read())
            {
                id_subject = database.reader.GetInt32(0);
            }
            database.reader.Close();
            database.CloseConnection();

            database.QueryExecuteNon("INSERT INTO Lesson(cabinet, type, weekday, subject, [time]) VALUES('" + cabinet + "', '" + type + "', " + day + ", " + id_subject + ", " + time+");");
            database.CloseConnection();

            Add_form add = new Add_form();
            add.Message("Событие создано");
            Schedule sc = new Schedule();

            sc.GetSchedule(group);
        }
    }
}



