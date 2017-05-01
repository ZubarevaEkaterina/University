using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace University
{
   public class Lesson
    {
      
            public int [] day;
            public int []time;
            public string[] subject;
            public string[] cabinet;
            public string[] type;
            public string [] teacher;



        public void GetLesson(string group)
        {
           
            int count = 0;

            Connection database = new Connection();
            database.QueryExecuteReader("SELECT  Count(*) AS [Count - Lesson] FROM Subject INNER JOIN Lesson ON Subject.[id] = Lesson.[subject] group by Subject.[group] HAVING Subject.[group] = '" + group + "'");
            while (database.reader.Read())
            {
                count = database.reader.GetInt32(0);
            }
            database.reader.Close();
            database.CloseConnection();
            var lesson = new Lesson()
            {
                day = new int[8],
                time = new int[8],
                subject = new string[count],
                cabinet = new string[count],
                type = new string[count],
                teacher = new string[count]

            };

            database.QueryExecuteReader("SELECT Lesson.cabinet, Lesson.type, Lesson.Weekday, Subject.subject_name, Lesson.Time, Subject.Teacher_name FROM Subject INNER JOIN Lesson ON Subject.[id] = Lesson.[subject] WHERE Subject.[group] = '" + group + "'");
            
           
            int i = 0;
        
            while (database.reader.Read())
            {
               
                    lesson.day[i] = database.reader.GetInt32(2);
                    lesson.time[i] = database.reader.GetInt32(4);
                    lesson.subject[i] = database.reader.GetString(3);
                    lesson.cabinet[i] = database.reader.GetString(0);
                    lesson.type[i] = database.reader.GetString(1);
                    lesson.teacher[i] = database.reader.GetString(5);
                    i++;
                }

            

            database.reader.Close();
                database.CloseConnection();
            
         
          Schedule_form sc = new Schedule_form();
           sc.Schedule_form_v(lesson, count);
           sc.ShowDialog();

            }
        }
      }                      
