using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adopter
{
    class AdopterMainPage
    {
        User currUser;
        
        public AdopterMainPage()
        {

            
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
                    currUser.GetProfileMenu();
                    break;
                case "2":
                    Console.Clear();
                    ViewAnimals();
                    break;
            }
        }
        void ViewAnimals()
        {
            ViewAnimals animalQueries = new ViewAnimals(new SQLManagement());
        }

    }
}
