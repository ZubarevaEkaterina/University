using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace University
{
    class Connection
    {
       // public OleDbConnection connection = new OleDbConnection(@"provider=Microsoft.ACE.OLEDB.12.0;Data Source= c:\users\user\documents\visual studio 2015\Projects\University\University\Schedule.accdb");
        public OleDbConnection connection = new OleDbConnection(University.Properties.Settings.Default.Schedule);
        public OleDbCommand query = new OleDbCommand();
        public OleDbDataReader reader;

        
        public void QueryExecuteReader(string textCommand)
        {
            query.Connection = connection;
            connection.Open();
            query.CommandText = textCommand;
            query.Connection = connection;
            reader = query.ExecuteReader();
           

        }

      
        public void QueryExecuteNon(string textCommand)
        {
            connection.Open();
            query.Connection = connection;
            query.CommandText = textCommand;
            query.ExecuteNonQuery();
          
        }


        public void CloseConnection()
        {
            connection.Close();
        }
    }
}
