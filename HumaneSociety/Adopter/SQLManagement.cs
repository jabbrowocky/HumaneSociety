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
        SqlDataReader reader;

        public SQLManagement()
        {
            this.connection = new SqlConnection("Data Source=JABBROWOCKY;Initial Catalog=HumaneSociety;Integrated Security=True");
            
        }
        public void NewQuery(string queryString)
        {
            connection.Open();
            command = new SqlCommand(queryString, connection);
            reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    Console.WriteLine(String.Format("{0}, {1}", reader["ID"], reader["Species"]));
                }
            }
            finally
            {
                reader.Close();
                connection.Close();
            }
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