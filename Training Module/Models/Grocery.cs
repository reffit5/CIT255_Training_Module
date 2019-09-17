using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Training_Module.Models
{
    public class Grocery
    {
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public bool  GrabbedAlready { get; set; }
    }


}
