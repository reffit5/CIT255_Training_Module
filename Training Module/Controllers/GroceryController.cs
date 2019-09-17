using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Training_Module.Models;
namespace Training_Module.Controllers
{
    public class GroceryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Groceries()
        {
            return View();
        }

        public ActionResult List()
        {
            List<Groceries> grocery = new List<Groceries>();
            grocery.Add(new Groceries
            {
                GrabbedAlready = false,
                ItemName = "avacado",
                Quanitity = 4,
                Price = 1.99,
                Important = true,
                Location = "produce"
            });
          
            return View(grocery);
        }
    }

}