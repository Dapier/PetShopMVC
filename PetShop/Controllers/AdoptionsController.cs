using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PetShop.Models;

namespace PetShop.Controllers
{
    
    public class AdoptionsController : Controller
    {
        public List<Adoptions> Adopciones { get; set; }

        public AdoptionsController()
        {
            Adopciones = new List<Adoptions>()
            {
                new Adoptions()
                {
                    IdAdoption = 1, IdUser= 1, IdAnimal = 1, DriveThru = false
                },
                new Adoptions()
                {
                    IdAdoption = 2, IdUser= 2, IdAnimal = 2, DriveThru = true
                }
            };
        }
        public IActionResult Index()
        {
            return View(Adopciones);
        }
    }
}
