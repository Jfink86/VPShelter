using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter.cs
{
    class PetCare : VirtualPet
    {
        // Fields for (1)type of pet (2)type of food 
        
       // Fields

        string petType;
        string petDiet;

        // Properties

        public string PetType { get; set; }
        public string PetDiet { get; set; }

        // Constructots

        public PetCare()
        {

        }

        public PetCare(string petType, string petDiet)
        {
            this.PetDiet = petDiet;
            this.PetType = petType;
        }

        // Methods

        public string PtDiet()
        {
            PetDiet = " Dog Food" ;
            return PetDiet;
        }

        public string TypPet()
        {
            Console.WriteLine("We currently have:");
            Console.WriteLine(" 1- dog");
            Console.WriteLine(" 1- bird");
            return PetType;
        }


    }
}
