using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter.cs
{
    class VirtualPetShelter
    { 
        // List of all employees
        // List of all pets 

        List<string> staff = new List<string>() { " Manager", "Volunteer" };
        List<string> pet = new List<string>() { "dog", "Bird" };
        

        //Fields 

        
        string employeeList;
        string petList;

        // Properties 

        public string EmployeeList { get; set; }
        public string Petlist { get; set; }

        //Constructor

        public VirtualPetShelter()
        {

        }

        public VirtualPetShelter(string employeeList, string petList)
        {
           
        }

        //  Methods

        public string ShelterList()
        {
            return employeeList + petList;
        }
       








    }
}
