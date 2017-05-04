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
        public string role;
        public string login;
        public string password;

        public string Get_role(string login, string password)
        {
            this.login = login;
            this.password = password;
            Database_query q = new Database_query();

            role = q.select_command("User", "User.status", "WHERE User.Login = '" + login + "' and User.Password = '" + password + "'");

            return role;

        }

    }
    }
