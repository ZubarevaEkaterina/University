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
       // public void Create_les(string group)
        /*{
            var Add_Lesson = new Add_lesson()
            {
                day = new Weekday()

            };*/
            Connection database = new Connection();
            //  database.QueryExecuteReader("SELECT Lesson.cabinet, Lesson.type, Lesson.Weekday, Subject.subject_name, Lesson.Time, Subject.Teacher_name FROM Subject INNER JOIN Lesson ON Subject.[id] = Lesson.[subject] WHERE Subject.[group] = '" + group + "'");



      //  }

        public void Create_les(int day, string subject, int time, string cabinet, string type, string group)
        {/*

            var Add_Lesson = new Add_lesson()
            {
                day = new Weekday(),
                gr = new Group()

            };

            Add_Lesson.day.day = day1;
            Add_Lesson.day.lesson.time.time = time;
            Add_Lesson.day.lesson.subject.subject = subject;
            Add_Lesson.day.lesson.cabinet.number = cabinet;
            Add_Lesson.day.lesson.type.type = type;
            Add_Lesson.gr.name = group;*/

            Connection database = new Connection();
            database.QueryExecuteNon("INSERT INTO [Lesson] (cabinet, type, weekday, subject, time )VALUES('" + cabinet + "', '" + type + "', '" + day + "', '" + subject + "', '" + time+"');");
            database.CloseConnection();

            
        }
    }
}



