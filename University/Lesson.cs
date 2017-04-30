using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace University
{
   public class Lesson
    {
      public  struct les
        {
            public int day;
            public int time;
            public string subject;
            public string cabinet;
            public string type;
            public string teacher;
            

        }
        public void GetLesson(string group)
        {
            Connection database = new Connection();
            database.QueryExecuteReader("SELECT Lesson.cabinet, Lesson.type, Lesson.Weekday, Subject.subject_name, Lesson.Time, Subject.Teacher_name FROM Subject INNER JOIN Lesson ON Subject.[id] = Lesson.[subject] WHERE Subject.[group] = '" + group + "'");
            les[] lesson = new les[2];





            //database.QueryExecuteReader("SELECT Group.Group_name, Lesson.cabinet, Lesson.type, Lesson.weekday, Subject.subject_name, Lesson.time FROM([Group] INNER JOIN Subject ON Group.[Group_name] = Subject.[group]) INNER JOIN Lesson ON Subject.[id] = Lesson.[subject] WHERE Group.[Group_name] = '" + group + "'" );
           
            while (database.reader.Read())
            {
                for (int i = 0; i < 2; i++)
                {
                    lesson[i].day = database.reader.GetInt32(2);
                    lesson[i].time = database.reader.GetInt32(4);
                    lesson[i].subject = database.reader.GetString(3);
                    lesson[i].cabinet = database.reader.GetString(0);
                    lesson[i].type = database.reader.GetString(1);
                    lesson[i].teacher = database.reader.GetString(5);

                }

            }
            database.CloseConnection();
            // return lesson;
            Schedule_form sc = new Schedule_form();
            sc.Schedule_form_v(lesson);
            sc.ShowDialog();

            }
        }
      }                      
