using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace First_microservice_Csharp.Models
{
    public class CatalogItem
    {
        [Key]
        public int CatagoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        

    }
}
