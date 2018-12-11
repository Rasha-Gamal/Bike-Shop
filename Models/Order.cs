using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BikeShop.Models
{
    public class Order
    {

        [Key]
        public int OrderID { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{dd:yyyy-mm}", ApplyFormatInEditMode = true)]
        [Display(Name ="Order date")]
        public DataType OrderDate { get; set; }

        [Required(ErrorMessage = "Quantity is required")]
        [Display(Name = "Quantity")]
        public int Quantity { get; set; }

        [Display(Name ="Additional details")]
        public string AdditionalDetails { get; set; }


        // forgein key customer id 
        public int CustomerID { get; set; }
        public Customer _Customers { get; set; }


        //forgein key product id 
        public int ProductId { get; set; }
        public Product _Prod { get; set; }

    }
}
