using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Training_Module.Models;
using Training_Module.Data;

namespace Training_Module.Controllers
{
    public class GroceryController : Controller
    {
        private List<Grocery> Groceries { get; set; }

        public GroceryController()
        {
            Groceries = SeedData.GetSeedDataSet().ToList();
        }

        public IActionResult Index()
        {
            return View(Groceries);
        }

        public IActionResult Create()
        {
           return View();
        }

        public IActionResult Edit()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }
    }

}