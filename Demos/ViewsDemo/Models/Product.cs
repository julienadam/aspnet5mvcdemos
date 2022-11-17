using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ViewsDemo.Models
{
    public class Product
    {
        [Required(ErrorMessage = "Name your product")]
        public string Name { get; set; }

        [Required]
        [Range(0.1, 100_000)]
        public decimal Price { get; set; }
    }
}