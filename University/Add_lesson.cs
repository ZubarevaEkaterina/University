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
        public void Create_les(string group)
        {
            var Add_Lesson = new Add_lesson()
            {
                day = new Weekday()

            };
            Connection database = new Connection();
            //  database.QueryExecuteReader("SELECT Lesson.cabinet, Lesson.type, Lesson.Weekday, Subject.subject_name, Lesson.Time, Subject.Teacher_name FROM Subject INNER JOIN Lesson ON Subject.[id] = Lesson.[subject] WHERE Subject.[group] = '" + group + "'");



        }

        public void box_day(int day1, string subject, int time, string cabinet, string teacher, string type)
        {
            day = new Weekday();


            Add_Lesson.day.day = day1;
            day.lesson.time.time = time;
            day.lesson.subject.subject = subject;
            day.lesson.cabinet.number = cabinet;
            day.lesson.type.type = type;
            day.lesson.teacher.name = teacher;

        }
    }
}



