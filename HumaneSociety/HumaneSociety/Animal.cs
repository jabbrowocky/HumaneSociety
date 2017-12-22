using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class Animal
    {
        public string Pet_Name;
        public string Animal_Type;
        public string Age;
        public string Cost;
        public string Room_Number;
        public string Adoption_Status;
        public string Shot_Status;
        public string Food_Consumption;

        public Animal(string Pet_Name, string Animal_Type, string Age, string Cost, string Room_Number, string Adoption_Status, string Shot_Status, string Food_Consumption)
        {
            this.Pet_Name = Pet_Name;
            this.Animal_Type = Animal_Type;
            this.Age = Age;
            this.Cost = Cost;
            this.Room_Number = Room_Number;
            this.Adoption_Status = Adoption_Status;
            this.Shot_Status = Shot_Status;
            this.Food_Consumption = Food_Consumption;
        }
    }
}
