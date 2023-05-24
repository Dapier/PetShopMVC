using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Models
{
    public class Animals
    {
        public int IdAnimal { get; set; }
        public string Breed { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }
        public string AgeDescription { get; set; }
        public string Descripcion { get; set; }
        public string Photo { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
