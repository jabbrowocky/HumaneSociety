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
       
        
        string housingStatus;
        string firstName = "First Name";
        string lastName = "Last Name";
        string age = "Age";        
        string currentPets= "Current Pets";

        //ctor
        public Profile()
        {
            
        }
        //methods
        
        public void GetProfileMenu()
        {
            string menuName = "Profile Setup";
            string userInput; 
            userInput = UI.DisplayOptions(menuName, "Name", "Age", "Housing Status", "Current pets (if any)", "View User Profile","Return To Main Menu");
            ImplementProfileMenuLogic(userInput);
        }
        void ImplementProfileMenuLogic(string userInput)
        {
            switch (userInput)
            {
                case "1":
                    GetName();                   
                    break;
                case "2":
                    GetAge();
                    break;
                case "3":
                    GetHousingInfo();
                    break;
                case "4":
                    GetPets();
                    break;
                case "5":
                    GetProfileInfo();
                    break;
                case "6":
                    Console.Clear();
                    
                    
                    break;            
                
            }
        }
        void GetAge()
        {
            Console.WriteLine("What is your age?");
            age = Console.ReadLine();
            Console.Clear();
            GetProfileMenu();
        }
        void GetName()
        {
            Console.WriteLine("What is your first name?");
            firstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            lastName = Console.ReadLine();
            Console.Clear();
            GetProfileMenu();
        }
        void GetHousingInfo()
        {
            Console.WriteLine("What type of home do you currently reside in?\n (Apartment, House, Condo)");
            housingStatus = Console.ReadLine();
            Console.Clear();
            GetProfileMenu();
        }
        void GetPets()
        {
            Console.WriteLine("Do you have any pets currently?");
            currentPets = Console.ReadLine();
            GetProfileMenu();
        }
        void GetProfileInfo()
        {
            Console.WriteLine("Name: {0}{1}\nAge: {2}\nHousing Status: {3}\nCurrent Pets: {4}\n\nPress any key to continue.",firstName,lastName,age,housingStatus,currentPets);
            Console.ReadKey();
            Console.Clear();
            GetProfileMenu();
        }
    }
}
