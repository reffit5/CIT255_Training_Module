using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Training_Module.Models
{
    public class MockGroceryRepo : IGroceryInterface
    {
        private List<Grocery> _groceryList;

        public MockGroceryRepo()
        {
            _groceryList = new List<Grocery>()
            {
                new Grocery()
                {
                    ItemName = "Tomatoes",
                    Quantity = 6,
                    Price = 2.99,
                    GrabbedAlready = true,
                    Id = "1"
                },
                new Grocery()
                {
                    ItemName = "Oreos",
                    Quantity = 6,
                    Price = 4.99,
                    GrabbedAlready = false,
                    Id = "2"
                },
                new Grocery()
                {
                    ItemName = "Frozen Pizza",
                    Quantity = 6,
                    Price = 7.99,
                    GrabbedAlready = false,
                    Id = "3"
                },
            };
        }

        public Grocery Add(Grocery grocery)
        {
            Guid id = Guid.NewGuid();
            grocery.Id = id.ToString();
            _groceryList.Add(grocery);
            return grocery;
        }

        public void Delete(Grocery byeByeItem)
        {
            Grocery item = GetGrocery(byeByeItem.Id);
            _groceryList.Remove(item);
        }

        public IEnumerable<Grocery> GetAllGroceries()
        {
            return _groceryList;
        }

        public Grocery GetGrocery(string Id)
        {
            return _groceryList.FirstOrDefault(g => g.Id == Id);
        }

        
    }
}
