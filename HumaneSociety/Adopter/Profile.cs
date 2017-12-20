using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adopter
{
    class Profile
    {
        //member variables
        
        string housingStatus = "Housing Status";
        string firstName = "First Name";
        string lastName = "Last Name";
        string age = "Age";        
        string currentPets= "Current Pets";

        //ctor
        public Profile()
        {
                
        }
        //methods
        void CondenseInfo()
        {
            
        }
        public void GetProfileMenu()
        {
            string menuName = "Profile Setup";
            string userInput; 
            userInput = UI.DisplayOptions(menuName, firstName, lastName, age, housingStatus, currentPets);
            ImplementProfileMenuLogic(userInput);
        }
        void ImplementProfileMenuLogic(string userInput)
        {
            switch (userInput)
            {
                case "1":
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    break;
                
            }
        }
        void GetAge()
        {
            Console.WriteLine("What is your Age?");

        }
    }
}
