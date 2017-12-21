using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class Program
    {
        static void Main(string[] args)
        {
            SQLConnect sqlConnect = new HumaneSociety.SQLConnect();
            sqlConnect.CreateSQLConnect();
            sqlConnect.SearchSQLQuery("SELECT * FROM [dbo].[Animal_Type] WHERE ID < 3");
            Console.ReadLine();
            Ledger ledger = new HumaneSociety.Ledger();
            Shelter_Management shelter_management = new Shelter_Management(ledger, sqlConnect);
            shelter_management.MainMenu();
        }
    }
}

