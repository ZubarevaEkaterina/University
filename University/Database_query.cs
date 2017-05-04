using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class Database_query
    {

        public string select_command(string table, string columns, string condition)
        {
            Connection database = new Connection();
            string status = "";
            database.QueryExecuteReader("SELECT "+ columns+ " from ["+ table +"]" + condition + ";");

            while (database.reader.Read())
            {
              status = database.reader.GetString(0);
            }
            
            database.reader.Close();
            database.CloseConnection();
            return status;
        }
    }
}
