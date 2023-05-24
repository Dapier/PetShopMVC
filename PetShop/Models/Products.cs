using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Models
{
    public class Products
    {
        public int IdProduct { get; set; }
        public string DescriptionProduct { get; set; }
        public int TypeProduct { get; set; }
        public int Amount { get; set; }
        public string Unit { get; set; }
        public decimal UnitPrice { get; set; }
        public string Photo { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
