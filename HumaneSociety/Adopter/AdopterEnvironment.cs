using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adopter
{
    class AdopterEnvironment
    {
        User currUser = new User (new Profile());
        
        public AdopterEnvironment()
        {
            GetAdopterMenu();
            
        }
        public void GetAdopterMenu()
        {
            
            string userInput;
            userInput = UI.DisplayOptions("Adopter Main Menu", "Profile", "View Animals");
            GetAdopterMenuLogic(userInput);
            
        }
        void GetAdopterMenuLogic(string userInput)
        {
            switch (userInput)
            {
                case "1":
                    Console.Clear();
                    GetProfileMenu();
                    break;
                case "2":
                    Console.Clear();
                    ViewAnimals();
                    break;
            }
        }

        public void GetProfileMenu()
        {
            string menuName = "Profile Setup";
            string userInput;
            userInput = UI.DisplayOptions(menuName, "Name", "Age", "Housing Status", "Current pets (if any)", "View User Profile", "Return To Main Menu");
            ImplementProfileMenuLogic(userInput);
        }
        void ImplementProfileMenuLogic(string userInput)
        {
            try
            {
                switch (userInput)
                {
                    case "1":
                        currUser.userProfile.GetName();
                        break;
                    case "2":
                        currUser.userProfile.GetAge();
                        break;
                    case "3":
                        currUser.userProfile.GetHousingInfo();
                        break;
                    case "4":
                        currUser.userProfile.GetPets();
                        break;
                    case "5":
                        currUser.userProfile.GetProfileInfo();
                        break;
                    case "6":
                        Console.Clear();
                        GetAdopterMenu();
                        break;
                }
            }
            
            finally
            {
                GetProfileMenu();
            }
            
        }
        
        void ViewAnimals()
        {
            ViewAnimals animalQueries = new ViewAnimals(new SQLManagement());
        }
    }
}
