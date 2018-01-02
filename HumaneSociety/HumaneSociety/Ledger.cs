using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class Ledger
    {
        public float Revenue;

        public void AddRevenue(string cost)
        {
            float revenue = Int32.Parse(cost);
            Revenue += revenue;
        }
        public void DisplayLedger()
        {
            string revenue = Revenue.ToString();
            Console.WriteLine("$"+revenue);
            Console.ReadLine();
        }
    }
}
