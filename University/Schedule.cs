using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
   class Schedule
    {
        public Weekday[] day;

        public void GetSchedule(string group)

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
            var schedule = new Schedule()
            {
                day = new Weekday[count]


            };
           
            database.QueryExecuteReader("SELECT Lesson.cabinet, Lesson.type, Lesson.Weekday, Subject.subject_name, Lesson.Time, Subject.Teacher_name FROM Subject INNER JOIN Lesson ON Subject.[id] = Lesson.[subject] WHERE Subject.[group] = '" + group + "'");

            int i = 0;

            while (database.reader.Read())
            {
               schedule.day[i] = new Weekday();
            

                schedule.day[i].day = database.reader.GetInt32(2);
                schedule.day[i].lesson.time.time = database.reader.GetInt32(4);
                schedule.day[i].lesson.subject.subject = database.reader.GetString(3);
                schedule.day[i].lesson.cabinet.number = database.reader.GetString(0);
                schedule.day[i].lesson.type.type = database.reader.GetString(1);
                schedule.day[i].lesson.teacher.name = database.reader.GetString(5);
                i++;
            }



            database.reader.Close();
            database.CloseConnection();


            Schedule_form sc = new Schedule_form();
            sc.Schedule_form_v(schedule, count);
            sc.ShowDialog();
        } } }