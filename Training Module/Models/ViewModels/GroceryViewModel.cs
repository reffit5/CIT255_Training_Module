using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Training_Module.ViewModels
{
    public class GroceryViewModel
    {
        [Required]
        [MaxLength(25, ErrorMessage = "Name Cannot Exceed 25 Characters")]
        public string ItemName { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        
        public double Price { get; set; }
        public bool GrabbedAlready { get; set; }
        public string Id { get; set; }
    }
}
