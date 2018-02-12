using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Volunteer vol = new Volunteer();
            Manager man = new Manager();
            VirtualPet pet = new VirtualPet();
            PetCare pc = new PetCare();
            int input;
            int menuInput;

            VirtualPet dogOwner = new VirtualPet();

            do
            {

                Console.WriteLine(" Wecolme to the Virtual Pet shelter");
                Console.WriteLine();
                Console.WriteLine("Please select from the Following menu:");
                Console.WriteLine();
                Console.WriteLine(" 1. If you would like to volunteer" );
                Console.WriteLine(" 2. If you are a Manager");
                Console.WriteLine(" 3. If you are interesting in adpting a pet");
                Console.WriteLine(" 4. To exit");
                input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        Console.WriteLine("Thank you for Volunteering" );
                        Console.WriteLine();
                        Console.WriteLine("1. To Feed All Pets");
                        Console.WriteLine("2. To Give All the Pets water");
                        Console.WriteLine("3. To Play with the pets");
                        menuInput = int.Parse(Console.ReadLine());
                        if (menuInput == 1)
                        {
                            Console.WriteLine(vol.FdAll());
                        }
                        if (menuInput == 2)
                        {
                            Console.WriteLine(vol.WtrAll());
                        }
                        if (menuInput==3)
                        {
                            Console.WriteLine(vol.Ply());
                        }
                        Console.WriteLine("press any key to continue");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 2:
                        Console.WriteLine("Manager menu: Please select from the following ");
                        Console.WriteLine();
                        Console.WriteLine("1. Veiw a list of pet");
                        Console.WriteLine("2. Get one of the pets adpoted");
                        Console.WriteLine("3. Pay the Bills");
                        menuInput = int.Parse(Console.ReadLine());
                        if (menuInput == 1)
                        {
                            Console.WriteLine(pc.TypPet());
                            Console.WriteLine(pet.Name());
                            Console.WriteLine(pet.Descript());
                        }
                        if (menuInput == 2)
                        {
                            Console.WriteLine(man.Adpt());
                        }
                        if (menuInput == 3)
                        {
                            Console.WriteLine(man.Pblls());
                        }
                        Console.WriteLine("press any key to continue");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 3:
                        Console.WriteLine("Thank you for your interest in adopting a pet");
                        Console.WriteLine();
                        Console.WriteLine(" Please select from the following menu:");
                        Console.WriteLine();
                        Console.WriteLine("1. View current pets available for adoption");
                        Console.WriteLine("2. View a descpition of pets");
                        menuInput = int.Parse(Console.ReadLine());
                        if (menuInput == 1)
                        {
                            Console.WriteLine(pc.TypPet());
                        }
                        if (menuInput == 2)
                        {
                            Console.WriteLine(pet.Descript());
                        }
                        Console.WriteLine("press any key to continue");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    default:
                      break;
                }

                       
            } while (input != 4);
            {
                Console.WriteLine("Thanks for visiting the Virtual Pet Shelter");
                Console.WriteLine();
                Console.WriteLine("Help control the pet population Have your pets Spade or Neutered");
            }

        }
    }
}
