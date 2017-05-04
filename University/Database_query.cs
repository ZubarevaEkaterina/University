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
            string result = "";
            database.QueryExecuteReader("SELECT "+ columns+ " from ["+ table +"]" + condition + ";");

            while (database.reader.Read())
            {
              result= database.reader.GetString(0);
            }
            
            database.reader.Close();
            database.CloseConnection();
            return result;
        }


        public void insert_command(string table, string columns, string condition)
        {

            Connection database = new Connection();
            database.QueryExecuteNon("INSERT INTO [" + table + "] (" + columns +")VALUES(" + condition + ");");
            database.CloseConnection();
        }
    }
}
