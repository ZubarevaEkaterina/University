using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class Create_user
    {
        public Create cr = new Create();

        public void create(string login, string password, string role)

        {
          

            if (login != "" & password != "" & role != "")
            {
                Database_query query = new  Database_query();
                query.insert_command("User", "Login, [Password], status", "'" + login + "', '" + password + "', '" + role + "'");

                cr.Message("Пользователь создан");
            }
           else cr.Message("Заполнены не все поля");



        }


        public void delete(string login, string password, string role)

        {

            if (login != "" )
            {

                Database_query query = new Database_query();
                query.delete_command("User", "login = '" + login + "'");
            }
            else
            cr.Message("Введите логин пользователя");





        }

    }
    }
