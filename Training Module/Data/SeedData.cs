using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Training_Module.Models;

namespace Training_Module.Data
{
    public static class SeedData
    {
        public static IList<Grocery> GetSeedDataSet()
        {
            return new List<Grocery>()
            {
                new Grocery()
                {
                    ItemName = "Tomatoes",
                    Quantity = 6,
                    Price = 2.99,
                    GrabbedAlready = false
                },
                new Grocery()
                {
                    ItemName = "Oreos",
                    Quantity = 6,
                    Price = 4.99,
                    GrabbedAlready = false
                },
                new Grocery()
                {
                    ItemName = "Frozen Pizza",
                    Quantity = 6,
                    Price = 7.99,
                    GrabbedAlready = false
                },
            };

        }
    }
}
