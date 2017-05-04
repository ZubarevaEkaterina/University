using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace University
{
     class Lesson
    {
       
        public Time time;
        public Subject subject;
        public Cabinet cabinet;
        public Type type;
        public Teacher teacher;


        public Lesson ()
        {
            time = new Time();
            subject = new Subject();
            cabinet = new Cabinet();
            type = new Type();
            teacher = new Teacher();

        }

    }

}