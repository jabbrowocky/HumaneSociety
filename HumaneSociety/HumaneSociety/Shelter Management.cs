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
                    Console.ReadLine();
                    MainMenu();
                    break;
                case 2:
                    Console.Clear();
                    List<Animal> searchResults = ExecuteQuery(null, null, null, null, null, null, "no", null);
                    Animal animal = SelectAnimalToModify(searchResults);
                    ChangeVaccinatedStatus(animal);
                    break;
                case 3:
                    Console.Clear();
                    searchResults = ExecuteQuery(null, null, null, null, null, null, null, "no");
                    animal = SelectAnimalToModify(searchResults);
                    ChangeAdoptedStatus(animal);
                    break;
                case 4:
                    Console.Clear();
                    AnimalIntakeMenu();
                    break;
                case 5:
                    Console.Clear();
                    ledger.DisplayLedger();
                    break;
            }
            MainMenu();
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
                    ExecuteQuery(null, null, null, null, null, null, null, null);
                    break;
                case 4:
                    Console.Clear();
                    MainMenu();
                    break;
            }
        }
        public void AlterAnimalInfo(Animal animal)
        {
            string name = animal.Pet_Name;
            string age = animal.Age;
            string kennel = animal.Room_Number;
            string foodReq = animal.Food_Consumption;
            string cost = animal.Cost;
            string species = animal.Animal_Type;
            string vaccinated = animal.Shot_Status;
            string adopted = animal.Adoption_Status;

            string menuText = UI.AlterAnimalInfoText();
            UI.DisplayMenu(menuText);
            int input = UI.GetInput(10);
            switch (input)
            {
                case 1:
                   animal.Pet_Name = AlterTrait("name");
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
                    vaccinated = AlterTrait("vaccinated");
                    break;
                case 8:
                    adopted = AlterTrait("adopted");
                    break;
                case 9:
                    AlterAnimalInfo(animal);
                    break;
                case 10:
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
                int input = UI.GetInput(11);
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
                        vaccinated = AlterTrait("vaccination status");
                        Console.Clear();
                        menuText = UI.AnimalTraitsText();
                        UI.DisplayMenu(menuText);
                        break;
                    case 8:
                        adopted = AlterTrait("adoption status");
                        Console.Clear();
                        menuText = UI.AnimalTraitsText();
                        UI.DisplayMenu(menuText);
                        break;
                    case 9:
                        Console.Clear();
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
                    AddAnimal();
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
        public List<Animal> ExecuteQuery(string name, string age, string kennel, string foodReq, string cost, string species, string vaccinated, string adopted)
        {
            List<string> queryValuesList = BuildQueryValues(name, age, kennel, foodReq, cost, species, vaccinated, adopted);
            List<string> queryColumnsList = BuildQueryColumns(name, age, kennel, foodReq, cost, species, vaccinated, adopted);
            string queryString = sqlConnect.ConstructSearhString(queryValuesList, queryColumnsList);
            List<Animal> searchResults = sqlConnect.SearchSQLQuery(queryString);
            return searchResults;
        }
        public List<string> BuildQueryValues(string name, string age, string kennel, string foodReq, string cost, string species, string vaccinated, string adopted)
        {
            List<string> queryList = new List<string>();
            if (name != null && name !="")
            {
                queryList.Add("'"+name+"'");
            }
            if (age == ".5" || age == "0.5" && age != "")
            {
                queryList.Add("1");
            }
            if (age == "1")
            {
                queryList.Add("2");
            }
            if (age == "2")
            {
                queryList.Add("3");
            }
            if (age == "3")
            {
                queryList.Add("4");
            }
            if (age == "4")
            {
                queryList.Add("5");
            }
            if (age == "5")
            {
                queryList.Add("6");
            }
            if (age == "6")
            {
                queryList.Add("7");
            }
            if (age == "7")
            {
                queryList.Add("8");
            }
            if (age == "8")
            {
                queryList.Add("9");
            }
            if (age == "9")
            {
                queryList.Add("10");
            }
            if (age == "10")
            {
                queryList.Add("11");
            }
            if (age == "11")
            {
                queryList.Add("12");
            }
            if (age == "12")
            {
                queryList.Add("13");
            }
            if (kennel != null && kennel != "")
            {
                queryList.Add(kennel);
            }
            if (foodReq == ".5" || foodReq == "0.5")
            {
                queryList.Add("1");
            }
            if (foodReq == "1")
            {
                queryList.Add("2");
            }
            if (foodReq == "1.5")
            {
                queryList.Add("3");
            }
            if (foodReq == "2")
            {
                queryList.Add("4");
            }
            if (foodReq == "2.5")
            {
                queryList.Add("5");
            }
            if (foodReq == "3")
            {
                queryList.Add("6");
            }
            if (foodReq == "3.5")
            {
                queryList.Add("7");
            }
            if (foodReq == "4")
            {
                queryList.Add("8");
            }
            if (foodReq == "4.5")
            {
                queryList.Add("9");
            }
            if (foodReq == "5")
            {
                queryList.Add("10");
            }
            if (foodReq == "5.5")
            {
                queryList.Add("11");
            }
            if (foodReq == "6")
            {
                queryList.Add("12");
            }
            if (cost != null && cost !="")
            {
                queryList.Add(cost);
            }
            if (species == "Dog" || species == "dog")
            {
                queryList.Add("2");
            }
            if (species == "Cat" || species == "cat")
            {
                queryList.Add("1");
            }
            if (species == "Bird" || species == "bird")
            {
                queryList.Add("3");
            }
            if (species == "Rabbit" || species == "rabbit" || species == "Bunny" || species == "bunny")
            {
                queryList.Add("4");
            }
            if (species == "Ferret" || species == "ferret")
            {
                queryList.Add("5");
            }
            if (vaccinated == "Yes" || vaccinated == "yes" || vaccinated == "Y" || vaccinated == "y")
            {
                queryList.Add("1");
            }
            if (vaccinated == "No" || vaccinated == "no" || vaccinated == "N" || vaccinated == "n")
            {
                queryList.Add("0");
            }
            if (adopted == "Yes" || adopted == "yes" || adopted == "Y" || adopted == "y")
            {
                queryList.Add("1");
            }
            if (adopted == "No" || adopted == "no" || adopted == "N" || adopted == "n")
            {
                queryList.Add("0");
            }
            return queryList;
        }
        public List<string> BuildQueryColumns(string name, string age, string kennel, string foodReq, string cost, string species, string vaccinated, string adopted)
        {
            List<string> queryList = new List<string>();
            if (name != null && name != "")
            {
                queryList.Add("Pet_Name");
            }
            if (age != null && age != "")
            {
                queryList.Add("Age");
            }
            if (kennel != null && kennel != "")
            {
                queryList.Add("Room_Number");
            }
            if (foodReq != null && foodReq != "")
            {
                queryList.Add("Food_Consumption");
            }
            if (cost != null && cost != "")
            {
                queryList.Add("Cost");
            }
            if (species != null && species != "")
            {
                queryList.Add("Animal_Type");
            }
            if (vaccinated != null && vaccinated != "")
            {
                queryList.Add("Shot_Status");
            }
            if (adopted != null && adopted != "")
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
        public void AddAnimal()
        {
            // ADD INPUT CHECKS FOR ALL
            string name = null;
            string age = null;
            string kennel = null;
            string foodReq = null;
            string cost = null;
            string species = null;
            string vaccinated = null;
            string adopted = null;
            Console.WriteLine("Please input new animal details. Hit 'Enter' if detail is not known.\nName:");
            name = Console.ReadLine();
            Console.Write("Age:");
            age = Console.ReadLine();
            Console.Write("Kennel Number:");
            kennel = Console.ReadLine();
            Console.Write("Weekly Food Requirement:");
            foodReq = Console.ReadLine();
            Console.Write("Cost:");
            cost = Console.ReadLine();
            Console.Write("Species:");
            species = Console.ReadLine();
            Console.Write("Vaccination status:");
            vaccinated = Console.ReadLine();
            Console.Write("Adoption status:");
            adopted = Console.ReadLine();

            ExecuteAddData(name, age, kennel, foodReq, cost, species, vaccinated, adopted);
            Console.Clear();
            Console.WriteLine("Added row to Animal table.");
        }
        public Animal SelectAnimalToModify(List<Animal> searchResults)
        {
            Console.WriteLine("Select the index of the animal you would like to modify.\n");
            int input = UI.GetInput(searchResults.Count);
            Animal animal = searchResults[input - 1];
            return animal;
        }
        public void ChangeVaccinatedStatus(Animal animal)
        {
            string text = UI.AdministerVaccineText();
            UI.DisplayMenu(text);
            int input = UI.GetInput(2);
            switch (input)
            {
                case 1:
                    Console.Clear();
                    string update = sqlConnect.ConstructAlterRowString(animal.ID, "Shot_Status", "1");
                    sqlConnect.AddData(update);
                    Console.WriteLine("{0} has been vaccinated", animal.Pet_Name);
                    Console.ReadLine();
                    break;
                case 2:
                    break;
            }
            MainMenu();
        }
        public void ChangeAdoptedStatus(Animal animal)
        {
            string text = UI.AdoptText();
            UI.DisplayMenu(text);
            int input = UI.GetInput(2);
            switch (input)
            {
                case 1:
                    Console.Clear();
                    string updateAdoptedStatus = sqlConnect.ConstructAlterRowString(animal.ID, "Adoption_Status", "1");
                    sqlConnect.AddData(updateAdoptedStatus);
                    string updateRoomNumber = sqlConnect.ConstructAlterRowString(animal.ID, "Room_Number", "NULL");
                    sqlConnect.AddData(updateRoomNumber);
                    ledger.AddRevenue(animal.Cost);
                    Console.WriteLine("{0} has been adopted out, Ledger increased by ${1}", animal.Pet_Name, animal.Cost);
                    Console.ReadLine();
                    break;
                case 2:
                    break;
            }
            MainMenu();
        }

    }
}
