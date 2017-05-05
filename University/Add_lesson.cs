using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class Add_lesson
    {
        public Weekday day;
        public Group gr;
      
        public void Create_les(int day, string subject, int time, string cabinet, string type, string group)
        {
            int id_subject = 0;
            
/*
            var Add_Lesson = new Add_lesson()
            {
                
                gr = new Group()

            };

            Add_Lesson.gr.name = group;
            
            Add_Lesson.day.day = day1;
            Add_Lesson.day.lesson.time.time = time;
            Add_Lesson.day.lesson.subject.subject = subject;
            Add_Lesson.day.lesson.cabinet.number = cabinet;
            Add_Lesson.day.lesson.type.type = type;
            Add_Lesson.gr.name = group;*/

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



