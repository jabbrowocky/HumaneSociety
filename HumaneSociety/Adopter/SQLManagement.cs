using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
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
        //public string GetQueryString()
        //{
        //    string queryString;

        //    return queryString;
        //}
        public void NewQuery(string queryString)
        {
            command = new SqlCommand();
            command.CommandText = queryString;
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            List<string> AddTo = new List<string>();
            OpenConnection();
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Console.WriteLine("{0}\t{1}", reader.GetInt32(0),
                        reader.GetString(1));
                }
            }
            else
            {
                Console.WriteLine("No rows found.");
            }
            reader.Close();

            Console.ReadLine();
            CloseConnection();
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