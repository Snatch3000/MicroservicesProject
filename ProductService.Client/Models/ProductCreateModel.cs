using System;
using System.Collections.Generic;
using System.Text;

namespace ProductService.Client.Models
{
    public class ProductCreateModel
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
