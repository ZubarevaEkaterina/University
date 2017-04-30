using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace University
{
    class User
    {
        public void Authorize(string login, string password)
        { 
            Connection database = new Connection();
            string otv = string.Empty;
  database.QueryExecuteReader("SELECT User.status from [User] WHERE User.Login = '" + login + "' and User.Password = '" + password + "';");

            while (database.reader.Read())
            {
                otv = database.reader.GetString(0);
            }

            database.reader.Close();
           database.CloseConnection();
           
                switch (otv)
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
                        throw new ArgumentException("Error");
                        
                }
            
         
           



        }

    }
    }
