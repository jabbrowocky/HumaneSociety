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
        public void SearchSQLQuery(string queryString)
        {
            conn.Open();
            command = new SqlCommand(queryString, conn);
            reader = command.ExecuteReader();
            try
            {
                int i = 1;
                while (reader.Read())
                {
                    Console.WriteLine(String.Format("[{0}] {1} {2}", i, reader["ID"], reader["Species"]));
                    i++;
                }
            }
            finally
            {
                reader.Close();
                conn.Close();
            }
        }
        public string ConstructSearhString(List<string> valuesString, List<string> columnsString)
        {
            int i = 0;
            string queryString = "SELECT * FROM [Animals] ";
            while (i < valuesString.Count-1)
            {
               if(i == 0)
                {
                    queryString += String.Format("WHERE {0} = {1}", columnsString[i], valuesString[i]);
                    i++;
                } 
               else
                {
                    queryString += String.Format(" AND {0} = {1}", columnsString[i], valuesString[i]);
                    i++;
                }
            }
            return queryString;

        }

    }
}
