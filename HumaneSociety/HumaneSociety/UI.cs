using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    static class UI
    {
        //Main menu
        //------------------
        //1. Add animal to DB
        //2. Check animal rooms (display all?)
        //3. Change animal adopted status
        //4. Change animal shot status
        //5. Pull up animal
        public static void DisplayMenu(string menu)
        {
            Console.WriteLine(menu);
        }
        public static string GetInput(int options)
        {
            int input = 0;
            bool flag1 = false;
            bool flag2 = false;
            while (!flag1 || !flag2)
            {
                while (int.TryParse(Console.ReadLine(), out input))
                {
                    flag1 = true;
                    break;
                }
                if (input <= options && input != 0)
                    {
                    flag2 = true;
                    }
                    else
                    {
                    flag2 = false;
                    }
            }
            
            string inputString = input.ToString();
            return inputString;
        }
    }
}
