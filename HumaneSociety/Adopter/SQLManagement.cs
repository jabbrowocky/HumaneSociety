using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Adopter
{
    class SQLManagement : IDatabase
    {
        SqlConnection connection;
        SqlCommand command;

        public SQLManagement(SqlConnection connection, SqlCommand commands)
        {
            this.connection = new SqlConnection("Data Source=JABBROWOCKY;Initial Catalog=HumaneSociety;Integrated Security=True");
            
        }
        public void NewQuery(string queryString)
        {
            command = new SqlCommand(queryString, connection);
        }
        public void OpenConnection()
        {
            connection.Open();
        }

        public void CloseConnection()
        {
            connection.Close();
        }
    }
}