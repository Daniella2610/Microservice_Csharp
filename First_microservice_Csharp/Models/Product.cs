using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First_microservice_Csharp.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int CatagoryId { get; set; }

    }
}
