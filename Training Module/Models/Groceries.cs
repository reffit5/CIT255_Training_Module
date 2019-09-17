using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Training_Module.Models
{
    public class Groceries
    {

        public string ItemName { get; set; }
        public int Quanitity { get; set; }
        public double Price { get; set; }
        public string Location {get; set; }
        public bool  GrabbedAlready { get; set; }
        public bool Important { get; set; }
    }


}
