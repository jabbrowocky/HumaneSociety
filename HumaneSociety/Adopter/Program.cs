using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adopter
{
    class Program
    {
        static void Main(string[] args)
        {
            //AdopterEnvironment StartPage = new AdopterEnvironment();
            SQLManagement sql = new SQLManagement();
            sql.NewQuery("SELECT * FROM Animal_Type");
        }
    }
}
