using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Models
{
    public class Adoptions
    {
        public int IdAdoption { get; set; }
        public int IdUser { get; set; }
        public int IdAnimal { get; set; }
        public bool DriveThru { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
