using Microsoft.AspNetCore.Mvc;
using Training_Module.Models;


namespace Training_Module.Controllers
{

    public class GroceryController : Controller
    {

        private readonly IGroceryInterface _groceriesRepo;

        public GroceryController(IGroceryInterface groceryRepo)
        {
            _groceriesRepo = groceryRepo;
        }     
        

        public IActionResult Index()
        {
            var list = _groceriesRepo.GetAllGroceries();
            return View(list);
            
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Grocery item)
        {
            if (ModelState.IsValid)
            {
                Grocery newGrocery = _groceriesRepo.Add(item);
                return RedirectToAction("Details", new { id = item.Id } );
            }

            return View();
        }

        public IActionResult Details(string id)
        {
            Grocery item = _groceriesRepo.GetGrocery(id);
            
            return View(item); 
        }

        [HttpGet]
        public IActionResult Edit(string id)
        {
            var item = _groceriesRepo.GetGrocery(id);
           
            return View(item);
        }

        [HttpPost]
        public IActionResult Edit(Grocery model)
        {
            if (ModelState.IsValid)
            {
                Grocery item = _groceriesRepo.GetGrocery(model.Id);
                item.ItemName = model.ItemName;
                item.Price = model.Price;
                item.Quantity = model.Quantity;
                item.GrabbedAlready = model.GrabbedAlready;

                return RedirectToAction("Index");
            };

            return View();
        }

        [HttpGet]
        public IActionResult Delete(string id)
        {
            Grocery item = _groceriesRepo.GetGrocery(id);
            return View(item);
        }

        [HttpPost]
        public IActionResult Delete(Grocery byeByeItem)
        {
            _groceriesRepo.Delete(byeByeItem);
            
            return RedirectToAction("Index");
        }
    }

}