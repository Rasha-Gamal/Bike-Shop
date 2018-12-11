using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BikeShop.Models
{
    public class Customer
    {

        public int CustomerId { get; set; }

        [Required(ErrorMessage ="You must enter your name")]
        [Display(Name ="Customer Name")]
        public string CustomerName { get; set; }

        [Required(ErrorMessage = "You must enter a password")]
        [StringLength(18,ErrorMessage ="Must be 18 characters")]
        public string Password { get; set; }

        [Required(ErrorMessage ="you must enter your E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "You must enter a your credit card number")]
        [Display(Name ="Credit Card Number")]
        public int CreditCardNumber { get; set; }

        [Required(ErrorMessage = "You must enter a your credit card Expiration date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyyy-mm}",ApplyFormatInEditMode =true)]
        public DateTime ExpirationDate { get; set; }

        [Required(ErrorMessage = "You must enter cvv")]
        public int Cvv { get; set; }

        public string Phone { get; set; }

        [Required(ErrorMessage = "You must enter a your address")]
        [Display(Name ="Customer Address")]
        public string Address { get; set; }

        public ICollection <Order> OrdersList { get; set; }
        public ICollection <Product_Customer> ProductList { get; set; }
        

    }

    
}
