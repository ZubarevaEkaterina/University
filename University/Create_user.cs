using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class Create_user
    {
        private User user;

        public void create(string login, string password, string role)

        {
            user = new User();

            if (login != "" & password != "" & role != "")
            {
                Database_query query = new  Database_query();
                query.insert_command("User", "Login, [Password], status", "'" + login + "', '" + password + "', '" + role + "'");
/*
                Connection database = new Connection();
                database.QueryExecuteNon("INSERT INTO [User] ( Login, [Password], status )VALUES('" + login + "', '" + password + "', '" + role + "');");
                database.CloseConnection();*/

            }

        }

        }
    }
