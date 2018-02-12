using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter.cs
{
    public class Volunteer : Employee
    {
        // 1-Properties 
        // 1-Override Method 
        // Feed Method
        // Water Method


        // new Field

        //string volSpecialty;
        string waterAll;
        string play;
        // new  Property 

        //public string Feedall { get; set; }
        public string WaterAll { get; set;}
        public string Play { get; set; }
        
        // Constructor

        public Volunteer()
        {

        }

        public Volunteer(string VolSpecialty, string feedAll, string waterAll, string play)
        {
            //VolSpecialty = volSpecialty;
            //FeedAll = feedAll;
            WaterAll = waterAll;
            Play = play;
        }

       public string Ply()
        {
            Play = " Volunteers Love playing with all the Pets";
            return Play;
        }

        public string Fd()
        {
            Feed = "Volunteers fed the pet";
            return Feed;
        }

        public string Wtr()
        {
            Water = "The Volunteer gave the pet water";
            return Water;
        }

        public override string FdAll()
        {
            FeedAll = "Volunteers get to Feed ALL the pets";
            return FeedAll;
        }

        public string WtrAll()
        {
            WaterAll = "Volunteers get to Give ALL the pets water";
            return WaterAll;

        }

        public override string Adpt()
        {
            throw new NotImplementedException();
        }











    }


    
}
