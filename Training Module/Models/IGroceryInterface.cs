using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Training_Module.Models
{
    public interface IGroceryInterface
    {
        Grocery GetGrocery(string Id);
        IEnumerable<Grocery> GetAllGroceries();
        Grocery Add(Grocery grocery);
        void Delete(Grocery grocery);
        
    }
}
