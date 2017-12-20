using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adopter
{
    static class UI
    {
        public static string DisplayOptions(string menuName, string menuOptionOne, string menuOptionTwo = null, string menuOptionThree = null, string menuOptionFour = null, string menuOptionFive = null)
        {

            int maxRange = 1;
            Console.WriteLine(menuName+"\n------------------------------\n");
            Console.WriteLine("1: {0}\n", menuOptionOne);
            if (menuOptionTwo != null) 
            {
                maxRange = 2;
                Console.WriteLine("2: {0}\n", menuOptionTwo);
            }
            if (menuOptionThree != null)
            {
                maxRange = 3;
                Console.WriteLine("3: {0}\n", menuOptionThree);
            }
            if (menuOptionFour != null)
            {
                maxRange = 4;
                Console.WriteLine("4: {0}\n", menuOptionFour);
            }
            if (menuOptionFive != null)
            {
                maxRange = 5;
                Console.WriteLine("5: {0}\n", menuOptionFive);
            }
            DisplayPossibleInputs(maxRange);
            return GetInput(maxRange);
        }

        public static void DisplayPossibleInputs(int maxRange)
        {
            for (int i = 1; i <= maxRange; i++)
            {
                
                if (i == 1)
                {
                    Console.Write("Menu navigation options: '");
                }
                if (i > 1 && i != maxRange+1)
                {
                    Console.Write(", '");
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(i);
                Console.ResetColor();
                Console.Write("'");
            }
        }

        public static string GetInput(int maxInput)
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
                if (input <= maxInput && input != 0)
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
