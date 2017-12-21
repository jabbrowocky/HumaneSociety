using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace HumaneSociety
{
    class SQLConnect
    {
        public SqlConnection conn;
        public SqlCommand command;
        public SqlDataReader reader;
        public void CreateSQLConnect()
        {
            conn = new SqlConnection("Data Source =.; Initial Catalog = Humane Society; Integrated Security = True");
        }
        public void CreateSQLCommand(string queryString)
        {
            conn.Open();
            command = new SqlCommand(queryString, conn);
            reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    Console.WriteLine(String.Format("{0}, {1}, {2}", reader["ID"], reader["Species"]));
                }
            }
            finally
            {
                reader.Close();
                conn.Close();
            }
        }
        public void CreateSQLReader()
        {
            reader = command.ExecuteReader();
        }

    }
}
