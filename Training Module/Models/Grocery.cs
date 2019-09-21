﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Training_Module.Models
{
    public class Grocery
    {
        [Required]
        [MaxLength(20, ErrorMessage ="Name Cannot Exceed 20 Characters")]
        public string ItemName { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        [RegularExpression(@"\d{0,4}(\.\d{1,2})?$", 
            ErrorMessage = "Invalid Price Format")]
        public double Price { get; set; }
        public bool  GrabbedAlready { get; set; }
        public string Id { get; set; }
    }


}
