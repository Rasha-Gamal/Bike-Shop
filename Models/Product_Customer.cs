using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeShop.Models
{
    public class Product_Customer
    {
        public int ProductId { get; set; }
        //navigation
        public Product _product { get; set; }

        public int CustomerId { get; set; }
        //navigation
        public Customer _customer { get; set; }
    }
}
