﻿using System;
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
            Ledger ledger = new HumaneSociety.Ledger();
            Shelter_Management shelter_management = new Shelter_Management(ledger);
            shelter_management.MainMenu();
        }
    }
}
//Database: Animal type, animal cost, animal room, adopted?, shots administered?, food amount

//Adopter: 
//    Create Profile: name, age, housing status, other pets, kids.
//    Search DB (multiple criteria) for potential pets.
//    Ability to pay for animal.

//Employee: Import CSV file
//        Add animal to DB.
//        Change & view animal status, room, shots, etc.
//        Give animal shots
//        Collect money from adopter
