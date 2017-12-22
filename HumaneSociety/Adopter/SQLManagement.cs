using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Adopter
{
    class SQLManagement 
    {
        //SqlConnection connection;
        //SqlCommand command;
        //SqlDataReader reader;
        public HumaneSocietyDataSet dsHs;

        public SQLManagement()
        {
            //this.connection = new SqlConnection("Data Source=JABBROWOCKY;Initial Catalog=HumaneSociety;Integrated Security=True");
            dsHs = new HumaneSocietyDataSet();
                        
        }
        void StubOut()
        {
            
        }

        //public void OpenConnection()
        //{
        //    connection.Open();
        //}

        //public void CloseConnection()
        //{
        //    connection.Close();
        //}
    }
}