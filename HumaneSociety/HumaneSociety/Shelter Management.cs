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
        SQLConnect sqlConnect;

        public Shelter_Management(Ledger ledger, SQLConnect sqlConnect)
        {
            this.ledger = ledger;
            this.sqlConnect = sqlConnect;
        }
        public void MainMenu()
        {
            string menuText = UI.MainMenuText();
            UI.DisplayMenu(menuText);
            int input = UI.GetInput(7);
            switch (input)
            {
                case 1:
                    Console.Clear();
                    ViewAnimalMenu();
                    break;
                case 2:
                    Console.Clear();
                    //find animal
                    AlterAnimalInfoMenu();
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
                    ExecuteQuery(null, null, null, null, null, null, null, "yes");
                    break;
                case 2:
                    Console.Clear();
                    SearchAnimalMenu();
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
        public void AlterAnimalInfoMenu()
        {
            string name = null;
            string age = null;
            string kennel = null;
            string foodReq = null;
            string cost = null;
            string species = null;
            string vaccinated = null;
            string adopted = null;

            string menuText = UI.AlterAnimalInfoText();
            UI.DisplayMenu(menuText);
            int input = UI.GetInput(8);
            switch (input)
            {
                case 1:
                   name = AlterTrait("name");
                   break;
                case 2:
                    age = AlterTrait("age");
                    break;
                case 3:
                    kennel = AlterTrait("kennel number");
                    break;
                case 4:
                    foodReq = AlterTrait("weekly food requirement");
                    break;
                case 5:
                    cost = AlterTrait("cost");
                    break;
                case 6:
                    species = AlterTrait("species");
                    break;
                case 7:
                    ExecuteQuery(name, age, kennel, foodReq, cost, species, vaccinated, adopted);
                    break;
                case 8:
                    Console.Clear();
                    MainMenu();
                    break;
            }
        }
        public void SearchAnimalMenu()
        {
            string name = null;
            string age = null;
            string kennel = null;
            string foodReq = null;
            string cost = null;
            string species = null;
            string vaccinated = null;
            string adopted = null;

            bool flag = false;

            string menuText = UI.AnimalTraitsText();
            UI.DisplayMenu(menuText);
            while (flag == false)
            {
                int input = UI.GetInput(10);
                switch (input)
                {
                    case 1:
                        name = AlterTrait("name");
                        Console.Clear();
                        menuText = UI.AnimalTraitsText();
                        UI.DisplayMenu(menuText);
                        break;
                    case 2:
                        age = AlterTrait("age");
                        Console.Clear();
                        menuText = UI.AnimalTraitsText();
                        UI.DisplayMenu(menuText);
                        break;
                    case 3:
                        kennel = AlterTrait("kennel number");
                        Console.Clear();
                        menuText = UI.AnimalTraitsText();
                        UI.DisplayMenu(menuText);
                        break;
                    case 4:
                        foodReq = AlterTrait("weekly Food Allowance");
                        Console.Clear();
                        menuText = UI.AnimalTraitsText();
                        UI.DisplayMenu(menuText);
                        break;
                    case 5:
                        cost = AlterTrait("cost");
                        Console.Clear();
                        menuText = UI.AnimalTraitsText();
                        UI.DisplayMenu(menuText);
                        break;
                    case 6:
                        species = AlterTrait("species");
                        Console.Clear();
                        menuText = UI.AnimalTraitsText();
                        UI.DisplayMenu(menuText);
                        break;
                    case 7:
                        species = AlterTrait("vaccination status");
                        Console.Clear();
                        menuText = UI.AnimalTraitsText();
                        UI.DisplayMenu(menuText);
                        break;
                    case 8:
                        species = AlterTrait("adoption status");
                        Console.Clear();
                        menuText = UI.AnimalTraitsText();
                        UI.DisplayMenu(menuText);
                        break;
                    case 9:
                        flag = true;
                        ExecuteQuery(name, age, kennel, foodReq, cost, species, vaccinated, adopted);
                        break;
                    case 10:
                        Console.Clear();
                        flag = true;
                        MainMenu();
                        break;
                }
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
        public void ExecuteQuery(string name, string age, string kennel, string foodReq, string cost, string species, string vaccinated, string adopted)
        {
            List<string> queryValuesList = BuildQueryValues(name, age, kennel, foodReq, cost, species, vaccinated, adopted);
            List<string> queryColumnsList = BuildQueryColumns(name, age, kennel, foodReq, cost, species, vaccinated, adopted);
            string queryString = sqlConnect.ConstructSearhString(queryValuesList, queryColumnsList);
            sqlConnect.SearchSQLQuery(queryString);
        }
        public List<string> BuildQueryValues(string name, string age, string kennel, string foodReq, string cost, string species, string vaccinated, string adopted)
        {
            List<string> queryList = new List<string>();
            if (name != null)
            {
                queryList.Add(name);
            }
            if (age != null)
            {
                queryList.Add(age);
            }
            if (kennel != null)
            {
                queryList.Add(kennel);
            }
            if (foodReq != null)
            {
                queryList.Add(foodReq);
            }
            if (cost != null)
            {
                queryList.Add(cost);
            }
            if (vaccinated != null)
            {
                queryList.Add(cost);
            }
            if (adopted != null)
            {
                queryList.Add(cost);
            }
            return queryList;
        }
        public List<string> BuildQueryColumns(string name, string age, string kennel, string foodReq, string cost, string species, string vaccinated, string adopted)
        {
            List<string> queryList = new List<string>();
            if (name != null)
            {
                queryList.Add("Pet_Name");
            }
            if (age != null)
            {
                queryList.Add("Age");
            }
            if (kennel != null)
            {
                queryList.Add("Room_Number");
            }
            if (foodReq != null)
            {
                queryList.Add("Food_Consumption");
            }
            if (cost != null)
            {
                queryList.Add("Cost");
            }
            if (vaccinated != null)
            {
                queryList.Add("Shot_Status");
            }
            if (adopted != null)
            {
                queryList.Add("Adoption_Status");
            }
            return queryList;
        }
        public string AlterTrait(string trait)
        {
            Console.WriteLine("What would you like {0} to be?", trait);
            string value = Console.ReadLine();
            return value;
        }
        public void ExecuteAddData(string name, string age, string kennel, string foodReq, string cost, string species, string vaccinated, string adopted)
        {
            List<string> dataValuesList = BuildQueryValues(name, age, kennel, foodReq, cost, species, vaccinated, adopted);
            List<string> dataColumnsList = BuildQueryColumns(name, age, kennel, foodReq, cost, species, vaccinated, adopted);
            string dataString = sqlConnect.ConstructAddDataString(dataValuesList, dataColumnsList);
            sqlConnect.AddData(dataString);
        }
    }
}
