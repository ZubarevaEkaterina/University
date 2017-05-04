using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class Authorization
    {
        private User user;
        
        public void authorize(string login, string password)
        { string role;

            user = new User();
           role = user.Get_role(login, password);
           
            switch (role)
            {
                case "Админ":
                    Admin_form adm = new Admin_form();
                    adm.ShowDialog();
                    break;
                case "Студент":
                    Student_form st = new Student_form();
                    st.ShowDialog();
                    break;
                case "Учитель":
                    Teacher_form teach = new Teacher_form();
                    teach.ShowDialog();
                    break;
                default:
                    Authorization_form f = new Authorization_form();
                    f.error("Неправильное имя или пароль");
                    break;
                    

            }


        }
    }
}
