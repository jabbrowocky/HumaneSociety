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
            List<string> result;
            result = (from x in sql.dsHs.Animals where x.ID == 1 select x.Pet_Name).ToList();
            result.ForEach((x) => { Console.WriteLine(x); });
            
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
