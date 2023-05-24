using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Models
{
    public class Sales
    {
        public int IdSale { get; set; }
        public int IdUser { get; set; }
        public decimal Total { get; set; }
        public bool DriveThru { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
