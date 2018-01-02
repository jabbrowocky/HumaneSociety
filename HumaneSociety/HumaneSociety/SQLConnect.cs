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
        public List<Animal> SearchSQLQuery(string queryString)
        {
            List<Animal> SearchAnimalList = new List<Animal>();
            conn.Open();
            command = new SqlCommand(queryString, conn);
            reader = command.ExecuteReader();
            try
            {
                Console.WriteLine("[{0}]\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}", "index", "Name", "Species", "Age", "Weekly Food", "Kennel #", "Cost", "Vaccinated", "Adopted");
                int i = 1;
                while (reader.Read())
                {
                    Console.WriteLine(String.Format("[{0}]\t{1}\t{2}\t{3}\t{4}\t\t{5}\t\t{6}\t{7}\t\t{8}", i, reader["Pet_Name"], reader["Animal_Type"], reader["Age"], reader["Food_Consumption"], reader["Room_Number"], reader["Cost"], reader["Shot_Status"], reader["Adoption_Status"]));
                    i++;
                    Animal animal = new Animal(reader["ID"].ToString(), reader["Pet_Name"].ToString(), reader["Animal_Type"].ToString(), reader["Age"].ToString(), reader["Cost"].ToString(), reader["Room_Number"].ToString(), reader["Adoption_Status"].ToString(), reader["Shot_Status"].ToString(), reader["Food_Consumption"].ToString());
                    SearchAnimalList.Add(animal);
                }
            }
            finally
            {
                reader.Close();
                conn.Close();
            }
            return SearchAnimalList;
        }
        public string ConstructSearhString(List<string> valuesString, List<string> columnsString)
        {
            int i = 0;
            string queryString = "SELECT * FROM [Animals] ";
            while (i < valuesString.Count)
            {
               if(i == 0)
                {
                    queryString += String.Format("WHERE {0} = '{1}'", columnsString[i], valuesString[i]);
                    i++;
                    break;
                }
               if(i == valuesString.Count)
                {
                    queryString += String.Format(" AND {0} = '{1}';", columnsString[i], valuesString[i]);
                    i++;
                    break;
                }
                else
                {
                    queryString += String.Format(" AND {0} = '{1}'", columnsString[i], valuesString[i]);
                    i++;
                    break;
                }
            }
            return queryString;

        }
        public void AddData(string inputData)
        {
            conn.Open();
            command = new SqlCommand(inputData, conn);
            try
            {
               command.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }
        public string ConstructAddDataString(List<string> valuesList, List<string> columnsList)
        {
            string valuesString = string.Join(", ", valuesList);
            string columnsString = string.Join(", ", columnsList);
            string dataString = string.Format("INSERT into Animals ({0}) VALUES ({1})", columnsString, valuesString);           
            return dataString;
        }
        public string ConstructAlterRowString(string ID, string trait, string value)
        {
            string update = string.Format("UPDATE Animals SET {0} = {1} WHERE ID = {2}", trait, value, ID);
            return update;
        }
    }
}
