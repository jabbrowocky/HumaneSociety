using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class Shelter_Management
    {

        Ledger ledger;

        public Shelter_Management(Ledger ledger)
        {
            this.ledger = ledger;
        }
        public void MainMenu()
        {
            string menuText = UI.MainMenuText();
            UI.DisplayMenu(menuText);
            int input = UI.GetInput(6);
            switch (input)
            {
                case 1:
                    Console.Clear();
                    ViewAnimalMenu();
                    break;
                case 2:
                    Console.Clear();
                    //find animal
                    AlterAnimalInfoMenu(animal);
                    break;
                case 3:
                    Console.Clear();
                    //DisplayCurrentAnimals/Kennels();
                    break;
                case 4:
                    Console.Clear();
                    //AdministerVaccine();
                    break;
                case 5:
                    Console.Clear();
                    //AdoptOutAnimal();
                    break;
                case 6:
                    Console.Clear();
                    AnimalIntakeMenu();
                    break;
                case 7:
                    Console.Clear();
                    //CheckLedger();
                    break;
            }
        }
        public void ViewAnimalMenu()
        {
            string menuText = UI.AnimalViewText();
            UI.DisplayMenu(menuText);
            int input = UI.GetInput(4);
            switch (input)
            {
                case 1:
                    Console.Clear();
                    //DisplayAllUnadopted();
                    break;
                case 2:
                    Console.Clear();
                    //AnimalTraitSearchMenu();
                    break;
                case 3:
                    Console.Clear();
                    //DisplayAllAnimals();
                    break;
                case 4:
                    Console.Clear();
                    MainMenu();
                    break;
            }
        }
        public void AlterAnimalInfoMenu(string animal)
        {
            string name;
            float age;
            int kennel;
            float foodReq;
            float cost;
            string species;

            string menuText = UI.AlterAnimalInfoText();
            UI.DisplayMenu(menuText);
            int input = UI.GetInput(7);
            switch (input)
            {
                case 1:
                    name = AlterTrait();
                    AlterDBName(name);
                    break;
                case 2:
                    age = AlterTrait();
                    AlterDBAge(age);
                    break;
                case 3:
                    kennel = AlterTrait();
                    AlterDBKennel(kennel);
                    break;
                case 4:
                    foodReq = AlterTrait();
                    AlterDBFoodReq(foodReq);
                    break;
                case 5:
                    cost = AlterCost();
                    AlterDBCost(cost);
                    break;
                case 6:
                    species = AlterSpecies();
                    AlterDBSpecies(species);
                    break;
                case 7:
                    Console.Clear();
                    MainMenu();
                    break;
            }
        }
        public void AnimalIntakeMenu()
        {
            string menuText = UI.AnimalIntakeText();
            UI.DisplayMenu(menuText);
            int input = UI.GetInput(3);
            switch (input)
            {
                case 1:
                    Console.Clear();
                    //AddAnimal();
                    break;
                case 2:
                    Console.Clear();
                    //AddAnimalFromDB();
                    break;
                case 3:
                    Console.Clear();
                    MainMenu();
                    break;
            }
        }
    }
}
