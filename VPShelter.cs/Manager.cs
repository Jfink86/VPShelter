using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter.cs
{
    class Manager : Employee
    {
        // Fields Inherited
        // 1-Req'd Property
        // 1-override methods req'd
        // Method for adopting a pet

        // new Field

        string payBills;

        // New Property

        public string PayBills { get; set; }

        // Constructors

        public Manager()
        {

        }

        public Manager(string employName, string payBills,  string adopt, string feed )
        {

        }

        public string Pblls()
        {
            PayBills = " Managers Pay the Bills ";
            return PayBills;
        }

        public override string Adpt()
        {
            Adopt = " Managers get the pets Adopted";
            return Adopt;
        }

        public override string FdAll()
        {
            throw new NotImplementedException();
        }

    }
}
