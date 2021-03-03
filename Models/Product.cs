using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc2021.Models
{
    public class Product
    {
        [Display(Name = "Product ID")]
        public int productID { get; set; }

        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        
    }
}
