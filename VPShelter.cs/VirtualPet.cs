using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter.cs
{
    public class VirtualPet
    {
        // **Carried over legacy code adding ned requirements
        // ** Ref Comments New/Legacy
        
        // new instance variable
        // New Fields

        public string petName = "Current Pets in the Shelter: Lincoln, Angel"; 
        public string petDescript = "Lincoln: is a 15 month old american pitbull " +
            "Angel: is a ring neck dove" ;

        // Legacy Fields
        private bool treat;
        private bool isHungry;
        private bool goPotty;
        private int tickercount;

        // new instance variable
        // New Property
        public string PetName { get; set; }
        public string PetDescript { get; set; }
       
        // Legacy Properties
        public int Tickercount
        {
            get { return this.tickercount; }
            set { this.tickercount = value; }
        }

        public bool Treat
        {
            get { return this.treat; }
            set { this.treat = value; }
        }

        public bool IsHungry
        {
            get { return this.isHungry; }
            set { this.isHungry = value; }
        }

        public bool GoPotty
        {
            get { return this.goPotty; }
            set { this.goPotty = value; }
        }

        //  NEW Constructors

        public VirtualPet(string petName, string petDescript)
        {
            this.PetName = petName;
            this.PetDescript = petDescript;
        }


        // Legacy Constructors

        public VirtualPet()
        {

        }

        public VirtualPet(bool treat, bool isHungry, bool goPotty)
        {
            this.treat = treat;
            this.isHungry = isHungry;
            this.goPotty = goPotty;
        }
 
        // New Methods
        public string Name()
        {
            PetName = petName;
            return PetName;
          
        }

        public string Descript()
        {
            Console.WriteLine(" DOG)  Lincoln is a 15 month old pitbull");
            Console.WriteLine(" BIRD) Angel is ringneck dove" );
            return PetDescript;
        }
        
        // Legacy Methods

        public void WantaTreat()
        {
            treat = true;
            Console.WriteLine("Isa Good Boy? Isa wanna Treat?");
        }

        public void FeedDog()
        {
            Console.WriteLine("Get the dinner BooBoo!!!");
            isHungry = true;
        }

        public void PottyStatus()
        {
            Console.WriteLine("Datta Wadda Good Boy BooBoo");
            goPotty = true;
        }


        public void PetStatus()
        {
            Console.WriteLine("Pets need to Eat.........:" + isHungry);
            Console.WriteLine("Pets need to go OutSide..:" + goPotty);
            Console.WriteLine("Pets want a Treat........:" + treat);
        }

        public void Tick()
        {

            tickercount++;
            if (isHungry == false)
            {
                goPotty = true;
            }
            if (goPotty == false)
            {
                treat = true;
            }
            if (isHungry == false)
            {
                isHungry = true;
            }
            else treat = false;











        }
    }
}
