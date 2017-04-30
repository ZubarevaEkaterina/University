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
            database.connection.Open();
           database.query.Connection = database.connection;
            string otv = string.Empty;
         database.query.CommandText = "SELECT User.status from [User] WHERE User.Login = '" +  login +   "' and User.Password = '"+ password + "';".ToString();
 //    database.QueryExecuteReader("SELECT User.status from [User] WHERE User.Login =  +  login +  + " and User.Password = "12" = " + Convert.ToString(login) + " and Password = " + Convert.ToString(password) + "; ";);

            database.reader = database.query.ExecuteReader();

            while (database.reader.Read())
            {
                otv = database.reader.GetString(0);
            }
            database.reader.Close();
           database.CloseConnection();

            if (otv == "Админ")
            {
                Admin_form sch = new Admin_form();
                sch.ShowDialog();
            }

            if  (otv == "Студент")
            {
               Student_form sch = new Student_form();
                sch.ShowDialog();
            }

            if (otv == "Учитель")
            {
                Teacher_form sch = new Teacher_form();
                sch.ShowDialog();
            }

            Console.WriteLine(otv);

            


        //    database.CloseConnection();


        }

    }
    }
