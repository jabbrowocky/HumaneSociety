﻿using System;
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
            Console.Clear();
            Console.WriteLine(menu);
        }
        public static int GetInput(int options)
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
            
            return input;
        }
        public static string MainMenuText()
        {
            string text = "Shelter Management Main Menu \n\n[1] View Animals \n[2] Alter Animal Info\n[3] Check Kennels \n[4] Administer Vaccination \n[5] Adopt out animal \n[6] Animal Intake\n[7]Check Ledger";
            return text;
        }
        public static string AnimalViewText()
        {
            string text = "Find Animal(s) \n\n[1] Display all unadopted animals \n[2] Display animals based on traits\n[3] Display all animals\n[4] Main Menu";
            return text;
        }
        public static string SelectAnimalText()
        {
            string text = "Select Animal from list";
            return text;
        }
        public static string AlterAnimalInfoText()
        {
            string text = "Alter:\n\n[1] Name\n[2] Age\n[3] Kennel #\n[4] Weekly food requirement\n[5] Cost\n[6] Species\n[7] Execute Search\n[8] Main Menu";
            return text;
        }
        public static string AnimalTraitsText()
        {
            string text = "Search Animals by Traits \nSelect up to options\n\n[1] Name\n[2] Type\n[3] Cost\n[4] Kennel #\n[5] Adoption Status\n[6] Vaccination Status \n[7] Food Requirements\n[8] Select Animal Menu [9] Main Menu";
            return text;
        }
        public static string AnimalIntakeText()
        {
            string text = "Animal Intake\n\n[1] Manually Input Animal\n [2] Accept Animal info from list\n[3] Main menu";
            return text;
        }
        
    }
}
