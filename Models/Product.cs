using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication12.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        public String Name { get; set; }
        public String QtyInStock { get; set; }
        public String Description { get; set; }
        public String Supplier { get; set; }
    }
}