using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter.cs
{
    public abstract class Employee
    {
        // 1-Property req'd (show ID)
        // 2-Abstract Methods req'd (

        //field

        string employName;
        string feed;
        string water;
        string feedAll;
        //string waterAll;
        string adpot;
        string payBills;
        //property

        public string EmployName { get; set; }
        public string Feed { get; set; }
        public string Water { get; set; }
        public string Play { get; set; }
        public string FeedAll { get; set; }
        //public string WaterAll { get; set; }
        public string Adopt { get; set; }
        public string PayBills { get; set; }
        
        // constructors

        public Employee()
        {

        }

        public Employee(string employName, string feed, string water, string play, string feedAll, string waterAll, string adopt)
        {
            this.EmployName = employName;
            this.Feed = feed;
            this.Water = water;
            //this.Play = play;
            this.FeedAll = feedAll;   
            this.Adopt = adopt;
        }

        //Methods

        public string Fd()
        {
            return feed;
        }

        public string Wtr()
        {
            return water;
        }

        public abstract string Adpt();



        public abstract string FdAll();
        //{
        //   return feedAll;
        //}

        //public virtual string WtrAll()
        //{
        //   return waterAll;
        //}
    }
}
