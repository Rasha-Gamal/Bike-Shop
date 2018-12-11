using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BikeShop.Models
{
    public class Category
    {

        public int CategoryID { get; set; }

       [Required]
       [Display(Name ="Category Name")]
        public string CategoryName { get; set; }



        public ICollection<Product> ProductsList { get; set; }
    }
}
