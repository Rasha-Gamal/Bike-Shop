using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BikeShop.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required(ErrorMessage = "You must enter the Product Name")]
        [Display(Name = "Product Name")]
        public String ProductName { get; set; }

        [Required]
        [Display(Name = "Product Price")]
        [Column(TypeName = "decimal(10,2)")]
        public double ProductPrice { get; set; }
        [Required]
        [Display(Name ="Product Description")]
        public String ProductDescription { get; set; }
        [Display(Name ="Product Image")]
        public String ProductImage { get; set; }
        [Required]
        public double Discount { get; set; }
        [Required]
        public double Stock { get; set; }

        //forgein key
        public int CategoryID { get; set; }
        public Category Categories { get; set; }

        public ICollection <Product_Customer> CustomerList { get; set; }
        
    }
}
