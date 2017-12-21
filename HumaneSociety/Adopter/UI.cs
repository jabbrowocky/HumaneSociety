using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adopter
{
    static class UI
    {
        public static string DisplayOptions(string menuName, string menuOptionOne, string menuOptionTwo = null, string menuOptionThree = null, string menuOptionFour = null, string menuOptionFive = null, string menuOptionSix = null)
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
            if (menuOptionSix != null)
            {
                maxRange = 6;
                Console.WriteLine("6: {0}\n", menuOptionSix);
            }
            DisplayPossibleInputs(maxRange);
            return GetInput(maxRange);
        }

        static void DisplayPossibleInputs(int maxRange)
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

        static string GetInput(int maxInput)
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
        //public static void RebuildForCursorSelectionMenu(string menuName, string menuOptionOne, string menuOptionTwo = null, string menuOptionThree = null, string menuOptionFour = null, string menuOptionFive = null)
        //{
        //    // A variable to keep track of the current Item, and a simple counter.
        //    short curItem = 0, c;
        //    // The object to read in a key
        //    ConsoleKeyInfo key;
        //    // Our array of Items for the menu (in order)
        //    string[] menu;
        //    string[] menuItems = { menuOptionOne };
        //    string[] menuItemsTwo = { menuOptionOne, menuOptionTwo };
        //    string[] menuItemsThree = { menuOptionOne, menuOptionTwo, menuOptionThree };
        //    string[] menuItemsFour = { menuOptionOne, menuOptionTwo, menuOptionThree, menuOptionFour};
        //    string[] menuItemsFive = { menuOptionOne, menuOptionTwo, menuOptionThree, menuOptionFour, menuOptionFive };
        //    menu = menuItems;
        //    if (menuOptionTwo != null)
        //    {
        //        menu = menuItemsTwo;
        //    }
        //    if (menuOptionThree != null)
        //    {
        //        menu = menuItemsThree;
        //    }
        //    if (menuOptionFour != null)
        //    {
        //        menu = menuItemsFour;
        //    }
        //    if (menuOptionFive != null)
        //    {
        //        menu = menuItemsFive;
        //    }
        //    do
        //    {
        //        // Clear the screen.  One could easily change the cursor position,
        //        // but that won't work out well with tabbing out menu items.
        //        Console.Clear();

        //        // Replace this with whatever you want.
        //        Console.WriteLine("       " + menuName + "\n--------------------\n");

        //        // The loop that goes through all of the menu items.
        //        for (c = 0; c < menu.Length; c++)
        //        {
        //            // If the current item number is our variable c, tab out this option.
        //            // You could easily change it to simply change the color of the text.
        //            if (curItem == c)
        //            {
        //                //Console.Write(">>");
        //                Console.BackgroundColor = ConsoleColor.DarkGreen;
        //                Console.WriteLine(menu[c]);
        //                Console.ResetColor();
        //            }
        //            // Just write the current option out if the current item is not our variable c.
        //            else
        //            {
        //                Console.WriteLine(menu[c]);
        //            }
        //        }

        //        // Waits until the user presses a key, and puts it into our object key.
        //        Console.Write("Select your choice with the arrow keys.");
        //        key = Console.ReadKey(true);

        //        // Simply put, if the key the user pressed is a "DownArrow", the current item will deacrease.
        //        // Likewise for "UpArrow", except in the opposite direction.
        //        // If curItem goes below 0 or above the maximum menu item, it just loops around to the other end.
        //        if (key.Key.ToString() == "DownArrow")
        //        {
        //            curItem++;
        //            if (curItem > menu.Length - 1) curItem = 0;
        //        }
        //        else if (key.Key.ToString() == "UpArrow")
        //        {
        //            curItem--;
        //            if (curItem < 0) curItem = Convert.ToInt16(menu.Length - 1);
        //        }
        //        // Loop around until the user presses the enter go.
        //    } while (key.KeyChar != 13);
        

        //}  
        
    }
}
